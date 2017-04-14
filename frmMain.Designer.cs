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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDbConnectionTest = new System.Windows.Forms.Button();
            this.tbDbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDbConnectionTest);
            this.groupBox1.Controls.Add(this.tbDbPassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 576);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "xTwitter Collector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDbConnectionTest;
        private System.Windows.Forms.TextBox tbDbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

