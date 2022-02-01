namespace Lab20.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Accountant")]
    public partial class Accountant
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public DateTime DateTimeEntry { get; set; }

        [StringLength(50)]
        public string SetServices { get; set; }

        public decimal? Insurance_Account { get; set; }

        public virtual TypeUser TypeUser { get; set; }
    }
}