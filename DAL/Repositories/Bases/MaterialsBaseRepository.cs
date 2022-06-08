
namespace DAL.Repositories.Bases
{
    public abstract class MaterialsBaseRepository<T> : GenericBaseRepository<T> where T : class
    {
        protected MaterialsBaseRepository() : base(new MaterialsDbContext()) { }
    }
}
