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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tweet()
        {
            Relation = new HashSet<Relation>();
            Relation1 = new HashSet<Relation>();
        }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Relation> Relation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Relation> Relation1 { get; set; }

        public virtual User User { get; set; }
    }
}
