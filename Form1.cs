using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using Newtonsoft.Json.Linq;

namespace zz_tracker_client
{
    public partial class SettingForm : Form
    {
        ConfigManage _config;

        int _elapsedTime;
        Timer _timer;

        const string _pyNone = "None";
        const string _csNone = "-1";
        const string _pyTrue = "True";
        const string _csTrue = "true";
        const string _pyFalse = "False";
        const string _csFalse = "false";

        const string _geturl = "https://zz-process-favorite.azurewebsites.net/api/zz-process-client?Screen={0}&Recent={1}";
        //const string _geturl = "http://localhost:7071/api/zz-process-client?Screen={0}&Recent={1}";

        static readonly HttpClient _client = new HttpClient();
        WebClient _downClient = new WebClient();

        public SettingForm()
        {
            _config = new ConfigManage();
            InitializeComponent();
            confingEnumSetting();
            WindowState = FormWindowState.Minimized;
            
            ShowInTaskbar = false;
            Visible = false;
            trayIcon.Visible = true;                
            
            _timer = new Timer();
            _timer.Tick += _work_timer_handler;
            _timer.Interval = 1000 * 60; //1 min.
            _timer.Start();
            _elapsedTime = 0;
            workTimerLabel.Enabled = false;
            workTimerLabel.Text = "Load...";            
            _work_timer_handler(null, null);

            _main_working_process();
        }

        private void confingEnumSetting()
        {
            ext_combo.Items.Clear();
           // ext_combo.Items.Add("PNG");
            ext_combo.Items.Add("Origin");
          //  ext_combo.Items.Add("WEBP");

            resol_combo.Items.Clear();
            resol_combo.Items.Add("Origin");
            resol_combo.Items.Add("Normal");

            classi_combo.Items.Clear();
            classi_combo.Items.Add("None");
            classi_combo.Items.Add("Date");
            classi_combo.Items.Add("User");
        }

        private async Task _main_working_process()
        {
            Console.WriteLine("Worker start");

            _config.loadConfigData();
            string _screen_name = _config.getConfig().twit_id;
            string _recent_id = _config.getConfig().twit_last;
            string _url = String.Format(_geturl, _screen_name, _recent_id);

            if (_screen_name == "@N/A") return;

            Console.WriteLine(_url);
            var responseBody = await _client.GetByteArrayAsync(_url);
            Console.WriteLine("Workout");
            
            Console.WriteLine("Data loaded...{0} characters", responseBody.Length);

            string resolutionType = "";

            switch ( _config.getConfig().resolution )
            {
                case "0":
                    resolutionType = "?name=orig";
                    break;
                case "1":
                    break;
            }
            Console.WriteLine("Config process...");
            string rootPath = _config.getConfig().path;
            bool pathUserName = false;
            switch ( _config.getConfig().classify )
            {
                case "0"://none
                    break;
                case "1"://date
                    rootPath = Path.Combine(rootPath, getToday8());
                    if (!Directory.Exists(rootPath))
                    {
                        Directory.CreateDirectory(rootPath);
                    }                    
                    break;
                case "2":
                    {
                        pathUserName = true;
                    }break;
            }
            Console.WriteLine("Data pre-process over");
            string str_responseBody = Encoding.UTF8.GetString(responseBody);
            str_responseBody = str_responseBody.Replace(_pyFalse, _csFalse)
                                            .Replace(_pyTrue, _csTrue)
                                            .Replace(_pyNone, _csNone).
                                            Replace("\\", "/");
            JArray objArray = JArray.Parse(str_responseBody);
            Console.WriteLine("Data Parsed");
            foreach (JObject obj in objArray.Reverse())
            //for( int i = objArray.Count - 1; i >= 0; i-- )
            {
                string target_screen = "@" + obj["user"]["screen_name"].ToString();
                string target_path = "";
                string target_text = "";
                if (pathUserName)
                {
                    target_path = Path.Combine(rootPath, target_screen);
                    if (!Directory.Exists( target_path ))
                    {
                        Directory.CreateDirectory( target_path );
                    }
                }
                else
                {
                    target_path = rootPath;
                }
                target_text = obj["text"].ToString();
                Console.WriteLine("Work to {0} path", target_path);
                try
                {
                    foreach (JObject sub in obj["extended_entities"]["media"])
                    {
                        try
                        {                            
                            string downUrl = sub["media_url"].ToString();
                            string fileName = Path.GetFileName(downUrl);

                            Console.WriteLine("Download : {0}", downUrl + resolutionType);
                            Console.WriteLine("Filename : {0}", Path.Combine(target_path, fileName));
                            _downClient.DownloadFile(
                               downUrl + resolutionType,
                                Path.Combine(target_path, fileName)
                                ) ;
                            Console.WriteLine("Download ok!");
                            Console.WriteLine("{0} :: {1}", sub["id_str"].ToString(), _config.getConfig().twit_last);
                            if (ulong.Parse(sub["id_str"].ToString()) > ulong.Parse(_config.getConfig().twit_last))
                            {
                                _config.getConfig().twit_last = sub["id_str"].ToString();
                                _config.writeConfigData(_config.getConfig());
                                Console.WriteLine("ID refresh ok!", sub["id_str"].ToString());
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Downfailed! {0}{1}", ex.Message, sub["media_url"].ToString());
                            continue;
                        }//백업기능 . json 일단 다운받아놓고 다 다운완료되면 remove
                    }
                }
                catch (Exception ex)
                {
                    continue;
                }
            }

        }

        private void _work_timer_handler( object sender, EventArgs e )
        {
            if (!_config.getInitComplete()) return;

            int wait = 0;
            int.TryParse(_config.getConfig().timer, out wait);

            if ( _elapsedTime == wait )
            {
                //Working Timing                
                _main_working_process();
                _elapsedTime = 0;
            }

            this.workTimerLabel.Text = String.Format("Remain {0} min.", (wait-_elapsedTime));

            _elapsedTime++;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            popUpSettingForm();
        }
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            popUpSettingForm();
        }
        private void popUpSettingForm()
        {
            Visible = true;
            WindowState = FormWindowState.Normal;

            if( _config.getInitComplete())
            {
                var conf = _config.getConfig();
                
                twit_id.Text = conf.twit_id;
                workPeriod.Value = int.Parse(conf.timer);
                ext_combo.SelectedIndex = int.Parse(conf.ext);
                resol_combo.SelectedIndex = int.Parse(conf.resolution);
                classi_combo.SelectedIndex = int.Parse(conf.classify);
                runonboot_check.Checked = bool.Parse(conf.boot_on);
                extraexif_check.Checked = bool.Parse(conf.exif);
                down_path_label.Text = conf.path;
            }

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            Visible = false;
            trayIcon.Visible = true;
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            ConfigData conf = new ConfigData();

            conf.twit_id = twit_id.Text;
            conf.timer = workPeriod.Value.ToString();
            conf.ext = ext_combo.SelectedIndex.ToString();
            conf.resolution = resol_combo.SelectedIndex.ToString();
            conf.classify = classi_combo.SelectedIndex.ToString();  
            conf.exif = extraexif_check.Checked.ToString();
            conf.boot_on = runonboot_check.Checked.ToString();
            conf.path = down_path_label.Text;
            conf.twit_last = _config.getConfig().twit_last;

            _config.writeConfigData(conf);
            _config.loadConfigData();

            
            if(runonboot_check.Checked) //ref https://codeggoon.tistory.com/34
            {
                try
                {
                    // 시작프로그램 등록하는 레지스트리
                    string runKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
                    RegistryKey strUpKey = Registry.LocalMachine.OpenSubKey(runKey);
                    if (strUpKey.GetValue("zz-Tracker-exe") == null)
                    {
                        strUpKey.Close();
                        strUpKey = Registry.LocalMachine.OpenSubKey(runKey, true);
                        // 시작프로그램 등록명과 exe경로를 레지스트리에 등록
                        strUpKey.SetValue("zz-Tracker-exe", Application.ExecutablePath);
                    }
                }
                catch
                {
                    MessageBox.Show("Add Startup Fail");
                }
            }
            else
            {
                try
                {
                    string runKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
                    RegistryKey strUpKey = Registry.LocalMachine.OpenSubKey(runKey, true);
                    // 레지스트리값 제거
                    strUpKey.DeleteValue("zz-Tracker-exe");
                }
                catch
                {
                    ;// MessageBox.Show("Remove Startup Fail");
                }
            }


            if (conf.twit_id.Length < 5)
                MessageBox.Show("Twitter Id has wrong!");
            else
            {
                MessageBox.Show("Settings has applied!");

                _main_working_process();
                CancelBtn_Click(sender, e);
            }
        }

        private void path_browse_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true; // true : 폴더 선택 / false : 파일 선택
            dialog.InitialDirectory = down_path_label.Text;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                down_path_label.Text = dialog.FileName;
            }
        }
        private string getToday8()
        {
            DateTime now = DateTime.Now;
            return now.ToString("yyyyMMdd");
        }

        private void _takeToolTip(object sender, string str)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip((Control)sender, str);
            toolTip.IsBalloon = true;
            toolTip.ToolTipTitle = "Settings";
        }

        private void down_path_label_MouseHover(object sender, EventArgs e)
        {
            _takeToolTip(sender, ((Label)sender).Text);
        }

        private void twit_id_TextChanged(object sender, EventArgs e)
        {
            TextBox t = ((TextBox)sender);
            if (t.Text.Length < 1)
            {
                t.Text = "@";
                t.SelectionStart = t.TextLength;
                t.SelectionLength = 0;
            }
        }

        private void twit_id_MouseHover(object sender, EventArgs e)
        {
            _takeToolTip(sender, "Please input twitter account screens name" );
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            _takeToolTip(sender, "Favorite process working timer, 0 is only work at executed");
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            _takeToolTip(sender, "Extension of downloaded images");
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            _takeToolTip(sender, "Classify of downloaded images subfolder");
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            _takeToolTip(sender, "Automatically running at Booted");
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            _takeToolTip(sender, "Store images User/Desciption Data in Image's EXIF area");
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            _takeToolTip(sender, "Resolution level of downloaded images");
        }
    }
}
