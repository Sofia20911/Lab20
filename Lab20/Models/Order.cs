namespace Lab20.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_Creat { get; set; }

        public int? Services { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(50)]
        public string Service_status { get; set; }

        [StringLength(50)]
        public string Lead_time { get; set; }

        public virtual servicesLab servicesLab { get; set; }
    }
}
