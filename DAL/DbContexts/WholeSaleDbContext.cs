using System.Data.Entity;

namespace DAL
{
    public class WholeSaleDbContext : DbContext
    {
        private static readonly string CnnStr = @"Data Source=DESKTOP-LRJJRVR\SQLEXPRESS;Initial Catalog=WholeSaleDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public WholeSaleDbContext()
            : base(CnnStr)
        {
        }
    }

}