namespace xTwitter_collector
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApiToken")]
    public partial class ApiToken
    {
        [Column(TypeName = "text")]
        public string name { get; set; }

        [Column(TypeName = "text")]
        public string consumer_key { get; set; }

        [Column(TypeName = "text")]
        public string consumer_secret { get; set; }

        [Column(TypeName = "text")]
        public string access_token { get; set; }

        [Column(TypeName = "text")]
        public string access_token_secret { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
    }
}
