namespace Lab20.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InsuranceCompany")]
    public partial class InsuranceCompany
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Adress { get; set; }

        [StringLength(50)]
        public string INN { get; set; }

        [StringLength(50)]
        public string PS { get; set; }

        [StringLength(50)]
        public string BIK { get; set; }
    }
}
