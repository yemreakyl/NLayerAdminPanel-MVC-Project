using DAL.Repositories.Materials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace BLL
{
    public static class Repositories
    {
        public static readonly ProductRepository productRepo=new ProductRepository();
        public static readonly CategoryRepository categoryRepo=new CategoryRepository();
        public static readonly SubcategoryRepository subcategoryRepo=new SubcategoryRepository();
    }
}
