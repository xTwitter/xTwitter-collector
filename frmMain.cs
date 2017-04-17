using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xTwitter_collector
{
    public enum QueueType
    {
        User,
        Tweet
    };

    public enum RelationType
    {
        Follow,
        Retweet,
        Favorite,
        Write
    };

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
                this.Text = "xTwitter Collector (Connected)";
                // api token listview에 gui update
                SyncApiTokenListView();
                // timer들 활성화
                timerStatus.Enabled = true;
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
            if (item == null)
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
            // form element이름 바꾸어야함
            user.id = Convert.ToDecimal(tbTimelineTestUserScreenName.Text);

            foreach (LinqToTwitter.Status status in await api.ReadTimeline(user))
            {
                lvTimelineTest.Items.Add(new ListViewItem(new string[]
                {
                    status.StatusID.ToString(),
                    status.Text,
                    status.RetweetCount.ToString(),
                    status.FavoriteCount.ToString()
                }));
            }

            /*
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
            */
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
                while (true)
                {
                    i++;
                    List<LinqToTwitter.Status> tweets = await api.ReadTimeline(new User()
                    {
                        screen_name = tbTimelineTestUserScreenName.Text
                    });

                    lvTimelineTest.Items.Add($"{i}번째 tweets.count : {tweets.Count}");
                    lvTimelineTest.Items[lvTimelineTest.Items.Count - 1].EnsureVisible();
                }
            }
            catch (LinqToTwitter.TwitterQueryException ex)
            {
                lvTimelineTest.Items.Add("twitter query 에러");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void timerQueue_Tick(object sender, EventArgs e)
        {
            SyncQueueListView();
        }

        public void SyncQueueListView()
        {
            lvQueue.Items.Clear();
            foreach (TaskQueue q in kd.db.TaskQueue)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    q.id.ToString(),
                    Enum.GetName(typeof(QueueType), q.type)
                });
                lvQueue.Items.Add(item);
            }
        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            lbStatus.Text = $"User : {kd.db.User.Count()}개 Tweet : {kd.db.Tweet.Count()}개 Relation : {kd.db.Relation.Count()}개 TaskQueue : {kd.db.TaskQueue.Count()}개";
        }

        private async void btnCollectStart_Click(object sender, EventArgs e)
        {
            TwitterApi api = new TwitterApi();
            List<ApiToken> tokens;
            ApiToken token = null;
            Boolean loop = true;
            btnCollectStart.Enabled = false;
            CollectLog("");
            CollectLog("");
            CollectLog("");
            CollectLog("");
            CollectLog(""); // log 빈칸남길라고 ㅋ 기찮다
            CollectLog("작업 시작");

            // 작업 시작
            while (loop)
            {
                // api token 목록 갱신.
                tokens = kd.db.ApiToken.ToList();
                // token이 하나두 없으면 나간다
                if (tokens.Count == 0)
                {
                    CollectLog("api token 부족");
                    break;
                }
                // token 넣기
                if (token == null)
                {
                    token = tokens.First();
                }
                // token 적용
                api.InitAuth(token);
                CollectLog($"{token.name}의 token 적용");

                try
                {
                    // Queue가 비어있다면 할일없음. 
                    List<TaskQueue> queue = kd.db.TaskQueue.ToList();
                    if (queue.Count == 0)
                    {
                        CollectLog("queue empty");
                        loop = false; // break
                    }

                    // Queue에 있는 거 꺼내온다
                    TaskQueue q = queue.First();
                    CollectLog($"queue type : {Enum.GetName(typeof(QueueType), q.type)} queue id : {q.id}");

                    // 종류에 따라 다른 작업한다
                    // TODO : 소스가 많이 겹치는데 함수화하고 모듈화하는게 필요하다
                    if (q.type == (Int32)QueueType.User)
                    {
                        // user라면 해당유저의 timeline을 가져와서 종류에따라 관계를 맺는다
                        List<LinqToTwitter.Status> tweets = await api.ReadTimeline(new User()
                        {
                            id = q.id
                        });
                        CollectLog($"fetched {tweets.Count} of tweets");

                        foreach (LinqToTwitter.Status tweet in tweets)
                        {
                            User user = new User()
                            {
                                created_at = tweet.User.CreatedAt,
                                description = tweet.User.Description,
                                favorite_count = tweet.User.FavoritesCount,
                                follower_count = tweet.User.FollowersCount,
                                friend_count = tweet.User.FriendsCount,
                                id = Convert.ToDecimal(tweet.User.UserIDResponse),
                                name = tweet.User.Name,
                                screen_name = tweet.User.ScreenNameResponse,
                                tweet_count = tweet.User.StatusesCount
                            };

                            // TODO : 변수명이 좀 꼬였다.. 나중에 refactoring 필수
                            Tweet tweet2 = new Tweet()
                            {
                                id = tweet.StatusID,
                                created_at = tweet.CreatedAt,
                                favorite_count = tweet.FavoriteCount,
                                retweet_count = tweet.RetweetCount,
                                source = tweet.Source,
                                text = tweet.Text,
                                user_id = Convert.ToDecimal(tweet.User.UserIDResponse)
                            };

                            Relation writeRelation = new Relation()
                            {
                                user_id = Convert.ToDecimal(tweet.User.UserIDResponse),
                                tweet_id = tweet.StatusID,
                                type = Convert.ToInt32(RelationType.Write)
                            };

                            // 사용자 추가
                            if (!kd.db.User.Any(u => u.id == user.id))
                            {
                                kd.db.User.Add(user);
                                CollectLog($"new user added. name : {tweet.User.Name}({tweet.User.ScreenName})");
                            }
                            // 트윗 추가
                            if (!kd.db.Tweet.Any(t => t.id == tweet2.id))
                            {
                                kd.db.Tweet.Add(tweet2);
                                CollectLog($"new tweet added. text : {tweet.Text}");
                            }
                            // 일반 트윗이라면
                            if (tweet.RetweetedStatus.StatusID == 0)
                            {
                                // 사용자랑 트윗의 관계 생성
                                if (!kd.db.Relation.Any(r => r.user_id == user.id
                                    && r.tweet_id == tweet2.id
                                    && r.type == (Int32)RelationType.Write))
                                {
                                    kd.db.Relation.Add(writeRelation);
                                    CollectLog($"new Write Relation added. {tweet.User.Name}({tweet.User.ScreenName}) -> {tweet.Text}");
                                }
                            }
                            // 리트윗이라면
                            else
                            {
                                User retweetedUser = new User()
                                {
                                    created_at = tweet.RetweetedStatus.User.CreatedAt,
                                    description = tweet.RetweetedStatus.User.Description,
                                    favorite_count = tweet.RetweetedStatus.User.FavoritesCount,
                                    follower_count = tweet.RetweetedStatus.User.FollowersCount,
                                    friend_count = tweet.RetweetedStatus.User.FriendsCount,
                                    id = Convert.ToDecimal(tweet.RetweetedStatus.User.UserIDResponse),
                                    name = tweet.RetweetedStatus.User.Name,
                                    screen_name = tweet.RetweetedStatus.User.ScreenNameResponse,
                                    tweet_count = tweet.RetweetedStatus.User.StatusesCount
                                };

                                Tweet retweetedTweet = new Tweet()
                                {
                                    id = tweet.RetweetedStatus.StatusID,
                                    created_at = tweet.RetweetedStatus.CreatedAt,
                                    favorite_count = tweet.RetweetedStatus.FavoriteCount,
                                    retweet_count = tweet.RetweetedStatus.RetweetCount,
                                    source = tweet.RetweetedStatus.Source,
                                    text = tweet.RetweetedStatus.Text,
                                    user_id = Convert.ToDecimal(tweet.RetweetedStatus.User.UserIDResponse)
                                };

                                Relation retweetedWriteRelation = new Relation()
                                {
                                    user_id = Convert.ToDecimal(tweet.RetweetedStatus.User.UserIDResponse),
                                    tweet_id = tweet.RetweetedStatus.StatusID,
                                    type = Convert.ToInt32(RelationType.Write)
                                };

                                Relation retweetRelation = new Relation()
                                {
                                    user_id = Convert.ToDecimal(tweet.User.UserIDResponse),
                                    retweeted_tweet_id = tweet.RetweetedStatus.StatusID,
                                    tweet_id = tweet.StatusID,
                                    type = Convert.ToInt32(RelationType.Retweet)
                                };

                                // 리트윗 원본 사용자 추가
                                if (!kd.db.User.Any(u => u.id == retweetedUser.id))
                                {
                                    kd.db.User.Add(retweetedUser);
                                    CollectLog($"new user added.name : {tweet.RetweetedStatus.User.Name}({tweet.User.ScreenName})");
                                }

                                // 리트윗 원본 자체 등록
                                if (!kd.db.Tweet.Any(t => t.id == retweetedTweet.id))
                                {
                                    kd.db.Tweet.Add(retweetedTweet);
                                    CollectLog($"new tweet added. text : {tweet.RetweetedStatus.Text}");
                                }

                                // 리트윗 원본하고 리트윗 원본 사용자하고 write관계
                                // 사용자랑 트윗의 관계 생성
                                if (!kd.db.Relation.Any(r => r.user_id == retweetedUser.id
                                    && r.tweet_id == retweetedTweet.id
                                    && r.type == (Int32)RelationType.Write))
                                {
                                    kd.db.Relation.Add(retweetedWriteRelation);
                                    CollectLog($"new Write Relation added. {tweet.User.Name} -> {tweet.Text}");
                                }

                                // 사용자랑 트윗이랑 리트윗관계 생성
                                if (!kd.db.Relation.Any(r => r.user_id == user.id
                                    && r.retweeted_tweet_id == retweetedTweet.id
                                    && r.tweet_id == tweet2.id
                                    && r.type == (Int32)RelationType.Retweet))
                                {
                                    kd.db.Relation.Add(retweetRelation);
                                    CollectLog($"new Retweet Relation added. {tweet.User.Name}({tweet.User.ScreenName}) -> {tweet.Text}");
                                }
                            }
                            // queue 생성
                            // retweet갯수가 하나라도 있으면 queue에 집어넣는다 (비효율적인거같긴하다)
                            // 이미 retweet된거면 안된다
                            if (tweet.RetweetCount > 0 && tweet.RetweetedStatus.StatusID == 0)
                            {
                                // queue 중복 검사
                                if (!kd.db.TaskQueue.Any(a => a.id == tweet.StatusID && a.type == (Int32)QueueType.Tweet))
                                {
                                    kd.db.TaskQueue.Add(new TaskQueue()
                                    {
                                        id = tweet.StatusID,
                                        type = (Int32)QueueType.Tweet
                                    });
                                }
                            }
                            // db저장
                            kd.db.SaveChanges();
                        }
                    }
                    else if (q.type == (Int32)QueueType.Tweet)
                    {
                        // 해당 트윗의 리트윗된것들을 모조리 가져온다 그리고 user랑 tweet이랑, retweet관계 추가!
                        List<LinqToTwitter.Status> tweets = await api.ReadRetweet(new Tweet()
                        {
                            id = q.id
                        });
                        CollectLog($"fetched {tweets.Count} of retweets");

                        foreach (var tweet in tweets)
                        {
                            User user = new User()
                            {
                                created_at = tweet.User.CreatedAt,
                                description = tweet.User.Description,
                                favorite_count = tweet.User.FavoritesCount,
                                follower_count = tweet.User.FollowersCount,
                                friend_count = tweet.User.FriendsCount,
                                id = Convert.ToDecimal(tweet.User.UserIDResponse),
                                name = tweet.User.Name,
                                screen_name = tweet.User.ScreenNameResponse,
                                tweet_count = tweet.User.StatusesCount
                            };

                            // TODO : 변수명이 좀 꼬였다.. 나중에 refactoring 필수
                            Tweet tweet2 = new Tweet()
                            {
                                id = tweet.StatusID,
                                created_at = tweet.CreatedAt,
                                favorite_count = tweet.FavoriteCount,
                                retweet_count = tweet.RetweetCount,
                                source = tweet.Source,
                                text = tweet.Text,
                                user_id = Convert.ToDecimal(tweet.User.UserIDResponse)
                            };

                            User retweetedUser = new User()
                            {
                                created_at = tweet.RetweetedStatus.User.CreatedAt,
                                description = tweet.RetweetedStatus.User.Description,
                                favorite_count = tweet.RetweetedStatus.User.FavoritesCount,
                                follower_count = tweet.RetweetedStatus.User.FollowersCount,
                                friend_count = tweet.RetweetedStatus.User.FriendsCount,
                                id = Convert.ToDecimal(tweet.RetweetedStatus.User.UserIDResponse),
                                name = tweet.RetweetedStatus.User.Name,
                                screen_name = tweet.RetweetedStatus.User.ScreenNameResponse,
                                tweet_count = tweet.RetweetedStatus.User.StatusesCount
                            };

                            Relation writeRelation = new Relation()
                            {
                                user_id = Convert.ToDecimal(tweet.User.UserIDResponse),
                                tweet_id = tweet.StatusID,
                                type = Convert.ToInt32(RelationType.Write)
                            };

                            // 사용자 추가
                            if (!kd.db.User.Any(u => u.id == user.id))
                            {
                                kd.db.User.Add(user);
                                CollectLog($"new user added. name : {tweet.User.Name}({tweet.User.ScreenName})");
                            }
                            // 트윗 추가
                            if (!kd.db.Tweet.Any(t => t.id == tweet2.id))
                            {
                                kd.db.Tweet.Add(tweet2);
                                CollectLog($"new tweet added. text : {tweet.Text}");
                            }
                            // 사용자하고 트윗 쓴 관계 추가 
                            if (!kd.db.Relation.Any(r => r.user_id == user.id
                                    && r.tweet_id == tweet2.id
                                    && r.type == (Int32)RelationType.Write))
                            {
                                kd.db.Relation.Add(writeRelation);
                                CollectLog($"new Write Relation added. {tweet.User.Name}({tweet.User.ScreenName}) -> {tweet.Text}");
                            }
                            Relation retweetRelation = new Relation()
                            {
                                user_id = Convert.ToDecimal(tweet.User.UserIDResponse),
                                retweeted_tweet_id = tweet.RetweetedStatus.StatusID,
                                tweet_id = tweet.StatusID,
                                type = Convert.ToInt32(RelationType.Retweet)
                            };
                            Tweet retweetedTweet = new Tweet()
                            {
                                id = tweet.RetweetedStatus.StatusID,
                                created_at = tweet.RetweetedStatus.CreatedAt,
                                favorite_count = tweet.RetweetedStatus.FavoriteCount,
                                retweet_count = tweet.RetweetedStatus.RetweetCount,
                                source = tweet.RetweetedStatus.Source,
                                text = tweet.RetweetedStatus.Text,
                                user_id = Convert.ToDecimal(tweet.RetweetedStatus.User.UserIDResponse)
                            };
                            // 사용자랑 트윗이랑 리트윗관계 생성
                            if (!kd.db.Relation.Any(r => r.user_id == user.id
                                && r.retweeted_tweet_id == retweetedTweet.id
                                && r.tweet_id == tweet2.id
                                && r.type == (Int32)RelationType.Retweet))
                            {
                                kd.db.Relation.Add(retweetRelation);
                                CollectLog($"new Retweet Relation added. {tweet.User.Name}({tweet.User.ScreenName}) -> {tweet.Text}");
                            }
                            // queue확장
                            // follower수와  수가 합쳐서 100이상이면 넣는다
                            if (tweet.User.FollowersCount >= 100)
                            {
                                decimal id = Convert.ToDecimal(tweet.User.UserIDResponse);
                                if (!kd.db.TaskQueue.Any(a => a.id == id && a.type == (Int32)QueueType.User))
                                {
                                    kd.db.TaskQueue.Add(new TaskQueue()
                                    {
                                        id = Convert.ToDecimal(tweet.User.UserIDResponse),
                                        type = (Int32)QueueType.User
                                    });
                                }
                            }
                            // db저장
                            kd.db.SaveChanges();
                        }
                    }
                    // queue consume.
                    kd.db.TaskQueue.Remove(q);
                    // db 저장
                    kd.db.SaveChanges();
                }
                catch (LinqToTwitter.TwitterQueryException ex)
                {
                    // limit 이 다찬건지 아니면 없는 트윗이나 유저를 가르켜서 문제가 생긴건지.
                    switch ((int)ex.StatusCode)
                    {
                        case 429: // Too Many Requests
                        case 420: // Enhance Your Calm
                                  // limit 다찬거니까 auth 바꾸어준다
                            CollectLog($"{token.name} 이 뻑갔다. 그러므로 다음걸사용하도록하게따.");
                            // token이 삭제됐거나 마지막꺼일경우에는 첫번째거루.
                            if (tokens.IndexOf(token) == -1 || tokens.Last() == token)
                            {
                                token = tokens.First();
                            }
                            // 아니면 다음꺼루
                            else
                            {
                                token = tokens[tokens.IndexOf(token) + 1];
                            }
                            await Task.Delay(3);
                            break;
                        case 400: // Bad Request
                        case 401: // Unauthorized
                        case 403: // Forbidden
                        case 404: // Not Found
                        case 406: // Not Acceptable
                        case 410: // Gone
                        case 422: // Unprocessable Entity
                            // 작업 queue에 문제있던가 해서.. 그냥 다음 큐로 넘어가야한다
                            TaskQueue q = kd.db.TaskQueue.ToArray().First();
                            CollectLog($"q에 문제있는 듯하다. q.id : {q.id} q.type : {Enum.GetName(typeof(QueueType), q.type)}");
                            kd.db.TaskQueue.Remove(q);
                            kd.db.SaveChanges();
                            break;
                        case 502: // Bad Gateway
                        case 500: // Internal Server Error
                        case 504: // Gateway timeout
                        default:
                            // 트위터 자체에 문제있는 거라고 한다. 그냥 10초정도 쉬었다가 다시 진행하자
                            // 참고로 위의 코드들은 https://dev.twitter.com/overview/api/response-codes 여기서 가져왔다
                            await Task.Delay(10);
                            break;
                    }

                }
                // 가끔 소켓통신 뽀록날때..
                catch (System.Net.Http.HttpRequestException ex)
                {
                    // 로그에 남기기만하고 무시하고 다시 해보자
                    CollectLog("소켓 통신 뽀록남");
                }
                catch (Exception ex)
                {
                    CollectLog(ex.Message);
                    CollectLog(ex.StackTrace);
                    // 다음 큐로 이동
                    // 작업 queue에 문제있던가 해서.. 그냥 다음 큐로 넘어가야한다
                    TaskQueue q = kd.db.TaskQueue.ToArray().First();
                    CollectLog($"q에 문제있는 듯하다. q.id : {q.id} q.type : {Enum.GetName(typeof(QueueType), q.type)}");
                    kd.db.TaskQueue.Remove(q);
                    kd.db.SaveChanges();
                }
            }

            btnCollectStart.Enabled = true;
            CollectLog("작업 끝");
        }

        public void CollectLog(string str)
        {
            if (!checkCollectLog.Checked)
            {
                lvCollectLog.Items.Add(new ListViewItem(new string[]
                {
                    DateTime.Now.ToString(),
                    str
                }));
                if (checkCollectLogAutoScroll.Checked)
                {
                    lvCollectLog.Items[lvCollectLog.Items.Count - 1].EnsureVisible();
                }
                // 만개 넘어갔으면 하나 지우기
                if (lvCollectLog.Items.Count > 10000)
                {
                    lvCollectLog.Items.RemoveAt(0);
                }
                // 로그 blocking 되지 않도록
                Application.DoEvents();
            }
            // 파일에다가도써야지
            using (StreamWriter sw = File.AppendText("log.txt"))
            {
                sw.WriteLine($"{DateTime.Now.ToString()}\t\t{str}");
            }
        }

        private async void btnRetweetTest_Click(object sender, EventArgs e)
        {
            Tweet tweet = new Tweet()
            {
                id = new TwitterApi().FuckStatus(Convert.ToDecimal(tbRetweetTestTweetId.Text))
            };
            TwitterApi api = new TwitterApi();
            api.InitAuth(kd.db.ApiToken.ToArray()[0]);
            List<LinqToTwitter.Status> retweets = await api.ReadRetweet(tweet);
            lvRetweet.Items.Clear();
            foreach (var t in retweets)
            {
                lvRetweet.Items.Add(new ListViewItem(new string[]
                {
                    t.StatusID.ToString(),
                    $"{t.User.UserIDResponse}의 글내용 : {t.Text}",
                    t.RetweetCount.ToString(),
                    t.FavoriteCount.ToString()
                }));
            }
        }

        private void btnQueueAdd_Click(object sender, EventArgs e)
        {
            TaskQueue queue = new TaskQueue()
            {
                id = Convert.ToDecimal(tbQueueId.Text),
                type = Convert.ToInt32(tbQueueType.Text)
            };

            if (!kd.db.TaskQueue.Any(q => q.id == queue.id && q.type == queue.type))
            {
                kd.db.TaskQueue.Add(queue);
                kd.db.SaveChanges();
            }

            SyncQueueListView();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SyncQueueListView();
        }

        private void contextMenuStripLvApiToken_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void contextMenuStripLvQueue_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // 이름 그지같은거 나중에 알아서 ...^^;; 난안해
            if (lvQueue.SelectedIndices.Count > 0)
            {
                int idx = lvQueue.SelectedIndices[0];
                lvQueue.Items.RemoveAt(idx);
                // db에 반영 
                // TODO : 오류처리 필요함
                kd.db.TaskQueue.Remove(kd.db.TaskQueue.ToArray()[idx]);
                kd.db.SaveChanges();
            }
        }
    }
}
