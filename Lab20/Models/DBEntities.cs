using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Lab20.Models
{
    public partial class DBEntities : DbContext
    {
        public DBEntities()
            : base("name=DBEntities")
        {
        }

        public virtual DbSet<admin> admins { get; set; }
        public virtual DbSet<Analyzer> Analyzers { get; set; }
        public virtual DbSet<InsuranceCompany> InsuranceCompanies { get; set; }
        public virtual DbSet<LaboratoryAssistant> LaboratoryAssistants { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<PatientData> PatientDatas { get; set; }
        public virtual DbSet<Service_rendered> Service_rendered { get; set; }
        public virtual DbSet<servicesLab> servicesLabs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<servicesLab>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.servicesLab)
                .HasForeignKey(e => e.Services);

            modelBuilder.Entity<servicesLab>()
                .HasMany(e => e.PatientDatas)
                .WithRequired(e => e.servicesLab)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<servicesLab>()
                .HasMany(e => e.Service_rendered)
                .WithOptional(e => e.servicesLab)
                .HasForeignKey(e => e.IDservice);
        }
    }
}
