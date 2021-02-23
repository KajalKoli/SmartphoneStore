using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SmartphoneShop.Models
{
    public class SmartphoneContext : DbContext
    {
        public SmartphoneContext() : base("Name = SmartphoneDB")

        {

        }
        //To stop EF from pluralizing table names
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<SmartphoneFeature> SmartphoneFeatures { get; set; }
    }

}