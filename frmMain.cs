using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xTwitter_collector
{
    public partial class frmMain : Form
    {
        KwixDatabase kd = new KwixDatabase();

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnDbConnectionTest_Click(object sender, EventArgs e)
        {
            try
            {
                kd.Connect(tbDbPassword.Text);
                MessageBox.Show("연결 성공");
                // 로그 남기기
                kd.db.test.Add(new test()
                {
                    id = kd.db.test.Count(),
                    name = $"from xTwitter-collector at {DateTime.UtcNow.Ticks}"
                });
                kd.db.SaveChanges();
                // 성공했으면 버튼하고 텍스트박스 비활성화
                tbDbPassword.Enabled = false;
                btnDbConnectionTest.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("연결 실패");
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 각 폼에 binding 되어있는 것들 .. 저장함... 
            Properties.Settings.Default.Save();
        }
    }
}
