namespace xTwitter_collector
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tweet")]
    public partial class Tweet
    {
        public decimal id { get; set; }

        public decimal? user_id { get; set; }

        [Column(TypeName = "text")]
        public string text { get; set; }

        [Column(TypeName = "text")]
        public string source { get; set; }

        public DateTime? created_at { get; set; }

        [Column(TypeName = "text")]
        public string media_info { get; set; }

        public long? favorite_count { get; set; }

        public long? retweet_count { get; set; }
    }
}
