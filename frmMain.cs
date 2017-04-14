using System;
using System.Collections.Generic;
using System.Linq;
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
                // form caption도 바꿈
                this.Text = "xTwitter Collector(Connected)";
                // api token listview에 gui update
                SyncApiTokenListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("연결 실패");
            }
        }

        public void SyncApiTokenListView()
        {
            lvApiToken.Items.Clear();
            foreach (ApiToken token in kd.ReadApiToken())
            {
                ListViewItem item = new ListViewItem();
                item.Text = token.name;
                item.SubItems.Add(token.consumer_key);
                item.SubItems.Add(token.consumer_secret);
                item.SubItems.Add(token.access_token);
                item.SubItems.Add(token.access_token_secret);
                lvApiToken.Items.Add(item);
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 각 폼에 binding 되어있는 것들 .. 저장함... 
            Properties.Settings.Default.Save();
        }

        private void btnApiTokenAdd_Click(object sender, EventArgs e)
        {
            kd.CreateApiToken(new ApiToken()
            {
                id = kd.ReadApiToken().Count(),
                name = tbApiTokenName.Text,
                consumer_key = tbApiTokenConsumerKey.Text,
                consumer_secret = tbApiTokenConsumerSecret.Text,
                access_token = tbApiTokenAccessToken.Text,
                access_token_secret = tbApiTokenAccessTokenSecret.Text
            });

            SyncApiTokenListView();
        }

        private void lvApiToken_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvApiToken_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void lvApiToken_Click(object sender, EventArgs e)
        {
            // listview 클릭하면 해당 내용이 textbox들에 뜨게... 나중에 누가 구현좀^^
            ListViewItem item = lvApiToken.SelectedItems[0];
            if( item == null )
            {
                return;
            }
            
        }

        private async void btnTimelineTest_Click(object sender, EventArgs e)
        {
            ApiToken token;
            TwitterApi api = new TwitterApi();
            User user = new User();

            lvTimelineTest.Items.Clear();
            // TODO : request count를 토큰마다 저장해 적절히 분배하도록 한다
            token = kd.ReadApiToken()[0];
            api.InitAuth(token);
            user.screen_name = tbTimelineTestUserScreenName.Text;
            
            foreach (Tweet tweet in await api.ReadTimeline(user))
            {
                ListViewItem item = new ListViewItem(new string[] {
                    tweet.id.ToString(),
                    tweet.text,
                    tweet.retweet_count.ToString(),
                    tweet.favorite_count.ToString()
                });
                lvTimelineTest.Items.Add(item);
            }
        }

        private void 삭제ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // 이름 그지같은거 나중에 알아서 ...^^;; 난안해
            if (lvApiToken.SelectedIndices.Count > 0)
            {
                int idx = lvApiToken.SelectedIndices[0];
                lvApiToken.Items.RemoveAt(idx);
                // db에 반영 
                // TODO : 오류처리 필요함
                kd.DeleteApiToken(idx);
            }
            
        }

        private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SyncApiTokenListView();
        }

        private async void btnStressTest_Click(object sender, EventArgs e)
        {
            try
            {
                TwitterApi api = new TwitterApi();
                api.InitAuth(kd.ReadApiToken()[0]);
                lvTimelineTest.Items.Clear();
                int i = 0;
                while(true)
                {
                    i++;
                    List<Tweet> tweets = await api.ReadTimeline(new User()
                    {
                        screen_name = tbTimelineTestUserScreenName.Text
                    });

                    lvTimelineTest.Items.Add($"{i}번째 tweets.count : {tweets.Count}");
                    lvTimelineTest.Items[lvTimelineTest.Items.Count - 1].EnsureVisible();
                }
            }
            catch(LinqToTwitter.TwitterQueryException ex)
            {
                lvTimelineTest.Items.Add("twitter query 에러");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
