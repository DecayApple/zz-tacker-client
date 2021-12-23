using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zz_tracker_client
{
    public class ConfigManage
    {
        bool isLoaded;
        string _path;
        ConfigData _config;
        public ConfigManage()
        {
            isLoaded = false;
            _config = new ConfigData();

            _path = "./config.json";
            if (!File.Exists(_path)) defaultConfigSetting();
            loadConfigData();
            writeConfigData(_config);

            isLoaded = true;
        }
        public ConfigData getConfig()
        {
            return _config;
        }
        public bool getInitComplete()
        {
            return isLoaded;
        }

        private void defaultConfigSetting()
        {
            //Delete and Create
            if (File.Exists(_path)) File.Delete(_path);
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(Application.StartupPath + @"\Download");
            if (!di.Exists) { di.Create(); }

            //Def. Settings
            JObject dbSpec = new JObject(
                new JProperty("TWITTER_ID", "@N/A"),
                new JProperty("TWITTER_RECENT_FAV", "0"),
                new JProperty("TIMER_MIN", "180"),
                new JProperty("EXTENSIONS", "0"),
                new JProperty("RESOLUTION", "0"),
                new JProperty("DOWNLOAD_PATH", di.FullName),
                new JProperty("CLASSIFY", "0"),
                new JProperty("BOOT_ON", "false"),
                new JProperty("EXIF_SAVE", "false")
            );
            File.WriteAllText(_path, dbSpec.ToString());
        }

        public void loadConfigData()
        {
            try
            {
                using (StreamReader file = File.OpenText(_path))
                {
                    using (JsonTextReader reader = new JsonTextReader(file))
                    {
                        JObject json = (JObject)JToken.ReadFrom(reader);
                        _config.twit_id = (string)json["TWITTER_ID"].ToString();
                        _config.twit_last = (string)json["TWITTER_RECENT_FAV"].ToString();
                        _config.timer = (string)json["TIMER_MIN"].ToString();
                        _config.classify = (string)json["CLASSIFY"].ToString();
                        _config.path = (string)json["DOWNLOAD_PATH"].ToString();
                        _config.boot_on = (string)json["BOOT_ON"].ToString();
                        _config.ext = (string)json["EXTENSIONS"].ToString();
                        _config.resolution = (string)json["RESOLUTION"].ToString();
                        _config.exif = (string)json["EXIF_SAVE"].ToString();
                    }
                }
            }
            catch
            {
                defaultConfigSetting();
                loadConfigData();
            }
        }
        public void checkConfigValidation(ConfigData data) //error check
        {
            int tmp;

            if (!int.TryParse(data.timer, out tmp))
            {
                data.timer = "180";
            }
            else
            {
                if (tmp < 5)
                    data.timer = "0";
            }

            if (!Directory.Exists(data.path))
            {
                try
                {
                    Directory.CreateDirectory(data.path);
                }
                catch { data.path = "./"; }
            }

            if (data.boot_on != true.ToString() && data.boot_on != false.ToString())
            {
                data.boot_on = false.ToString();
            }

            if (data.exif != true.ToString() && data.exif != false.ToString())
            {
                data.exif = false.ToString();
            }


            data.ext = data.ext.ToUpper();
            if (data.ext == "0"
                || data.ext == "1"
                || data.ext == "2")
            {
                ;
            }
            else
            {
                data.ext = "0";
            }

            if (int.TryParse(data.resolution, out tmp))
            {
                if (tmp < 0 || tmp > 2)
                    data.resolution = "0";
            }
            else
            {
                data.resolution = "0";
            }                       
        }
        public void writeConfigData( ConfigData data )
        {
            checkConfigValidation(data);
            JObject dbSpec = new JObject(
                new JProperty("TWITTER_ID", data.twit_id),
                new JProperty("TWITTER_RECENT_FAV", data.twit_last),
                new JProperty("TIMER_MIN", data.timer),
                new JProperty("EXTENSIONS", data.ext),
                new JProperty("RESOLUTION", data.resolution),
                new JProperty("DOWNLOAD_PATH", data.path),
                new JProperty("CLASSIFY", data.classify),
                new JProperty("BOOT_ON", data.boot_on),
                new JProperty("EXIF_SAVE", data.exif)
            );
            File.WriteAllText(_path, dbSpec.ToString());
        }
    }

    public class ConfigData
    {
        public string twit_id = string.Empty;
        public string twit_last = string.Empty;
        public string timer = string.Empty;
        public string ext = string.Empty;
        public string resolution = string.Empty;
        public string path = string.Empty;
        public string classify = string.Empty;
        public string boot_on = string.Empty;
        public string exif =  string.Empty;
    }
}
