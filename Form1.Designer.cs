namespace Secury
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "succeeded",
            "\'sa\'",
            "178.214.55.56"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "failed",
            "\'aa\'",
            "178.214.55.66"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "failed",
            "\'sa\'",
            "165.99.55.77"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "succeeded",
            "\'gf\'",
            "217.178.45.65"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.el = new System.Diagnostics.EventLog();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbFOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbFExportToExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbFExportToCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAction = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbAStart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbAStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAAnalyze = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAClearResult = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.chkbShowDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbsUnbanScaner = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbsSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBanList = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkbDate = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bLoadDefault = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bBlock = new System.Windows.Forms.Button();
            this.bAnalyze = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.bSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lEventCategory = new System.Windows.Forms.Label();
            this.lEventSource = new System.Windows.Forms.Label();
            this.lEventLogs = new System.Windows.Forms.Label();
            this.cbCollectEventSource = new System.Windows.Forms.ComboBox();
            this.cbCollectEventCategory = new System.Windows.Forms.ComboBox();
            this.cbCollectEventLogs = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tspbStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.el)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.cmsNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // el
            // 
            this.el.Log = "Application";
            this.el.SynchronizingObject = this;
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDate,
            this.chState,
            this.chName,
            this.chIP});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listView1.Location = new System.Drawing.Point(254, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(530, 238);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chDate
            // 
            this.chDate.Text = "Date";
            this.chDate.Width = 89;
            // 
            // chState
            // 
            this.chState.Text = "State";
            this.chState.Width = 73;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 169;
            // 
            // chIP
            // 
            this.chIP.Text = "IP";
            this.chIP.Width = 189;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFile,
            this.toolStripSeparator1,
            this.tsbAction,
            this.tsbSettings,
            this.toolStripSeparator2,
            this.tsbBanList});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsbFile
            // 
            this.tsbFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFOpen,
            this.toolStripMenuItem3,
            this.exportToolStripMenuItem,
            this.toolStripMenuItem4,
            this.tsbFClose});
            this.tsbFile.Image = global::Secury.Properties.Resources.monitor;
            this.tsbFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFile.Name = "tsbFile";
            this.tsbFile.Size = new System.Drawing.Size(54, 22);
            this.tsbFile.Text = "File";
            // 
            // tsbFOpen
            // 
            this.tsbFOpen.Image = global::Secury.Properties.Resources.book_next;
            this.tsbFOpen.Name = "tsbFOpen";
            this.tsbFOpen.Size = new System.Drawing.Size(152, 22);
            this.tsbFOpen.Text = "Open";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(149, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFExportToExcel,
            this.tsbFExportToCSV});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToolStripMenuItem.Text = "Export to";
            // 
            // tsbFExportToExcel
            // 
            this.tsbFExportToExcel.Image = global::Secury.Properties.Resources.page_white_excel;
            this.tsbFExportToExcel.Name = "tsbFExportToExcel";
            this.tsbFExportToExcel.Size = new System.Drawing.Size(152, 22);
            this.tsbFExportToExcel.Text = "Excel";
            // 
            // tsbFExportToCSV
            // 
            this.tsbFExportToCSV.Name = "tsbFExportToCSV";
            this.tsbFExportToCSV.Size = new System.Drawing.Size(152, 22);
            this.tsbFExportToCSV.Text = "CSV";
            this.tsbFExportToCSV.Click += new System.EventHandler(this.tsbFExportToCSV_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(149, 6);
            // 
            // tsbFClose
            // 
            this.tsbFClose.Image = global::Secury.Properties.Resources.door_in;
            this.tsbFClose.Name = "tsbFClose";
            this.tsbFClose.Size = new System.Drawing.Size(152, 22);
            this.tsbFClose.Text = "Close";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAction
            // 
            this.tsbAction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAStart,
            this.tsbAStop,
            this.toolStripMenuItem1,
            this.tsbAAnalyze,
            this.toolStripMenuItem2,
            this.tsbAClearResult});
            this.tsbAction.Image = global::Secury.Properties.Resources.lightning;
            this.tsbAction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAction.Name = "tsbAction";
            this.tsbAction.Size = new System.Drawing.Size(71, 22);
            this.tsbAction.Text = "Action";
            // 
            // tsbAStart
            // 
            this.tsbAStart.Image = global::Secury.Properties.Resources.control_play;
            this.tsbAStart.Name = "tsbAStart";
            this.tsbAStart.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.tsbAStart.Size = new System.Drawing.Size(187, 22);
            this.tsbAStart.Text = "Start Search";
            this.tsbAStart.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // tsbAStop
            // 
            this.tsbAStop.Image = global::Secury.Properties.Resources.control_stop;
            this.tsbAStop.Name = "tsbAStop";
            this.tsbAStop.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.tsbAStop.Size = new System.Drawing.Size(187, 22);
            this.tsbAStop.Text = "Stop";
            this.tsbAStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(184, 6);
            // 
            // tsbAAnalyze
            // 
            this.tsbAAnalyze.Image = global::Secury.Properties.Resources.chart_bar;
            this.tsbAAnalyze.Name = "tsbAAnalyze";
            this.tsbAAnalyze.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F11)));
            this.tsbAAnalyze.Size = new System.Drawing.Size(187, 22);
            this.tsbAAnalyze.Text = "Analyze";
            this.tsbAAnalyze.Click += new System.EventHandler(this.bAnalyze_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(184, 6);
            // 
            // tsbAClearResult
            // 
            this.tsbAClearResult.Image = global::Secury.Properties.Resources.sport_shuttlecock;
            this.tsbAClearResult.Name = "tsbAClearResult";
            this.tsbAClearResult.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.tsbAClearResult.Size = new System.Drawing.Size(187, 22);
            this.tsbAClearResult.Text = "Clear Result";
            this.tsbAClearResult.Click += new System.EventHandler(this.bClear_Click);
            // 
            // tsbSettings
            // 
            this.tsbSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chkbShowDate,
            this.tsbsUnbanScaner,
            this.tsbsSettings});
            this.tsbSettings.Image = global::Secury.Properties.Resources.cog;
            this.tsbSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSettings.Name = "tsbSettings";
            this.tsbSettings.Size = new System.Drawing.Size(88, 22);
            this.tsbSettings.Text = "Functions";
            // 
            // chkbShowDate
            // 
            this.chkbShowDate.Checked = true;
            this.chkbShowDate.CheckOnClick = true;
            this.chkbShowDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbShowDate.Image = global::Secury.Properties.Resources.table;
            this.chkbShowDate.Name = "chkbShowDate";
            this.chkbShowDate.Size = new System.Drawing.Size(154, 22);
            this.chkbShowDate.Text = "Show Date";
            this.chkbShowDate.CheckedChanged += new System.EventHandler(this.chkbShowDate_CheckedChanged);
            // 
            // tsbsUnbanScaner
            // 
            this.tsbsUnbanScaner.Image = global::Secury.Properties.Resources.page;
            this.tsbsUnbanScaner.Name = "tsbsUnbanScaner";
            this.tsbsUnbanScaner.Size = new System.Drawing.Size(154, 22);
            this.tsbsUnbanScaner.Text = "Unban Scanner";
            this.tsbsUnbanScaner.Click += new System.EventHandler(this.chkbUnbanScaner_Click);
            // 
            // tsbsSettings
            // 
            this.tsbsSettings.Image = global::Secury.Properties.Resources.control_equalizer;
            this.tsbsSettings.Name = "tsbsSettings";
            this.tsbsSettings.Size = new System.Drawing.Size(154, 22);
            this.tsbsSettings.Text = "Settings";
            this.tsbsSettings.Click += new System.EventHandler(this.tsbsSettings_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbBanList
            // 
            this.tsbBanList.Image = global::Secury.Properties.Resources.script;
            this.tsbBanList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBanList.Name = "tsbBanList";
            this.tsbBanList.Size = new System.Drawing.Size(77, 22);
            this.tsbBanList.Text = "Block List";
            this.tsbBanList.Click += new System.EventHandler(this.bBlock_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkbDate);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.bLoadDefault);
            this.panel1.Controls.Add(this.bClear);
            this.panel1.Controls.Add(this.bBlock);
            this.panel1.Controls.Add(this.bAnalyze);
            this.panel1.Controls.Add(this.bStop);
            this.panel1.Controls.Add(this.bSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lEventCategory);
            this.panel1.Controls.Add(this.lEventSource);
            this.panel1.Controls.Add(this.lEventLogs);
            this.panel1.Controls.Add(this.cbCollectEventSource);
            this.panel1.Controls.Add(this.cbCollectEventCategory);
            this.panel1.Controls.Add(this.cbCollectEventLogs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 238);
            this.panel1.TabIndex = 2;
            // 
            // chkbDate
            // 
            this.chkbDate.AutoSize = true;
            this.chkbDate.Checked = true;
            this.chkbDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbDate.Location = new System.Drawing.Point(226, 118);
            this.chkbDate.Name = "chkbDate";
            this.chkbDate.Size = new System.Drawing.Size(15, 14);
            this.chkbDate.TabIndex = 14;
            this.chkbDate.UseVisualStyleBackColor = true;
            this.chkbDate.CheckedChanged += new System.EventHandler(this.chkbDate_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(91, 114);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(129, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Value = new System.DateTime(2017, 6, 20, 0, 0, 0, 0);
            // 
            // bLoadDefault
            // 
            this.bLoadDefault.Image = global::Secury.Properties.Resources.book_next;
            this.bLoadDefault.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bLoadDefault.Location = new System.Drawing.Point(91, 3);
            this.bLoadDefault.Name = "bLoadDefault";
            this.bLoadDefault.Size = new System.Drawing.Size(96, 24);
            this.bLoadDefault.TabIndex = 12;
            this.bLoadDefault.Text = "Load Default";
            this.bLoadDefault.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bLoadDefault.UseVisualStyleBackColor = true;
            this.bLoadDefault.Click += new System.EventHandler(this.bLoadDefault_Click);
            // 
            // bClear
            // 
            this.bClear.Image = global::Secury.Properties.Resources.sport_shuttlecock;
            this.bClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bClear.Location = new System.Drawing.Point(166, 190);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 24);
            this.bClear.TabIndex = 10;
            this.bClear.Text = "Clear";
            this.bClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bBlock
            // 
            this.bBlock.Image = global::Secury.Properties.Resources.script;
            this.bBlock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bBlock.Location = new System.Drawing.Point(91, 190);
            this.bBlock.Name = "bBlock";
            this.bBlock.Size = new System.Drawing.Size(75, 24);
            this.bBlock.TabIndex = 11;
            this.bBlock.Text = "Block";
            this.bBlock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bBlock.UseVisualStyleBackColor = true;
            this.bBlock.Click += new System.EventHandler(this.bBlock_Click);
            // 
            // bAnalyze
            // 
            this.bAnalyze.Image = global::Secury.Properties.Resources.chart_bar;
            this.bAnalyze.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAnalyze.Location = new System.Drawing.Point(129, 165);
            this.bAnalyze.Name = "bAnalyze";
            this.bAnalyze.Size = new System.Drawing.Size(75, 24);
            this.bAnalyze.TabIndex = 11;
            this.bAnalyze.Text = "Analyze";
            this.bAnalyze.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bAnalyze.UseVisualStyleBackColor = true;
            this.bAnalyze.Click += new System.EventHandler(this.bAnalyze_Click);
            // 
            // bStop
            // 
            this.bStop.Image = global::Secury.Properties.Resources.control_stop;
            this.bStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bStop.Location = new System.Drawing.Point(166, 140);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(75, 24);
            this.bStop.TabIndex = 9;
            this.bStop.Text = "Stop";
            this.bStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // bSearch
            // 
            this.bSearch.Image = global::Secury.Properties.Resources.control_play;
            this.bSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSearch.Location = new System.Drawing.Point(91, 140);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(75, 24);
            this.bSearch.TabIndex = 9;
            this.bSearch.Text = "Search";
            this.bSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date:";
            // 
            // lEventCategory
            // 
            this.lEventCategory.AutoSize = true;
            this.lEventCategory.Location = new System.Drawing.Point(5, 90);
            this.lEventCategory.Name = "lEventCategory";
            this.lEventCategory.Size = new System.Drawing.Size(80, 13);
            this.lEventCategory.TabIndex = 1;
            this.lEventCategory.Text = "EventCategory:";
            // 
            // lEventSource
            // 
            this.lEventSource.AutoSize = true;
            this.lEventSource.Location = new System.Drawing.Point(13, 63);
            this.lEventSource.Name = "lEventSource";
            this.lEventSource.Size = new System.Drawing.Size(72, 13);
            this.lEventSource.TabIndex = 1;
            this.lEventSource.Text = "EventSource:";
            // 
            // lEventLogs
            // 
            this.lEventLogs.AutoSize = true;
            this.lEventLogs.Location = new System.Drawing.Point(24, 36);
            this.lEventLogs.Name = "lEventLogs";
            this.lEventLogs.Size = new System.Drawing.Size(61, 13);
            this.lEventLogs.TabIndex = 1;
            this.lEventLogs.Text = "EventLogs:";
            // 
            // cbCollectEventSource
            // 
            this.cbCollectEventSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCollectEventSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCollectEventSource.FormattingEnabled = true;
            this.cbCollectEventSource.Items.AddRange(new object[] {
            "MSSQLSERVER"});
            this.cbCollectEventSource.Location = new System.Drawing.Point(91, 60);
            this.cbCollectEventSource.Name = "cbCollectEventSource";
            this.cbCollectEventSource.Size = new System.Drawing.Size(150, 21);
            this.cbCollectEventSource.TabIndex = 0;
            // 
            // cbCollectEventCategory
            // 
            this.cbCollectEventCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCollectEventCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCollectEventCategory.FormattingEnabled = true;
            this.cbCollectEventCategory.Items.AddRange(new object[] {
            "Logon",
            "---Reload---"});
            this.cbCollectEventCategory.Location = new System.Drawing.Point(91, 87);
            this.cbCollectEventCategory.Name = "cbCollectEventCategory";
            this.cbCollectEventCategory.Size = new System.Drawing.Size(150, 21);
            this.cbCollectEventCategory.TabIndex = 0;
            this.cbCollectEventCategory.SelectedIndexChanged += new System.EventHandler(this.cbCollectEventCategory_SelectedIndexChanged);
            // 
            // cbCollectEventLogs
            // 
            this.cbCollectEventLogs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCollectEventLogs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCollectEventLogs.FormattingEnabled = true;
            this.cbCollectEventLogs.Location = new System.Drawing.Point(91, 33);
            this.cbCollectEventLogs.Name = "cbCollectEventLogs";
            this.cbCollectEventLogs.Size = new System.Drawing.Size(150, 21);
            this.cbCollectEventLogs.TabIndex = 0;
            this.cbCollectEventLogs.SelectedIndexChanged += new System.EventHandler(this.cbCollectEventLogs_SelectedIndexChanged_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspbStatus,
            this.tslStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 263);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(784, 24);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tspbStatus
            // 
            this.tspbStatus.Name = "tspbStatus";
            this.tspbStatus.Size = new System.Drawing.Size(200, 18);
            // 
            // tslStatus
            // 
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(45, 19);
            this.tslStatus.Text = "Status: ";
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Location = new System.Drawing.Point(252, 25);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 238);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.notifyIcon1.BalloonTipText = "11";
            this.notifyIcon1.BalloonTipTitle = "11123";
            this.notifyIcon1.ContextMenuStrip = this.cmsNotify;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "ni";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // cmsNotify
            // 
            this.cmsNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.toolStripMenuItem6,
            this.toolStripProgressBar1,
            this.toolStripMenuItem7,
            this.toolStripMenuItem9,
            this.toolStripMenuItem8,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripMenuItem5,
            this.toolStripMenuItem10,
            this.exitToolStripMenuItem});
            this.cmsNotify.Name = "cmsNotify";
            this.cmsNotify.Size = new System.Drawing.Size(161, 197);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Image = global::Secury.Properties.Resources.control_equalizer;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem5.Text = "Settings";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.tsbsSettings_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Image = global::Secury.Properties.Resources.control_play;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem6.Text = "Start Search";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Image = global::Secury.Properties.Resources.control_stop;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem7.Text = "Stop";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.bStop_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Image = global::Secury.Properties.Resources.chart_bar;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem8.Text = "Analyze";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.bAnalyze_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(157, 6);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(157, 6);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(157, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Secury.Properties.Resources.script;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(160, 22);
            this.toolStripButton1.Text = "Block List";
            this.toolStripButton1.Click += new System.EventHandler(this.bBlock_Click);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 18);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Image = global::Secury.Properties.Resources.monitor;
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 287);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.el)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.cmsNotify.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.EventLog el;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chIP;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbCollectEventSource;
        private System.Windows.Forms.ComboBox cbCollectEventCategory;
        private System.Windows.Forms.ComboBox cbCollectEventLogs;
        private System.Windows.Forms.Label lEventSource;
        private System.Windows.Forms.Label lEventLogs;
        private System.Windows.Forms.Label lEventCategory;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
        private System.Windows.Forms.ToolStripProgressBar tspbStatus;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.ColumnHeader chState;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bAnalyze;
        private System.Windows.Forms.ToolStripDropDownButton tsbSettings;
        private System.Windows.Forms.ToolStripMenuItem chkbShowDate;
        private System.Windows.Forms.Button bLoadDefault;
        private System.Windows.Forms.ToolStripDropDownButton tsbFile;
        private System.Windows.Forms.ToolStripMenuItem tsbFOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsbFExportToExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem tsbFClose;
        private System.Windows.Forms.ToolStripDropDownButton tsbAction;
        private System.Windows.Forms.ToolStripMenuItem tsbAStart;
        private System.Windows.Forms.ToolStripMenuItem tsbAStop;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsbAAnalyze;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsbAClearResult;
        private System.Windows.Forms.ToolStripMenuItem tsbsUnbanScaner;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbBanList;
        private System.Windows.Forms.Button bBlock;
        private System.Windows.Forms.CheckBox chkbDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem tsbFExportToCSV;
        private System.Windows.Forms.ToolStripMenuItem tsbsSettings;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip cmsNotify;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
    }
}

