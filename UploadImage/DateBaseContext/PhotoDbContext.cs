using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using UploadImage.Models;

namespace UploadImage.DateBaseContext
{
    public class PhotoDbContext : DbContext
    {
        public PhotoDbContext() : base("DefaultConnection") { }

        public DbSet<AddImage> Images { get; set; }
        //public DbSet<ImageInfo> Info { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}