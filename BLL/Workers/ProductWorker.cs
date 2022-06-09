using BLL.Dtos;
using System.Linq;
using System.Data.Entity;
namespace BLL.Workers
{
    public class ProductWorker
    {
        public static IQueryable<ProductDto> GetProducts()
        {
            var ProductDto=from i in Repositories.productRepo.ReadMany()
                   select new ProductDto()
                   {
                       Active = i.Active,
                       Category = i.Subcategory.Categories.Title,
                       Id = i.Id,
                       CreateDate = i.CreateTime,
                       Deleted = i.Deleted,
                       Title = i.Title,
                       Subcategory = i.Subcategory.Title
                   };
            return ProductDto;
        }
        public static void ChangeItemActivate(int entitykey)
        {
            Repositories.productRepo.ChangeItemsActivate(entitykey);
        }

    }
}
