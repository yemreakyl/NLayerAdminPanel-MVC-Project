using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Bases
{
    public abstract class RetailBaseRepository<T> : GenericBaseRepository<T> where T : class
    {
        protected RetailBaseRepository() : base(new RetailsDbContext()) { }
    }
}
