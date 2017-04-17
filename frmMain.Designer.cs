namespace xTwitter_collector
{
    partial class frmMain
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
            this.groupBox_DBConnection = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_DBConnection_1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_User = new System.Windows.Forms.Label();
            this.textBox_User = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.btnDbConnectionTest = new System.Windows.Forms.Button();
            this.groupBox_APIToken = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_APIToken = new System.Windows.Forms.TableLayoutPanel();
            this.lvApiToken = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripLvApiToken = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tbApiTokenAccessTokenSecret = new System.Windows.Forms.TextBox();
            this.btnApiTokenAdd = new System.Windows.Forms.Button();
            this.tbApiTokenAccessToken = new System.Windows.Forms.TextBox();
            this.tbApiTokenName = new System.Windows.Forms.TextBox();
            this.tbApiTokenConsumerKey = new System.Windows.Forms.TextBox();
            this.tbApiTokenConsumerSecret = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDbConfig = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel_DBConnection = new System.Windows.Forms.TableLayoutPanel();
            this.tabApiToken = new System.Windows.Forms.TabPage();
            this.tabCollectTest = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_CollectTest = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_CollectTest_1 = new System.Windows.Forms.TableLayoutPanel();
            this.lvTimelineTest = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnStressTest = new System.Windows.Forms.Button();
            this.btnTimelineTest = new System.Windows.Forms.Button();
            this.tableLayoutPanel_CollectTest_2 = new System.Windows.Forms.TableLayoutPanel();
            this.lvRetweet = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRetweetTest = new System.Windows.Forms.Button();
            this.tabQueue = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel_Queue = new System.Windows.Forms.TableLayoutPanel();
            this.lvQueue = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripLvQueue = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQueueAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbQueueId = new System.Windows.Forms.TextBox();
            this.tbQueueType = new System.Windows.Forms.TextBox();
            this.tabStatus = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel_Status = new System.Windows.Forms.TableLayoutPanel();
            this.lbStatus = new System.Windows.Forms.Label();
            this.tabCollect = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel_Collect = new System.Windows.Forms.TableLayoutPanel();
            this.lvCollectLog = new System.Windows.Forms.ListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCollectStart = new System.Windows.Forms.Button();
            this.btnCollectTest = new System.Windows.Forms.Button();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.tbDbPassword = new System.Windows.Forms.TextBox();
            this.tbTimelineTestUserScreenName = new System.Windows.Forms.TextBox();
            this.tbRetweetTestTweetId = new System.Windows.Forms.TextBox();
            this.checkCollectLogAutoScroll = new System.Windows.Forms.CheckBox();
            this.checkCollectLog = new System.Windows.Forms.CheckBox();
            this.btnCollectLogClear = new System.Windows.Forms.Button();
            this.groupBox_DBConnection.SuspendLayout();
            this.tableLayoutPanel_DBConnection_1.SuspendLayout();
            this.groupBox_APIToken.SuspendLayout();
            this.tableLayoutPanel_APIToken.SuspendLayout();
            this.contextMenuStripLvApiToken.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabDbConfig.SuspendLayout();
            this.tableLayoutPanel_DBConnection.SuspendLayout();
            this.tabApiToken.SuspendLayout();
            this.tabCollectTest.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel_CollectTest.SuspendLayout();
            this.tableLayoutPanel_CollectTest_1.SuspendLayout();
            this.tableLayoutPanel_CollectTest_2.SuspendLayout();
            this.tabQueue.SuspendLayout();
            this.tableLayoutPanel_Queue.SuspendLayout();
            this.contextMenuStripLvQueue.SuspendLayout();
            this.tabStatus.SuspendLayout();
            this.tableLayoutPanel_Status.SuspendLayout();
            this.tabCollect.SuspendLayout();
            this.tableLayoutPanel_Collect.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_DBConnection
            // 
            this.groupBox_DBConnection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_DBConnection.Controls.Add(this.tableLayoutPanel_DBConnection_1);
            this.groupBox_DBConnection.Location = new System.Drawing.Point(525, 303);
            this.groupBox_DBConnection.Name = "groupBox_DBConnection";
            this.groupBox_DBConnection.Size = new System.Drawing.Size(200, 120);
            this.groupBox_DBConnection.TabIndex = 0;
            this.groupBox_DBConnection.TabStop = false;
            this.groupBox_DBConnection.Text = "Database Connection Configure";
            // 
            // tableLayoutPanel_DBConnection_1
            // 
            this.tableLayoutPanel_DBConnection_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel_DBConnection_1.ColumnCount = 2;
            this.tableLayoutPanel_DBConnection_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel_DBConnection_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel_DBConnection_1.Controls.Add(this.label_User, 0, 0);
            this.tableLayoutPanel_DBConnection_1.Controls.Add(this.textBox_User, 1, 0);
            this.tableLayoutPanel_DBConnection_1.Controls.Add(this.label_Password, 0, 1);
            this.tableLayoutPanel_DBConnection_1.Controls.Add(this.btnDbConnectionTest, 0, 2);
            this.tableLayoutPanel_DBConnection_1.Controls.Add(this.tbDbPassword, 1, 1);
            this.tableLayoutPanel_DBConnection_1.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel_DBConnection_1.Name = "tableLayoutPanel_DBConnection_1";
            this.tableLayoutPanel_DBConnection_1.RowCount = 3;
            this.tableLayoutPanel_DBConnection_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_DBConnection_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_DBConnection_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_DBConnection_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_DBConnection_1.Size = new System.Drawing.Size(194, 98);
            this.tableLayoutPanel_DBConnection_1.TabIndex = 5;
            // 
            // label_User
            // 
            this.label_User.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_User.AutoSize = true;
            this.label_User.Location = new System.Drawing.Point(23, 8);
            this.label_User.Name = "label_User";
            this.label_User.Size = new System.Drawing.Size(30, 15);
            this.label_User.TabIndex = 3;
            this.label_User.Text = "User";
            // 
            // textBox_User
            // 
            this.textBox_User.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_User.Enabled = false;
            this.textBox_User.Location = new System.Drawing.Point(80, 4);
            this.textBox_User.Name = "textBox_User";
            this.textBox_User.Size = new System.Drawing.Size(111, 23);
            this.textBox_User.TabIndex = 4;
            this.textBox_User.Text = "sa";
            // 
            // label_Password
            // 
            this.label_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(10, 40);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(57, 15);
            this.label_Password.TabIndex = 0;
            this.label_Password.Text = "Password";
            // 
            // btnDbConnectionTest
            // 
            this.btnDbConnectionTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel_DBConnection_1.SetColumnSpan(this.btnDbConnectionTest, 2);
            this.btnDbConnectionTest.Location = new System.Drawing.Point(59, 70);
            this.btnDbConnectionTest.Name = "btnDbConnectionTest";
            this.btnDbConnectionTest.Size = new System.Drawing.Size(75, 22);
            this.btnDbConnectionTest.TabIndex = 2;
            this.btnDbConnectionTest.Text = "Test";
            this.btnDbConnectionTest.UseVisualStyleBackColor = true;
            this.btnDbConnectionTest.Click += new System.EventHandler(this.btnDbConnectionTest_Click);
            // 
            // groupBox_APIToken
            // 
            this.groupBox_APIToken.Controls.Add(this.tableLayoutPanel_APIToken);
            this.groupBox_APIToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_APIToken.Location = new System.Drawing.Point(3, 3);
            this.groupBox_APIToken.Name = "groupBox_APIToken";
            this.groupBox_APIToken.Size = new System.Drawing.Size(1250, 729);
            this.groupBox_APIToken.TabIndex = 1;
            this.groupBox_APIToken.TabStop = false;
            this.groupBox_APIToken.Text = "Twitter API Token";
            // 
            // tableLayoutPanel_APIToken
            // 
            this.tableLayoutPanel_APIToken.ColumnCount = 5;
            this.tableLayoutPanel_APIToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_APIToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_APIToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_APIToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_APIToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_APIToken.Controls.Add(this.lvApiToken, 0, 0);
            this.tableLayoutPanel_APIToken.Controls.Add(this.tbApiTokenAccessTokenSecret, 4, 1);
            this.tableLayoutPanel_APIToken.Controls.Add(this.btnApiTokenAdd, 0, 2);
            this.tableLayoutPanel_APIToken.Controls.Add(this.tbApiTokenAccessToken, 3, 1);
            this.tableLayoutPanel_APIToken.Controls.Add(this.tbApiTokenName, 0, 1);
            this.tableLayoutPanel_APIToken.Controls.Add(this.tbApiTokenConsumerKey, 1, 1);
            this.tableLayoutPanel_APIToken.Controls.Add(this.tbApiTokenConsumerSecret, 2, 1);
            this.tableLayoutPanel_APIToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_APIToken.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel_APIToken.Name = "tableLayoutPanel_APIToken";
            this.tableLayoutPanel_APIToken.RowCount = 3;
            this.tableLayoutPanel_APIToken.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel_APIToken.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel_APIToken.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel_APIToken.Size = new System.Drawing.Size(1244, 707);
            this.tableLayoutPanel_APIToken.TabIndex = 7;
            // 
            // lvApiToken
            // 
            this.lvApiToken.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.tableLayoutPanel_APIToken.SetColumnSpan(this.lvApiToken, 5);
            this.lvApiToken.ContextMenuStrip = this.contextMenuStripLvApiToken;
            this.lvApiToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvApiToken.FullRowSelect = true;
            this.lvApiToken.GridLines = true;
            this.lvApiToken.Location = new System.Drawing.Point(3, 3);
            this.lvApiToken.Name = "lvApiToken";
            this.lvApiToken.Size = new System.Drawing.Size(1238, 594);
            this.lvApiToken.TabIndex = 0;
            this.lvApiToken.UseCompatibleStateImageBehavior = false;
            this.lvApiToken.View = System.Windows.Forms.View.Details;
            this.lvApiToken.SelectedIndexChanged += new System.EventHandler(this.lvApiToken_SelectedIndexChanged);
            this.lvApiToken.ClientSizeChanged += new System.EventHandler(this.lvApiToken_ClientSizeChanged);
            this.lvApiToken.Click += new System.EventHandler(this.lvApiToken_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "name";
            this.columnHeader1.Width = 147;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ConsumerKey";
            this.columnHeader2.Width = 152;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ConsumerSecret";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "AccessToken";
            this.columnHeader4.Width = 153;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "AccessTokenSecret";
            this.columnHeader5.Width = 196;
            // 
            // contextMenuStripLvApiToken
            // 
            this.contextMenuStripLvApiToken.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.삭제ToolStripMenuItem,
            this.삭제ToolStripMenuItem1});
            this.contextMenuStripLvApiToken.Name = "contextMenuStripLvApiToken";
            this.contextMenuStripLvApiToken.Size = new System.Drawing.Size(137, 48);
            this.contextMenuStripLvApiToken.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripLvApiToken_Opening);
            // 
            // 삭제ToolStripMenuItem
            // 
            this.삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
            this.삭제ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.삭제ToolStripMenuItem.Text = "새로고침(&E)";
            this.삭제ToolStripMenuItem.Click += new System.EventHandler(this.삭제ToolStripMenuItem_Click);
            // 
            // 삭제ToolStripMenuItem1
            // 
            this.삭제ToolStripMenuItem1.Name = "삭제ToolStripMenuItem1";
            this.삭제ToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.삭제ToolStripMenuItem1.Text = "삭제(&D)";
            this.삭제ToolStripMenuItem1.Click += new System.EventHandler(this.삭제ToolStripMenuItem1_Click);
            // 
            // tbApiTokenAccessTokenSecret
            // 
            this.tbApiTokenAccessTokenSecret.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbApiTokenAccessTokenSecret.Location = new System.Drawing.Point(1043, 615);
            this.tbApiTokenAccessTokenSecret.Name = "tbApiTokenAccessTokenSecret";
            this.tbApiTokenAccessTokenSecret.Size = new System.Drawing.Size(150, 23);
            this.tbApiTokenAccessTokenSecret.TabIndex = 5;
            // 
            // btnApiTokenAdd
            // 
            this.btnApiTokenAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel_APIToken.SetColumnSpan(this.btnApiTokenAdd, 5);
            this.btnApiTokenAdd.Location = new System.Drawing.Point(584, 668);
            this.btnApiTokenAdd.Name = "btnApiTokenAdd";
            this.btnApiTokenAdd.Size = new System.Drawing.Size(75, 23);
            this.btnApiTokenAdd.TabIndex = 6;
            this.btnApiTokenAdd.Text = "Add";
            this.btnApiTokenAdd.UseVisualStyleBackColor = true;
            this.btnApiTokenAdd.Click += new System.EventHandler(this.btnApiTokenAdd_Click);
            // 
            // tbApiTokenAccessToken
            // 
            this.tbApiTokenAccessToken.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbApiTokenAccessToken.Location = new System.Drawing.Point(795, 615);
            this.tbApiTokenAccessToken.Name = "tbApiTokenAccessToken";
            this.tbApiTokenAccessToken.Size = new System.Drawing.Size(146, 23);
            this.tbApiTokenAccessToken.TabIndex = 4;
            // 
            // tbApiTokenName
            // 
            this.tbApiTokenName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbApiTokenName.Location = new System.Drawing.Point(51, 615);
            this.tbApiTokenName.Name = "tbApiTokenName";
            this.tbApiTokenName.Size = new System.Drawing.Size(146, 23);
            this.tbApiTokenName.TabIndex = 1;
            // 
            // tbApiTokenConsumerKey
            // 
            this.tbApiTokenConsumerKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbApiTokenConsumerKey.Location = new System.Drawing.Point(299, 615);
            this.tbApiTokenConsumerKey.Name = "tbApiTokenConsumerKey";
            this.tbApiTokenConsumerKey.Size = new System.Drawing.Size(146, 23);
            this.tbApiTokenConsumerKey.TabIndex = 2;
            // 
            // tbApiTokenConsumerSecret
            // 
            this.tbApiTokenConsumerSecret.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbApiTokenConsumerSecret.Location = new System.Drawing.Point(547, 615);
            this.tbApiTokenConsumerSecret.Name = "tbApiTokenConsumerSecret";
            this.tbApiTokenConsumerSecret.Size = new System.Drawing.Size(146, 23);
            this.tbApiTokenConsumerSecret.TabIndex = 3;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDbConfig);
            this.tabControl.Controls.Add(this.tabApiToken);
            this.tabControl.Controls.Add(this.tabCollectTest);
            this.tabControl.Controls.Add(this.tabQueue);
            this.tabControl.Controls.Add(this.tabStatus);
            this.tabControl.Controls.Add(this.tabCollect);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1264, 761);
            this.tabControl.TabIndex = 2;
            // 
            // tabDbConfig
            // 
            this.tabDbConfig.Controls.Add(this.tableLayoutPanel_DBConnection);
            this.tabDbConfig.Location = new System.Drawing.Point(4, 24);
            this.tabDbConfig.Name = "tabDbConfig";
            this.tabDbConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabDbConfig.Size = new System.Drawing.Size(1256, 733);
            this.tabDbConfig.TabIndex = 0;
            this.tabDbConfig.Text = "DB Connection";
            this.tabDbConfig.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_DBConnection
            // 
            this.tableLayoutPanel_DBConnection.ColumnCount = 1;
            this.tableLayoutPanel_DBConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_DBConnection.Controls.Add(this.groupBox_DBConnection, 0, 0);
            this.tableLayoutPanel_DBConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_DBConnection.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_DBConnection.Name = "tableLayoutPanel_DBConnection";
            this.tableLayoutPanel_DBConnection.RowCount = 1;
            this.tableLayoutPanel_DBConnection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_DBConnection.Size = new System.Drawing.Size(1250, 727);
            this.tableLayoutPanel_DBConnection.TabIndex = 1;
            // 
            // tabApiToken
            // 
            this.tabApiToken.Controls.Add(this.groupBox_APIToken);
            this.tabApiToken.Location = new System.Drawing.Point(4, 24);
            this.tabApiToken.Name = "tabApiToken";
            this.tabApiToken.Padding = new System.Windows.Forms.Padding(3);
            this.tabApiToken.Size = new System.Drawing.Size(1256, 733);
            this.tabApiToken.TabIndex = 1;
            this.tabApiToken.Text = "API Token";
            this.tabApiToken.UseVisualStyleBackColor = true;
            // 
            // tabCollectTest
            // 
            this.tabCollectTest.Controls.Add(this.groupBox3);
            this.tabCollectTest.Location = new System.Drawing.Point(4, 24);
            this.tabCollectTest.Name = "tabCollectTest";
            this.tabCollectTest.Padding = new System.Windows.Forms.Padding(3);
            this.tabCollectTest.Size = new System.Drawing.Size(1256, 733);
            this.tabCollectTest.TabIndex = 2;
            this.tabCollectTest.Text = "Collect Test";
            this.tabCollectTest.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel_CollectTest);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1250, 729);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Timeline ";
            // 
            // tableLayoutPanel_CollectTest
            // 
            this.tableLayoutPanel_CollectTest.ColumnCount = 1;
            this.tableLayoutPanel_CollectTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_CollectTest.Controls.Add(this.tableLayoutPanel_CollectTest_1, 0, 0);
            this.tableLayoutPanel_CollectTest.Controls.Add(this.tableLayoutPanel_CollectTest_2, 0, 1);
            this.tableLayoutPanel_CollectTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_CollectTest.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel_CollectTest.Name = "tableLayoutPanel_CollectTest";
            this.tableLayoutPanel_CollectTest.RowCount = 2;
            this.tableLayoutPanel_CollectTest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_CollectTest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_CollectTest.Size = new System.Drawing.Size(1244, 707);
            this.tableLayoutPanel_CollectTest.TabIndex = 9;
            // 
            // tableLayoutPanel_CollectTest_1
            // 
            this.tableLayoutPanel_CollectTest_1.ColumnCount = 3;
            this.tableLayoutPanel_CollectTest_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_CollectTest_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_CollectTest_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_CollectTest_1.Controls.Add(this.lvTimelineTest, 0, 0);
            this.tableLayoutPanel_CollectTest_1.Controls.Add(this.btnStressTest, 2, 1);
            this.tableLayoutPanel_CollectTest_1.Controls.Add(this.tbTimelineTestUserScreenName, 0, 1);
            this.tableLayoutPanel_CollectTest_1.Controls.Add(this.btnTimelineTest, 1, 1);
            this.tableLayoutPanel_CollectTest_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_CollectTest_1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_CollectTest_1.Name = "tableLayoutPanel_CollectTest_1";
            this.tableLayoutPanel_CollectTest_1.RowCount = 2;
            this.tableLayoutPanel_CollectTest_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel_CollectTest_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_CollectTest_1.Size = new System.Drawing.Size(1238, 347);
            this.tableLayoutPanel_CollectTest_1.TabIndex = 0;
            // 
            // lvTimelineTest
            // 
            this.lvTimelineTest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.tableLayoutPanel_CollectTest_1.SetColumnSpan(this.lvTimelineTest, 3);
            this.lvTimelineTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTimelineTest.FullRowSelect = true;
            this.lvTimelineTest.GridLines = true;
            this.lvTimelineTest.Location = new System.Drawing.Point(3, 3);
            this.lvTimelineTest.Name = "lvTimelineTest";
            this.lvTimelineTest.Size = new System.Drawing.Size(1232, 306);
            this.lvTimelineTest.TabIndex = 0;
            this.lvTimelineTest.UseCompatibleStateImageBehavior = false;
            this.lvTimelineTest.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ID";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Text";
            this.columnHeader6.Width = 276;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Retweet Count";
            this.columnHeader7.Width = 63;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Favorite Count";
            this.columnHeader8.Width = 72;
            // 
            // btnStressTest
            // 
            this.btnStressTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStressTest.Location = new System.Drawing.Point(989, 318);
            this.btnStressTest.Name = "btnStressTest";
            this.btnStressTest.Size = new System.Drawing.Size(187, 23);
            this.btnStressTest.TabIndex = 5;
            this.btnStressTest.Text = "Stress Test (DO NOT CLICK ME)";
            this.btnStressTest.UseVisualStyleBackColor = true;
            this.btnStressTest.Click += new System.EventHandler(this.btnStressTest_Click);
            // 
            // btnTimelineTest
            // 
            this.btnTimelineTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimelineTest.Location = new System.Drawing.Point(736, 318);
            this.btnTimelineTest.Name = "btnTimelineTest";
            this.btnTimelineTest.Size = new System.Drawing.Size(75, 23);
            this.btnTimelineTest.TabIndex = 2;
            this.btnTimelineTest.Text = "Refresh";
            this.btnTimelineTest.UseVisualStyleBackColor = true;
            this.btnTimelineTest.Click += new System.EventHandler(this.btnTimelineTest_Click);
            // 
            // tableLayoutPanel_CollectTest_2
            // 
            this.tableLayoutPanel_CollectTest_2.ColumnCount = 2;
            this.tableLayoutPanel_CollectTest_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_CollectTest_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_CollectTest_2.Controls.Add(this.lvRetweet, 0, 0);
            this.tableLayoutPanel_CollectTest_2.Controls.Add(this.btnRetweetTest, 1, 1);
            this.tableLayoutPanel_CollectTest_2.Controls.Add(this.tbRetweetTestTweetId, 0, 1);
            this.tableLayoutPanel_CollectTest_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_CollectTest_2.Location = new System.Drawing.Point(3, 356);
            this.tableLayoutPanel_CollectTest_2.Name = "tableLayoutPanel_CollectTest_2";
            this.tableLayoutPanel_CollectTest_2.RowCount = 2;
            this.tableLayoutPanel_CollectTest_2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel_CollectTest_2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_CollectTest_2.Size = new System.Drawing.Size(1238, 348);
            this.tableLayoutPanel_CollectTest_2.TabIndex = 1;
            // 
            // lvRetweet
            // 
            this.lvRetweet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.tableLayoutPanel_CollectTest_2.SetColumnSpan(this.lvRetweet, 2);
            this.lvRetweet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRetweet.FullRowSelect = true;
            this.lvRetweet.GridLines = true;
            this.lvRetweet.Location = new System.Drawing.Point(3, 3);
            this.lvRetweet.Name = "lvRetweet";
            this.lvRetweet.Size = new System.Drawing.Size(1232, 307);
            this.lvRetweet.TabIndex = 6;
            this.lvRetweet.UseCompatibleStateImageBehavior = false;
            this.lvRetweet.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "ID";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Text";
            this.columnHeader13.Width = 276;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Retweet Count";
            this.columnHeader14.Width = 63;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Favorite Count";
            this.columnHeader15.Width = 72;
            // 
            // btnRetweetTest
            // 
            this.btnRetweetTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRetweetTest.Location = new System.Drawing.Point(857, 319);
            this.btnRetweetTest.Name = "btnRetweetTest";
            this.btnRetweetTest.Size = new System.Drawing.Size(143, 23);
            this.btnRetweetTest.TabIndex = 7;
            this.btnRetweetTest.Text = "Get Retweet (Forcely)";
            this.btnRetweetTest.UseVisualStyleBackColor = true;
            this.btnRetweetTest.Click += new System.EventHandler(this.btnRetweetTest_Click);
            // 
            // tabQueue
            // 
            this.tabQueue.Controls.Add(this.tableLayoutPanel_Queue);
            this.tabQueue.Location = new System.Drawing.Point(4, 24);
            this.tabQueue.Name = "tabQueue";
            this.tabQueue.Size = new System.Drawing.Size(1256, 733);
            this.tabQueue.TabIndex = 3;
            this.tabQueue.Text = "Queue";
            this.tabQueue.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_Queue
            // 
            this.tableLayoutPanel_Queue.ColumnCount = 4;
            this.tableLayoutPanel_Queue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel_Queue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Queue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Queue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Queue.Controls.Add(this.lvQueue, 0, 0);
            this.tableLayoutPanel_Queue.Controls.Add(this.btnQueueAdd, 3, 1);
            this.tableLayoutPanel_Queue.Controls.Add(this.label1, 2, 1);
            this.tableLayoutPanel_Queue.Controls.Add(this.tbQueueId, 0, 1);
            this.tableLayoutPanel_Queue.Controls.Add(this.tbQueueType, 1, 1);
            this.tableLayoutPanel_Queue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Queue.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Queue.Name = "tableLayoutPanel_Queue";
            this.tableLayoutPanel_Queue.RowCount = 2;
            this.tableLayoutPanel_Queue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel_Queue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_Queue.Size = new System.Drawing.Size(1256, 735);
            this.tableLayoutPanel_Queue.TabIndex = 0;
            // 
            // lvQueue
            // 
            this.lvQueue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11});
            this.tableLayoutPanel_Queue.SetColumnSpan(this.lvQueue, 4);
            this.lvQueue.ContextMenuStrip = this.contextMenuStripLvQueue;
            this.lvQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvQueue.FullRowSelect = true;
            this.lvQueue.GridLines = true;
            this.lvQueue.Location = new System.Drawing.Point(3, 3);
            this.lvQueue.Name = "lvQueue";
            this.lvQueue.Size = new System.Drawing.Size(1250, 655);
            this.lvQueue.TabIndex = 0;
            this.lvQueue.UseCompatibleStateImageBehavior = false;
            this.lvQueue.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "ID";
            this.columnHeader10.Width = 510;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Type";
            this.columnHeader11.Width = 241;
            // 
            // contextMenuStripLvQueue
            // 
            this.contextMenuStripLvQueue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStripLvQueue.Name = "contextMenuStripLvApiToken";
            this.contextMenuStripLvQueue.Size = new System.Drawing.Size(137, 48);
            this.contextMenuStripLvQueue.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripLvQueue_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItem1.Text = "새로고침(&E)";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItem2.Text = "삭제(&D)";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // btnQueueAdd
            // 
            this.btnQueueAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQueueAdd.Location = new System.Drawing.Point(1092, 686);
            this.btnQueueAdd.Name = "btnQueueAdd";
            this.btnQueueAdd.Size = new System.Drawing.Size(75, 23);
            this.btnQueueAdd.TabIndex = 2;
            this.btnQueueAdd.Text = "Add";
            this.btnQueueAdd.UseVisualStyleBackColor = true;
            this.btnQueueAdd.Click += new System.EventHandler(this.btnQueueAdd_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(818, 683);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "0 - User\r\n1 - Tweet";
            // 
            // tbQueueId
            // 
            this.tbQueueId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbQueueId.Location = new System.Drawing.Point(3, 686);
            this.tbQueueId.Name = "tbQueueId";
            this.tbQueueId.Size = new System.Drawing.Size(370, 23);
            this.tbQueueId.TabIndex = 1;
            // 
            // tbQueueType
            // 
            this.tbQueueType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbQueueType.Location = new System.Drawing.Point(444, 686);
            this.tbQueueType.Name = "tbQueueType";
            this.tbQueueType.Size = new System.Drawing.Size(178, 23);
            this.tbQueueType.TabIndex = 3;
            // 
            // tabStatus
            // 
            this.tabStatus.Controls.Add(this.tableLayoutPanel_Status);
            this.tabStatus.Location = new System.Drawing.Point(4, 24);
            this.tabStatus.Name = "tabStatus";
            this.tabStatus.Size = new System.Drawing.Size(1256, 733);
            this.tabStatus.TabIndex = 4;
            this.tabStatus.Text = "Status";
            this.tabStatus.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_Status
            // 
            this.tableLayoutPanel_Status.ColumnCount = 1;
            this.tableLayoutPanel_Status.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Status.Controls.Add(this.lbStatus, 0, 0);
            this.tableLayoutPanel_Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Status.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Status.Name = "tableLayoutPanel_Status";
            this.tableLayoutPanel_Status.RowCount = 1;
            this.tableLayoutPanel_Status.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Status.Size = new System.Drawing.Size(1256, 735);
            this.tableLayoutPanel_Status.TabIndex = 1;
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(622, 360);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(12, 15);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "-";
            // 
            // tabCollect
            // 
            this.tabCollect.Controls.Add(this.tableLayoutPanel_Collect);
            this.tabCollect.Location = new System.Drawing.Point(4, 24);
            this.tabCollect.Name = "tabCollect";
            this.tabCollect.Padding = new System.Windows.Forms.Padding(3);
            this.tabCollect.Size = new System.Drawing.Size(1256, 733);
            this.tabCollect.TabIndex = 5;
            this.tabCollect.Text = "Collect";
            this.tabCollect.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_Collect
            // 
            this.tableLayoutPanel_Collect.ColumnCount = 3;
            this.tableLayoutPanel_Collect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Collect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Collect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Collect.Controls.Add(this.lvCollectLog, 0, 0);
            this.tableLayoutPanel_Collect.Controls.Add(this.btnCollectStart, 2, 1);
            this.tableLayoutPanel_Collect.Controls.Add(this.checkCollectLogAutoScroll, 1, 1);
            this.tableLayoutPanel_Collect.Controls.Add(this.btnCollectTest, 0, 1);
            this.tableLayoutPanel_Collect.Controls.Add(this.checkCollectLog, 1, 2);
            this.tableLayoutPanel_Collect.Controls.Add(this.btnCollectLogClear, 0, 2);
            this.tableLayoutPanel_Collect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Collect.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_Collect.Name = "tableLayoutPanel_Collect";
            this.tableLayoutPanel_Collect.RowCount = 3;
            this.tableLayoutPanel_Collect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel_Collect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_Collect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel_Collect.Size = new System.Drawing.Size(1250, 727);
            this.tableLayoutPanel_Collect.TabIndex = 4;
            // 
            // lvCollectLog
            // 
            this.lvCollectLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader17});
            this.tableLayoutPanel_Collect.SetColumnSpan(this.lvCollectLog, 3);
            this.lvCollectLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCollectLog.FullRowSelect = true;
            this.lvCollectLog.GridLines = true;
            this.lvCollectLog.Location = new System.Drawing.Point(3, 3);
            this.lvCollectLog.Name = "lvCollectLog";
            this.lvCollectLog.Size = new System.Drawing.Size(1244, 595);
            this.lvCollectLog.TabIndex = 1;
            this.lvCollectLog.UseCompatibleStateImageBehavior = false;
            this.lvCollectLog.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Time";
            this.columnHeader16.Width = 148;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Log";
            this.columnHeader17.Width = 597;
            // 
            // btnCollectStart
            // 
            this.btnCollectStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCollectStart.Location = new System.Drawing.Point(1003, 622);
            this.btnCollectStart.Name = "btnCollectStart";
            this.btnCollectStart.Size = new System.Drawing.Size(75, 23);
            this.btnCollectStart.TabIndex = 0;
            this.btnCollectStart.Text = "Start";
            this.btnCollectStart.UseVisualStyleBackColor = true;
            this.btnCollectStart.Click += new System.EventHandler(this.btnCollectStart_Click);
            // 
            // btnCollectTest
            // 
            this.btnCollectTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCollectTest.Location = new System.Drawing.Point(170, 622);
            this.btnCollectTest.Name = "btnCollectTest";
            this.btnCollectTest.Size = new System.Drawing.Size(75, 23);
            this.btnCollectTest.TabIndex = 3;
            this.btnCollectTest.Text = "enum Test";
            this.btnCollectTest.UseVisualStyleBackColor = true;
            // 
            // timerStatus
            // 
            this.timerStatus.Interval = 1000;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // tbDbPassword
            // 
            this.tbDbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDbPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::xTwitter_collector.Properties.Settings.Default, "tbDbPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbDbPassword.Location = new System.Drawing.Point(80, 36);
            this.tbDbPassword.Name = "tbDbPassword";
            this.tbDbPassword.PasswordChar = '*';
            this.tbDbPassword.Size = new System.Drawing.Size(111, 23);
            this.tbDbPassword.TabIndex = 1;
            this.tbDbPassword.Text = global::xTwitter_collector.Properties.Settings.Default.tbDbPassword;
            // 
            // tbTimelineTestUserScreenName
            // 
            this.tbTimelineTestUserScreenName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTimelineTestUserScreenName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::xTwitter_collector.Properties.Settings.Default, "tbTimelineTestUserScreenName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbTimelineTestUserScreenName.Location = new System.Drawing.Point(206, 318);
            this.tbTimelineTestUserScreenName.Name = "tbTimelineTestUserScreenName";
            this.tbTimelineTestUserScreenName.Size = new System.Drawing.Size(206, 23);
            this.tbTimelineTestUserScreenName.TabIndex = 4;
            this.tbTimelineTestUserScreenName.Text = global::xTwitter_collector.Properties.Settings.Default.tbTimelineTestUserScreenName;
            // 
            // tbRetweetTestTweetId
            // 
            this.tbRetweetTestTweetId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRetweetTestTweetId.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::xTwitter_collector.Properties.Settings.Default, "tbRetweetTestTweetId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbRetweetTestTweetId.Location = new System.Drawing.Point(206, 319);
            this.tbRetweetTestTweetId.Name = "tbRetweetTestTweetId";
            this.tbRetweetTestTweetId.Size = new System.Drawing.Size(206, 23);
            this.tbRetweetTestTweetId.TabIndex = 8;
            this.tbRetweetTestTweetId.Text = global::xTwitter_collector.Properties.Settings.Default.tbRetweetTestTweetId;
            // 
            // checkCollectLogAutoScroll
            // 
            this.checkCollectLogAutoScroll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkCollectLogAutoScroll.AutoSize = true;
            this.checkCollectLogAutoScroll.Checked = global::xTwitter_collector.Properties.Settings.Default.checkCollectLogAutoScroll;
            this.checkCollectLogAutoScroll.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::xTwitter_collector.Properties.Settings.Default, "checkCollectLogAutoScroll", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkCollectLogAutoScroll.Location = new System.Drawing.Point(581, 624);
            this.checkCollectLogAutoScroll.Name = "checkCollectLogAutoScroll";
            this.checkCollectLogAutoScroll.Size = new System.Drawing.Size(86, 19);
            this.checkCollectLogAutoScroll.TabIndex = 2;
            this.checkCollectLogAutoScroll.Text = "Auto Scroll";
            this.checkCollectLogAutoScroll.UseVisualStyleBackColor = true;
            // 
            // checkCollectLog
            // 
            this.checkCollectLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkCollectLog.AutoSize = true;
            this.checkCollectLog.Checked = global::xTwitter_collector.Properties.Settings.Default.checkCollectLog;
            this.checkCollectLog.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::xTwitter_collector.Properties.Settings.Default, "checkCollectLog", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkCollectLog.Location = new System.Drawing.Point(574, 687);
            this.checkCollectLog.Name = "checkCollectLog";
            this.checkCollectLog.Size = new System.Drawing.Size(99, 19);
            this.checkCollectLog.TabIndex = 4;
            this.checkCollectLog.Text = "Logging Stop";
            this.checkCollectLog.UseVisualStyleBackColor = true;
            // 
            // btnCollectLogClear
            // 
            this.btnCollectLogClear.Location = new System.Drawing.Point(3, 670);
            this.btnCollectLogClear.Name = "btnCollectLogClear";
            this.btnCollectLogClear.Size = new System.Drawing.Size(75, 23);
            this.btnCollectLogClear.TabIndex = 5;
            this.btnCollectLogClear.Text = "Log Clear";
            this.btnCollectLogClear.UseVisualStyleBackColor = true;
            this.btnCollectLogClear.Click += new System.EventHandler(this.btnCollectLogClear_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "xTwitter Collector (Not Connected)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.groupBox_DBConnection.ResumeLayout(false);
            this.tableLayoutPanel_DBConnection_1.ResumeLayout(false);
            this.tableLayoutPanel_DBConnection_1.PerformLayout();
            this.groupBox_APIToken.ResumeLayout(false);
            this.tableLayoutPanel_APIToken.ResumeLayout(false);
            this.tableLayoutPanel_APIToken.PerformLayout();
            this.contextMenuStripLvApiToken.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabDbConfig.ResumeLayout(false);
            this.tableLayoutPanel_DBConnection.ResumeLayout(false);
            this.tabApiToken.ResumeLayout(false);
            this.tabCollectTest.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel_CollectTest.ResumeLayout(false);
            this.tableLayoutPanel_CollectTest_1.ResumeLayout(false);
            this.tableLayoutPanel_CollectTest_1.PerformLayout();
            this.tableLayoutPanel_CollectTest_2.ResumeLayout(false);
            this.tableLayoutPanel_CollectTest_2.PerformLayout();
            this.tabQueue.ResumeLayout(false);
            this.tableLayoutPanel_Queue.ResumeLayout(false);
            this.tableLayoutPanel_Queue.PerformLayout();
            this.contextMenuStripLvQueue.ResumeLayout(false);
            this.tabStatus.ResumeLayout(false);
            this.tableLayoutPanel_Status.ResumeLayout(false);
            this.tableLayoutPanel_Status.PerformLayout();
            this.tabCollect.ResumeLayout(false);
            this.tableLayoutPanel_Collect.ResumeLayout(false);
            this.tableLayoutPanel_Collect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_DBConnection;
        private System.Windows.Forms.Button btnDbConnectionTest;
        private System.Windows.Forms.TextBox tbDbPassword;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.GroupBox groupBox_APIToken;
        private System.Windows.Forms.ListView lvApiToken;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnApiTokenAdd;
        private System.Windows.Forms.TextBox tbApiTokenAccessTokenSecret;
        private System.Windows.Forms.TextBox tbApiTokenAccessToken;
        private System.Windows.Forms.TextBox tbApiTokenConsumerSecret;
        private System.Windows.Forms.TextBox tbApiTokenConsumerKey;
        private System.Windows.Forms.TextBox tbApiTokenName;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDbConfig;
        private System.Windows.Forms.TabPage tabApiToken;
        private System.Windows.Forms.TabPage tabCollectTest;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage tabQueue;
        private System.Windows.Forms.TabPage tabStatus;
        private System.Windows.Forms.Button btnTimelineTest;
        private System.Windows.Forms.ListView lvTimelineTest;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TextBox textBox_User;
        private System.Windows.Forms.Label label_User;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_DBConnection_1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_DBConnection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_APIToken;
        private System.Windows.Forms.TextBox tbTimelineTestUserScreenName;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripLvApiToken;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem1;
        private System.Windows.Forms.Button btnStressTest;
        private System.Windows.Forms.ListView lvQueue;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TabPage tabCollect;
        private System.Windows.Forms.Button btnCollectStart;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.TextBox tbRetweetTestTweetId;
        private System.Windows.Forms.Button btnRetweetTest;
        private System.Windows.Forms.ListView lvRetweet;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.CheckBox checkCollectLogAutoScroll;
        private System.Windows.Forms.ListView lvCollectLog;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.TextBox tbQueueId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbQueueType;
        private System.Windows.Forms.Button btnQueueAdd;
        private System.Windows.Forms.Button btnCollectTest;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripLvQueue;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_CollectTest;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_CollectTest_1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_CollectTest_2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Queue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Status;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Collect;
        private System.Windows.Forms.CheckBox checkCollectLog;
        private System.Windows.Forms.Button btnCollectLogClear;
    }
}

