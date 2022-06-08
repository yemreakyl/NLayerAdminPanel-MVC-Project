
namespace DAL.Repositories.Bases
{
    public abstract class WholeSaleBaseRepository<T> : GenericBaseRepository<T> where T : class
    {
        protected WholeSaleBaseRepository() : base(new WholeSaleDbContext()) { }
    }
}
