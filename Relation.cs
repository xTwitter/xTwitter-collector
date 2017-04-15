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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal id { get; set; }

        public decimal? user_id { get; set; }

        public decimal? mentioned_user_id { get; set; }

        public decimal? tweet_id { get; set; }

        public decimal? retweeted_tweet_id { get; set; }

        public decimal? followed_user_id { get; set; }

        public int? type { get; set; }
    }
}
