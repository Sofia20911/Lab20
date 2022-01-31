namespace Lab20.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Service_rendered
    {
        public int ID { get; set; }

        public int? IDservice { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(50)]
        public string NameDoc { get; set; }

        public int IDAnalyzer { get; set; }

        public virtual servicesLab servicesLab { get; set; }
    }
}
