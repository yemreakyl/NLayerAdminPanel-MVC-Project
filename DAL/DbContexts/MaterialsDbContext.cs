using ENTÝTÝES.Materials;
using System;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public class MaterialsDbContext : DbContext
    {
        private static readonly string CnnStr = @"Data Source=DESKTOP-LRJJRVR\SQLEXPRESS;Initial Catalog=MaterialsDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public MaterialsDbContext(): base(CnnStr)
        {
        }

        public DbSet<Category> categories{ get; set; }
        public DbSet<Product>  products { get; set; }
        public DbSet<Subcategory> subcategories { get; set; }
    }


}