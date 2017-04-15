using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToTwitter;

namespace xTwitter_collector
{
    public class TwitterApi
    {
        public TwitterContext twitterContext;
        public SingleUserAuthorizer auth;

        public void InitAuth(ApiToken token)
        {
            if (twitterContext != null)
            {
                twitterContext.Dispose();
            }
            auth = new SingleUserAuthorizer()
            {
                CredentialStore = new SingleUserInMemoryCredentialStore()
                {
                    ConsumerKey = token.consumer_key,
                    ConsumerSecret = token.consumer_secret,
                    AccessToken = token.access_token,
                    AccessTokenSecret = token.access_token_secret
                }
            };
            twitterContext = new TwitterContext(auth);
            // 연결 잘 됐는지 확인하여 throw 날려야한다 추후 개발 예정
        }

        public Boolean IsAuthorized()
        {
            // 추후에 더 확인하는 조건 추가 예정
            if (twitterContext != null)
            {
                return true;
            }
            return false;
        }

        public async Task<List<Status>> ReadTimeline(User user)
        {
            //var a = await (from tweet in twitterContext.Status
            //               where tweet.Type == StatusType.User
            //                     && tweet.UserID == user.id
            //                     && tweet.Count == 100
            //               select tweet).ToListAsync();

            return await (from tweet in twitterContext.Status
                          where tweet.Type == StatusType.User
                                && tweet.UserID == user.id
                                && tweet.Count == 100
                          select tweet).ToListAsync();

            /*return await (from tweet in twitterContext.Status
                          where tweet.Type == StatusType.User
                                && tweet.ScreenName == user.screen_name
                                && tweet.Count == 100
                          select new Tweet()
                          {
                              id = tweet.StatusID,
                              text = tweet.Text,
                              source = tweet.Source,
                              favorite_count = tweet.FavoriteCount,
                              retweet_count = tweet.RetweetCount,
                              created_at = tweet.CreatedAt,
                              user_id = tweet.UserID,
                          }).ToListAsync();*/
        }

        public async Task<List<Status>> ReadRetweet(Tweet tweet)
        {
            //var a = await (from t in twitterContext.Status
            //               where t.Type == StatusType.Retweets
            //                     && t.ID == tweet.id
            //                     && t.Count == 100
            //               select t).ToListAsync();

            return await (from t in twitterContext.Status
                          where t.Type == StatusType.Retweets
                                && t.ID == tweet.id
                                && t.Count == 100
                          select t).ToListAsync();

            /*
            return await (from t in twitterContext.Status
                           where t.Type == StatusType.Retweets 
                                 && t.ID == tweet.id
                                 && t.Count == 100
                           select new Tweet()
                           {
                               id = t.StatusID,
                               text = t.Text,
                               source = t.Source,
                               favorite_count = t.FavoriteCount,
                               retweet_count = t.RetweetCount,
                               created_at = t.CreatedAt,
                               user_id = Convert.ToDecimal(t.User.UserIDResponse)
                           }).ToListAsync();
                       */
        }

    }
}
