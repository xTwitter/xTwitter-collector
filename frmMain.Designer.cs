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
            this.groupBox_DBConnection = new System.Windows.Forms.GroupBox();
            this.btnDbConnectionTest = new System.Windows.Forms.Button();
            this.tbDbPassword = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.groupBox_APIToken = new System.Windows.Forms.GroupBox();
            this.btnApiTokenAdd = new System.Windows.Forms.Button();
            this.tbApiTokenAccessTokenSecret = new System.Windows.Forms.TextBox();
            this.tbApiTokenAccessToken = new System.Windows.Forms.TextBox();
            this.tbApiTokenConsumerSecret = new System.Windows.Forms.TextBox();
            this.tbApiTokenConsumerKey = new System.Windows.Forms.TextBox();
            this.tbApiTokenName = new System.Windows.Forms.TextBox();
            this.lvApiToken = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDbConfig = new System.Windows.Forms.TabPage();
            this.tabApiToken = new System.Windows.Forms.TabPage();
            this.tabCollectTest = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTimelineTest = new System.Windows.Forms.Button();
            this.tbTimelineTestName = new System.Windows.Forms.TextBox();
            this.lvTimelineTest = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabQueue = new System.Windows.Forms.TabPage();
            this.tabStatus = new System.Windows.Forms.TabPage();
            this.label_User = new System.Windows.Forms.Label();
            this.textBox_User = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_DBConnection = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_APIToken = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_DBConnection.SuspendLayout();
            this.groupBox_APIToken.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabDbConfig.SuspendLayout();
            this.tabApiToken.SuspendLayout();
            this.tabCollectTest.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel_DBConnection.SuspendLayout();
            this.tableLayoutPanel_APIToken.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_DBConnection
            // 
            this.groupBox_DBConnection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_DBConnection.Controls.Add(this.tableLayoutPanel);
            this.groupBox_DBConnection.Location = new System.Drawing.Point(285, 203);
            this.groupBox_DBConnection.Name = "groupBox_DBConnection";
            this.groupBox_DBConnection.Size = new System.Drawing.Size(200, 120);
            this.groupBox_DBConnection.TabIndex = 0;
            this.groupBox_DBConnection.TabStop = false;
            this.groupBox_DBConnection.Text = "Database Connection Configure";
            // 
            // btnDbConnectionTest
            // 
            this.btnDbConnectionTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel.SetColumnSpan(this.btnDbConnectionTest, 2);
            this.btnDbConnectionTest.Location = new System.Drawing.Point(59, 70);
            this.btnDbConnectionTest.Name = "btnDbConnectionTest";
            this.btnDbConnectionTest.Size = new System.Drawing.Size(75, 22);
            this.btnDbConnectionTest.TabIndex = 2;
            this.btnDbConnectionTest.Text = "Test";
            this.btnDbConnectionTest.UseVisualStyleBackColor = true;
            this.btnDbConnectionTest.Click += new System.EventHandler(this.btnDbConnectionTest_Click);
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
            // groupBox_APIToken
            // 
            this.groupBox_APIToken.Controls.Add(this.tableLayoutPanel_APIToken);
            this.groupBox_APIToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_APIToken.Location = new System.Drawing.Point(3, 3);
            this.groupBox_APIToken.Name = "groupBox_APIToken";
            this.groupBox_APIToken.Size = new System.Drawing.Size(770, 527);
            this.groupBox_APIToken.TabIndex = 1;
            this.groupBox_APIToken.TabStop = false;
            this.groupBox_APIToken.Text = "Twitter API Token";
            // 
            // btnApiTokenAdd
            // 
            this.btnApiTokenAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel_APIToken.SetColumnSpan(this.btnApiTokenAdd, 5);
            this.btnApiTokenAdd.Location = new System.Drawing.Point(344, 474);
            this.btnApiTokenAdd.Name = "btnApiTokenAdd";
            this.btnApiTokenAdd.Size = new System.Drawing.Size(75, 23);
            this.btnApiTokenAdd.TabIndex = 6;
            this.btnApiTokenAdd.Text = "Add";
            this.btnApiTokenAdd.UseVisualStyleBackColor = true;
            this.btnApiTokenAdd.Click += new System.EventHandler(this.btnApiTokenAdd_Click);
            // 
            // tbApiTokenAccessTokenSecret
            // 
            this.tbApiTokenAccessTokenSecret.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbApiTokenAccessTokenSecret.Location = new System.Drawing.Point(611, 436);
            this.tbApiTokenAccessTokenSecret.Name = "tbApiTokenAccessTokenSecret";
            this.tbApiTokenAccessTokenSecret.Size = new System.Drawing.Size(150, 23);
            this.tbApiTokenAccessTokenSecret.TabIndex = 5;
            // 
            // tbApiTokenAccessToken
            // 
            this.tbApiTokenAccessToken.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbApiTokenAccessToken.Location = new System.Drawing.Point(459, 436);
            this.tbApiTokenAccessToken.Name = "tbApiTokenAccessToken";
            this.tbApiTokenAccessToken.Size = new System.Drawing.Size(146, 23);
            this.tbApiTokenAccessToken.TabIndex = 4;
            // 
            // tbApiTokenConsumerSecret
            // 
            this.tbApiTokenConsumerSecret.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbApiTokenConsumerSecret.Location = new System.Drawing.Point(307, 436);
            this.tbApiTokenConsumerSecret.Name = "tbApiTokenConsumerSecret";
            this.tbApiTokenConsumerSecret.Size = new System.Drawing.Size(146, 23);
            this.tbApiTokenConsumerSecret.TabIndex = 3;
            // 
            // tbApiTokenConsumerKey
            // 
            this.tbApiTokenConsumerKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbApiTokenConsumerKey.Location = new System.Drawing.Point(155, 436);
            this.tbApiTokenConsumerKey.Name = "tbApiTokenConsumerKey";
            this.tbApiTokenConsumerKey.Size = new System.Drawing.Size(146, 23);
            this.tbApiTokenConsumerKey.TabIndex = 2;
            // 
            // tbApiTokenName
            // 
            this.tbApiTokenName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbApiTokenName.Location = new System.Drawing.Point(3, 436);
            this.tbApiTokenName.Name = "tbApiTokenName";
            this.tbApiTokenName.Size = new System.Drawing.Size(146, 23);
            this.tbApiTokenName.TabIndex = 1;
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
            this.lvApiToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvApiToken.FullRowSelect = true;
            this.lvApiToken.GridLines = true;
            this.lvApiToken.Location = new System.Drawing.Point(3, 3);
            this.lvApiToken.Name = "lvApiToken";
            this.lvApiToken.Size = new System.Drawing.Size(758, 423);
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDbConfig);
            this.tabControl.Controls.Add(this.tabApiToken);
            this.tabControl.Controls.Add(this.tabCollectTest);
            this.tabControl.Controls.Add(this.tabQueue);
            this.tabControl.Controls.Add(this.tabStatus);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(784, 561);
            this.tabControl.TabIndex = 2;
            // 
            // tabDbConfig
            // 
            this.tabDbConfig.Controls.Add(this.tableLayoutPanel_DBConnection);
            this.tabDbConfig.Location = new System.Drawing.Point(4, 24);
            this.tabDbConfig.Name = "tabDbConfig";
            this.tabDbConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabDbConfig.Size = new System.Drawing.Size(776, 533);
            this.tabDbConfig.TabIndex = 0;
            this.tabDbConfig.Text = "DB Connection";
            this.tabDbConfig.UseVisualStyleBackColor = true;
            // 
            // tabApiToken
            // 
            this.tabApiToken.Controls.Add(this.groupBox_APIToken);
            this.tabApiToken.Location = new System.Drawing.Point(4, 24);
            this.tabApiToken.Name = "tabApiToken";
            this.tabApiToken.Padding = new System.Windows.Forms.Padding(3);
            this.tabApiToken.Size = new System.Drawing.Size(776, 533);
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
            this.tabCollectTest.Size = new System.Drawing.Size(776, 533);
            this.tabCollectTest.TabIndex = 2;
            this.tabCollectTest.Text = "Collect Test";
            this.tabCollectTest.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTimelineTest);
            this.groupBox3.Controls.Add(this.tbTimelineTestName);
            this.groupBox3.Controls.Add(this.lvTimelineTest);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(770, 527);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Timeline ";
            // 
            // btnTimelineTest
            // 
            this.btnTimelineTest.Location = new System.Drawing.Point(341, 541);
            this.btnTimelineTest.Name = "btnTimelineTest";
            this.btnTimelineTest.Size = new System.Drawing.Size(75, 23);
            this.btnTimelineTest.TabIndex = 2;
            this.btnTimelineTest.Text = "refresh";
            this.btnTimelineTest.UseVisualStyleBackColor = true;
            this.btnTimelineTest.Click += new System.EventHandler(this.btnTimelineTest_Click);
            // 
            // tbTimelineTestName
            // 
            this.tbTimelineTestName.Location = new System.Drawing.Point(59, 541);
            this.tbTimelineTestName.Name = "tbTimelineTestName";
            this.tbTimelineTestName.Size = new System.Drawing.Size(165, 23);
            this.tbTimelineTestName.TabIndex = 1;
            // 
            // lvTimelineTest
            // 
            this.lvTimelineTest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvTimelineTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTimelineTest.FullRowSelect = true;
            this.lvTimelineTest.GridLines = true;
            this.lvTimelineTest.Location = new System.Drawing.Point(3, 19);
            this.lvTimelineTest.Name = "lvTimelineTest";
            this.lvTimelineTest.Size = new System.Drawing.Size(764, 505);
            this.lvTimelineTest.TabIndex = 0;
            this.lvTimelineTest.UseCompatibleStateImageBehavior = false;
            this.lvTimelineTest.View = System.Windows.Forms.View.Details;
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
            // tabQueue
            // 
            this.tabQueue.Location = new System.Drawing.Point(4, 24);
            this.tabQueue.Name = "tabQueue";
            this.tabQueue.Size = new System.Drawing.Size(776, 533);
            this.tabQueue.TabIndex = 3;
            this.tabQueue.Text = "Queue";
            this.tabQueue.UseVisualStyleBackColor = true;
            // 
            // tabStatus
            // 
            this.tabStatus.Location = new System.Drawing.Point(4, 24);
            this.tabStatus.Name = "tabStatus";
            this.tabStatus.Size = new System.Drawing.Size(776, 533);
            this.tabStatus.TabIndex = 4;
            this.tabStatus.Text = "Status";
            this.tabStatus.UseVisualStyleBackColor = true;
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
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel.Controls.Add(this.label_User, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.textBox_User, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.label_Password, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.btnDbConnectionTest, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.tbDbPassword, 1, 1);
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(194, 98);
            this.tableLayoutPanel.TabIndex = 5;
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
            this.tableLayoutPanel_DBConnection.Size = new System.Drawing.Size(770, 527);
            this.tableLayoutPanel_DBConnection.TabIndex = 1;
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
            this.tableLayoutPanel_APIToken.Size = new System.Drawing.Size(764, 505);
            this.tableLayoutPanel_APIToken.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "xTwitter Collector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.groupBox_DBConnection.ResumeLayout(false);
            this.groupBox_APIToken.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabDbConfig.ResumeLayout(false);
            this.tabApiToken.ResumeLayout(false);
            this.tabCollectTest.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.tableLayoutPanel_DBConnection.ResumeLayout(false);
            this.tableLayoutPanel_APIToken.ResumeLayout(false);
            this.tableLayoutPanel_APIToken.PerformLayout();
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
        private System.Windows.Forms.TextBox tbTimelineTestName;
        private System.Windows.Forms.ListView lvTimelineTest;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TextBox textBox_User;
        private System.Windows.Forms.Label label_User;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_DBConnection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_APIToken;
    }
}

