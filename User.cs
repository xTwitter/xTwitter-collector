namespace xTwitter_collector
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public decimal id { get; set; }

        [Column(TypeName = "text")]
        public string name { get; set; }

        [Column(TypeName = "text")]
        public string screen_name { get; set; }

        [Column(TypeName = "text")]
        public string description { get; set; }

        public long? favorite_count { get; set; }

        public long? follower_count { get; set; }

        public long? friend_count { get; set; }

        public long? tweet_count { get; set; }

        public DateTime? created_at { get; set; }
    }
}
