namespace Lab20.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PatientData")]
    public partial class PatientData
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Login { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        public string ip { get; set; }

        [Column(TypeName = "date")]
        public DateTime? lastenter { get; set; }

        public int IDServise { get; set; }

        public int? Type { get; set; }

        [StringLength(50)]
        public string Date_of_Birth { get; set; }

        [StringLength(50)]
        public string Series { get; set; }

        [StringLength(50)]
        public string Number { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Policy_Number { get; set; }

        [StringLength(50)]
        public string Type_Policy { get; set; }

        [StringLength(50)]
        public string Insurance_Company { get; set; }

        public virtual servicesLab servicesLab { get; set; }
    }
}
