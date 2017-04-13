namespace xTwitter_collector
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Relation")]
    public partial class Relation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        public long? user_id { get; set; }

        public long? mentioned_user_id { get; set; }

        public long? tweet_id { get; set; }

        public long? retweeted_tweet_id { get; set; }

        public long? followed_user_id { get; set; }

        public int? type { get; set; }

        public virtual User User { get; set; }

        public virtual Tweet Tweet { get; set; }

        public virtual Tweet Tweet1 { get; set; }

        public virtual User User1 { get; set; }

        public virtual User User2 { get; set; }
    }
}
