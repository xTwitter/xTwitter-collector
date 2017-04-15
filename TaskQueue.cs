namespace xTwitter_collector
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaskQueue")]
    public partial class TaskQueue
    {
        public decimal id { get; set; }

        public int? type { get; set; }

        [Key]
        public long pk { get; set; }
    }
}
