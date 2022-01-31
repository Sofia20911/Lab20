namespace Lab20.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Analyzer")]
    public partial class Analyzer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDanalyzer { get; set; }

        public DateTime DateTimeReceipts { get; set; }

        public DateTime DateTimeExecution { get; set; }
    }
}
