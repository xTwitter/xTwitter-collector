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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDbConnectionTest = new System.Windows.Forms.Button();
            this.tbDbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvApiToken = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbApiTokenName = new System.Windows.Forms.TextBox();
            this.tbApiTokenConsumerKey = new System.Windows.Forms.TextBox();
            this.tbApiTokenConsumerSecret = new System.Windows.Forms.TextBox();
            this.tbApiTokenAccessToken = new System.Windows.Forms.TextBox();
            this.tbApiTokenAccessTokenSecret = new System.Windows.Forms.TextBox();
            this.btnApiTokenAdd = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDbConfig = new System.Windows.Forms.TabPage();
            this.tabApiToken = new System.Windows.Forms.TabPage();
            this.tabCollectTest = new System.Windows.Forms.TabPage();
            this.tabQueue = new System.Windows.Forms.TabPage();
            this.tabStatus = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabDbConfig.SuspendLayout();
            this.tabApiToken.SuspendLayout();
            this.tabCollectTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDbConnectionTest);
            this.groupBox1.Controls.Add(this.tbDbPassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(278, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Connection Configure";
            // 
            // btnDbConnectionTest
            // 
            this.btnDbConnectionTest.Location = new System.Drawing.Point(119, 47);
            this.btnDbConnectionTest.Name = "btnDbConnectionTest";
            this.btnDbConnectionTest.Size = new System.Drawing.Size(75, 23);
            this.btnDbConnectionTest.TabIndex = 2;
            this.btnDbConnectionTest.Text = "test";
            this.btnDbConnectionTest.UseVisualStyleBackColor = true;
            this.btnDbConnectionTest.Click += new System.EventHandler(this.btnDbConnectionTest_Click);
            // 
            // tbDbPassword
            // 
            this.tbDbPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::xTwitter_collector.Properties.Settings.Default, "tbDbPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbDbPassword.Location = new System.Drawing.Point(73, 20);
            this.tbDbPassword.Name = "tbDbPassword";
            this.tbDbPassword.PasswordChar = '*';
            this.tbDbPassword.Size = new System.Drawing.Size(121, 21);
            this.tbDbPassword.TabIndex = 1;
            this.tbDbPassword.Text = global::xTwitter_collector.Properties.Settings.Default.tbDbPassword;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "password";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnApiTokenAdd);
            this.groupBox2.Controls.Add(this.tbApiTokenAccessTokenSecret);
            this.groupBox2.Controls.Add(this.tbApiTokenAccessToken);
            this.groupBox2.Controls.Add(this.tbApiTokenConsumerSecret);
            this.groupBox2.Controls.Add(this.tbApiTokenConsumerKey);
            this.groupBox2.Controls.Add(this.tbApiTokenName);
            this.groupBox2.Controls.Add(this.lvApiToken);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(715, 357);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Twitter API Token";
            // 
            // lvApiToken
            // 
            this.lvApiToken.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvApiToken.FullRowSelect = true;
            this.lvApiToken.GridLines = true;
            this.lvApiToken.Location = new System.Drawing.Point(6, 20);
            this.lvApiToken.Name = "lvApiToken";
            this.lvApiToken.Size = new System.Drawing.Size(703, 293);
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
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ConsumerKey";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ConsumerSecret";
            this.columnHeader3.Width = 152;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "AccessToken";
            this.columnHeader4.Width = 169;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "AccessTokenSecret";
            this.columnHeader5.Width = 196;
            // 
            // tbApiTokenName
            // 
            this.tbApiTokenName.Location = new System.Drawing.Point(6, 319);
            this.tbApiTokenName.Name = "tbApiTokenName";
            this.tbApiTokenName.Size = new System.Drawing.Size(61, 21);
            this.tbApiTokenName.TabIndex = 1;
            // 
            // tbApiTokenConsumerKey
            // 
            this.tbApiTokenConsumerKey.Location = new System.Drawing.Point(73, 319);
            this.tbApiTokenConsumerKey.Name = "tbApiTokenConsumerKey";
            this.tbApiTokenConsumerKey.Size = new System.Drawing.Size(106, 21);
            this.tbApiTokenConsumerKey.TabIndex = 2;
            // 
            // tbApiTokenConsumerSecret
            // 
            this.tbApiTokenConsumerSecret.Location = new System.Drawing.Point(201, 319);
            this.tbApiTokenConsumerSecret.Name = "tbApiTokenConsumerSecret";
            this.tbApiTokenConsumerSecret.Size = new System.Drawing.Size(106, 21);
            this.tbApiTokenConsumerSecret.TabIndex = 3;
            // 
            // tbApiTokenAccessToken
            // 
            this.tbApiTokenAccessToken.Location = new System.Drawing.Point(313, 319);
            this.tbApiTokenAccessToken.Name = "tbApiTokenAccessToken";
            this.tbApiTokenAccessToken.Size = new System.Drawing.Size(106, 21);
            this.tbApiTokenAccessToken.TabIndex = 4;
            // 
            // tbApiTokenAccessTokenSecret
            // 
            this.tbApiTokenAccessTokenSecret.Location = new System.Drawing.Point(450, 319);
            this.tbApiTokenAccessTokenSecret.Name = "tbApiTokenAccessTokenSecret";
            this.tbApiTokenAccessTokenSecret.Size = new System.Drawing.Size(106, 21);
            this.tbApiTokenAccessTokenSecret.TabIndex = 5;
            // 
            // btnApiTokenAdd
            // 
            this.btnApiTokenAdd.Location = new System.Drawing.Point(561, 319);
            this.btnApiTokenAdd.Name = "btnApiTokenAdd";
            this.btnApiTokenAdd.Size = new System.Drawing.Size(75, 23);
            this.btnApiTokenAdd.TabIndex = 6;
            this.btnApiTokenAdd.Text = "add";
            this.btnApiTokenAdd.UseVisualStyleBackColor = true;
            this.btnApiTokenAdd.Click += new System.EventHandler(this.btnApiTokenAdd_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDbConfig);
            this.tabControl1.Controls.Add(this.tabApiToken);
            this.tabControl1.Controls.Add(this.tabCollectTest);
            this.tabControl1.Controls.Add(this.tabQueue);
            this.tabControl1.Controls.Add(this.tabStatus);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(735, 607);
            this.tabControl1.TabIndex = 2;
            // 
            // tabDbConfig
            // 
            this.tabDbConfig.Controls.Add(this.groupBox1);
            this.tabDbConfig.Location = new System.Drawing.Point(4, 22);
            this.tabDbConfig.Name = "tabDbConfig";
            this.tabDbConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabDbConfig.Size = new System.Drawing.Size(727, 581);
            this.tabDbConfig.TabIndex = 0;
            this.tabDbConfig.Text = "DB Connection";
            this.tabDbConfig.UseVisualStyleBackColor = true;
            // 
            // tabApiToken
            // 
            this.tabApiToken.Controls.Add(this.groupBox2);
            this.tabApiToken.Location = new System.Drawing.Point(4, 22);
            this.tabApiToken.Name = "tabApiToken";
            this.tabApiToken.Padding = new System.Windows.Forms.Padding(3);
            this.tabApiToken.Size = new System.Drawing.Size(727, 581);
            this.tabApiToken.TabIndex = 1;
            this.tabApiToken.Text = "Api Token";
            this.tabApiToken.UseVisualStyleBackColor = true;
            // 
            // tabCollectTest
            // 
            this.tabCollectTest.Controls.Add(this.groupBox3);
            this.tabCollectTest.Location = new System.Drawing.Point(4, 22);
            this.tabCollectTest.Name = "tabCollectTest";
            this.tabCollectTest.Padding = new System.Windows.Forms.Padding(3);
            this.tabCollectTest.Size = new System.Drawing.Size(727, 581);
            this.tabCollectTest.TabIndex = 2;
            this.tabCollectTest.Text = "Collect Test";
            this.tabCollectTest.UseVisualStyleBackColor = true;
            // 
            // tabQueue
            // 
            this.tabQueue.Location = new System.Drawing.Point(4, 22);
            this.tabQueue.Name = "tabQueue";
            this.tabQueue.Size = new System.Drawing.Size(634, 581);
            this.tabQueue.TabIndex = 3;
            this.tabQueue.Text = "Queue";
            this.tabQueue.UseVisualStyleBackColor = true;
            // 
            // tabStatus
            // 
            this.tabStatus.Location = new System.Drawing.Point(4, 22);
            this.tabStatus.Name = "tabStatus";
            this.tabStatus.Size = new System.Drawing.Size(634, 581);
            this.tabStatus.TabIndex = 4;
            this.tabStatus.Text = "Status";
            this.tabStatus.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 531);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "timeline ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 631);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "xTwitter Collector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabDbConfig.ResumeLayout(false);
            this.tabApiToken.ResumeLayout(false);
            this.tabCollectTest.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDbConnectionTest;
        private System.Windows.Forms.TextBox tbDbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDbConfig;
        private System.Windows.Forms.TabPage tabApiToken;
        private System.Windows.Forms.TabPage tabCollectTest;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage tabQueue;
        private System.Windows.Forms.TabPage tabStatus;
    }
}

