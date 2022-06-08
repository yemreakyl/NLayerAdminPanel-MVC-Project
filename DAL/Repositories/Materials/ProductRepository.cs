using DAL.Repositories.Bases;
using ENTİTİES.Materials;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Materials
{
    public sealed class ProductRepository : MaterialsBaseRepository<Product>
    {
        public void ChangeItemsActivate(int EntityKey)
        {
            var Product=ReadOne(EntityKey);
            Product.Active = !Product.Active;
        }
    
    }
}
