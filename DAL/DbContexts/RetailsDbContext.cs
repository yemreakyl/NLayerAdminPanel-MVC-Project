using System.Data.Entity;

namespace DAL
{
    public class RetailsDbContext : DbContext
    {
        private static readonly string CnnStr = @"Data Source=DESKTOP-LRJJRVR\SQLEXPRESS;Initial Catalog=ReatilsDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public RetailsDbContext(): base(CnnStr)
        {
        }


    }


}