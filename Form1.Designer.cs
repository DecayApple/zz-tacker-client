namespace zz_tracker_client
{
    partial class SettingForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.workTimerLabel = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ApplyBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.twit_id = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.extraexif_check = new System.Windows.Forms.CheckBox();
            this.classi_combo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.resol_combo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.workPeriod = new System.Windows.Forms.NumericUpDown();
            this.ext_combo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.runonboot_check = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.down_path_label = new System.Windows.Forms.Label();
            this.path_browse = new System.Windows.Forms.Button();
            this.contextMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workPeriod)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.contextMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "zz-tracker";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workTimerLabel,
            this.toolStripSeparator1,
            this.settingsToolStripMenuItem,
            this.toolStripSeparator2,
            this.closeToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenu.Size = new System.Drawing.Size(161, 85);
            // 
            // workTimerLabel
            // 
            this.workTimerLabel.Name = "workTimerLabel";
            this.workTimerLabel.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(224, 281);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 241);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CancelBtn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ApplyBtn);
            this.splitContainer1.Size = new System.Drawing.Size(218, 37);
            this.splitContainer1.SplitterDistance = 72;
            this.splitContainer1.TabIndex = 0;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelBtn.Location = new System.Drawing.Point(0, 0);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(72, 37);
            this.CancelBtn.TabIndex = 0;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ApplyBtn.Location = new System.Drawing.Point(0, 0);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(142, 37);
            this.ApplyBtn.TabIndex = 0;
            this.ApplyBtn.Text = "Apply";
            this.ApplyBtn.UseVisualStyleBackColor = true;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(218, 235);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.twit_id);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 15);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(216, 219);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Twitter ID: (ex. @_twitter)";
            // 
            // twit_id
            // 
            this.twit_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.twit_id.Location = new System.Drawing.Point(3, 18);
            this.twit_id.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.twit_id.Name = "twit_id";
            this.twit_id.Size = new System.Drawing.Size(210, 21);
            this.twit_id.TabIndex = 1;
            this.twit_id.TextChanged += new System.EventHandler(this.twit_id_TextChanged);
            this.twit_id.MouseHover += new System.EventHandler(this.twit_id_MouseHover);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.60378F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.39622F));
            this.tableLayoutPanel2.Controls.Add(this.extraexif_check, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.classi_combo, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.resol_combo, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.workPeriod, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ext_combo, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.runonboot_check, 1, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 44);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(216, 138);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // extraexif_check
            // 
            this.extraexif_check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.extraexif_check.AutoSize = true;
            this.extraexif_check.Location = new System.Drawing.Point(125, 119);
            this.extraexif_check.Margin = new System.Windows.Forms.Padding(3, 1, 1, 1);
            this.extraexif_check.Name = "extraexif_check";
            this.extraexif_check.Size = new System.Drawing.Size(90, 14);
            this.extraexif_check.TabIndex = 14;
            this.extraexif_check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.extraexif_check.UseVisualStyleBackColor = true;
            // 
            // classi_combo
            // 
            this.classi_combo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.classi_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classi_combo.FormattingEnabled = true;
            this.classi_combo.Location = new System.Drawing.Point(125, 70);
            this.classi_combo.Margin = new System.Windows.Forms.Padding(3, 1, 1, 1);
            this.classi_combo.Name = "classi_combo";
            this.classi_combo.Size = new System.Drawing.Size(90, 20);
            this.classi_combo.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 1, 1, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "Classify Type";
            this.label7.MouseHover += new System.EventHandler(this.label7_MouseHover);
            // 
            // resol_combo
            // 
            this.resol_combo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.resol_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resol_combo.FormattingEnabled = true;
            this.resol_combo.Location = new System.Drawing.Point(125, 47);
            this.resol_combo.Margin = new System.Windows.Forms.Padding(3, 1, 1, 1);
            this.resol_combo.Name = "resol_combo";
            this.resol_combo.Size = new System.Drawing.Size(90, 20);
            this.resol_combo.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 51);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 1, 1, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "Resolution Quality";
            this.label6.MouseHover += new System.EventHandler(this.label6_MouseHover);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 1, 1, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tracking Period";
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 1, 1, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Extension";
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // workPeriod
            // 
            this.workPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.workPeriod.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.workPeriod.Location = new System.Drawing.Point(125, 1);
            this.workPeriod.Margin = new System.Windows.Forms.Padding(3, 1, 1, 1);
            this.workPeriod.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.workPeriod.Name = "workPeriod";
            this.workPeriod.Size = new System.Drawing.Size(90, 21);
            this.workPeriod.TabIndex = 6;
            this.workPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ext_combo
            // 
            this.ext_combo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ext_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ext_combo.FormattingEnabled = true;
            this.ext_combo.Location = new System.Drawing.Point(125, 24);
            this.ext_combo.Margin = new System.Windows.Forms.Padding(3, 1, 1, 1);
            this.ext_combo.Name = "ext_combo";
            this.ext_combo.Size = new System.Drawing.Size(90, 20);
            this.ext_combo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 1, 1, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "Store EXIF ";
            this.label5.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 1, 1, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Run on Boot";
            this.label4.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            // 
            // runonboot_check
            // 
            this.runonboot_check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.runonboot_check.AutoSize = true;
            this.runonboot_check.Location = new System.Drawing.Point(125, 96);
            this.runonboot_check.Margin = new System.Windows.Forms.Padding(3, 1, 1, 1);
            this.runonboot_check.Name = "runonboot_check";
            this.runonboot_check.Size = new System.Drawing.Size(90, 14);
            this.runonboot_check.TabIndex = 13;
            this.runonboot_check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.runonboot_check.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 183);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 1, 1, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "Download Path";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.Controls.Add(this.down_path_label, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.path_browse, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 196);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(216, 21);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // down_path_label
            // 
            this.down_path_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.down_path_label.AutoSize = true;
            this.down_path_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.down_path_label.Location = new System.Drawing.Point(3, 3);
            this.down_path_label.Name = "down_path_label";
            this.down_path_label.Size = new System.Drawing.Size(177, 14);
            this.down_path_label.TabIndex = 0;
            this.down_path_label.MouseHover += new System.EventHandler(this.down_path_label_MouseHover);
            // 
            // path_browse
            // 
            this.path_browse.Location = new System.Drawing.Point(184, 1);
            this.path_browse.Margin = new System.Windows.Forms.Padding(1);
            this.path_browse.Name = "path_browse";
            this.path_browse.Size = new System.Drawing.Size(31, 19);
            this.path_browse.TabIndex = 1;
            this.path_browse.Text = "...";
            this.path_browse.UseVisualStyleBackColor = true;
            this.path_browse.Click += new System.EventHandler(this.path_browse_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 281);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingForm";
            this.Text = "Zz-Tracker Settings";
            this.contextMenu.ResumeLayout(false);
            this.contextMenu.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workPeriod)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox workTimerLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button ApplyBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox twit_id;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox resol_combo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown workPeriod;
        private System.Windows.Forms.ComboBox ext_combo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox extraexif_check;
        private System.Windows.Forms.ComboBox classi_combo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox runonboot_check;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label down_path_label;
        private System.Windows.Forms.Button path_browse;
    }
}

