using BLL.Dtos;
using System.Linq;
using System.Data.Entity;
using ENTİTİES.Materials;
using System;

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
        public static void ProductDeleteOrUndo(int Id)
        {
            Repositories.productRepo.ProductDeleteOrUndo(Id);
        }
        public static ProductDetail GetProductDetails(int id)
        {
            var u = Repositories.productRepo.ReadOne(id);
            return u != null ? new ProductDetail()
            {
                Id = u.Id,
                Title = u.Title,
                Description = u.Description,
                Price = u.Price,
                Campaign = u.Campaign,
                CampaignRate= u.CampaignRate,
                SubcategoryId = u.SubcategoryId
            } : null;
        }
        public static IQueryable<SubCategoryViewModel> GetSubCategories()
        {
            return from a in Repositories.subcategoryRepo.ReadMany()
                   select new SubCategoryViewModel
                   {
                       Id = a.Id,
                       Active = a.Active,
                       Deleted = a.Deleted,
                       Description = a.Description,
                       Title = a.Title,
                       CategoryId = a.CategoryId
                   };
        }

        public static IQueryable<CategoryViewModel> GetCategories()
        {
            return from a in Repositories.categoryRepo.ReadMany()
                   select new CategoryViewModel
                   {
                       Id = a.Id,
                       Active = a.Active,
                       Deleted = a.Deleted,
                       Description = a.Description,
                       Title = a.Title
                   };
        }
        public static void AddProduct(ProductDetail detail)
        {
            var entity = new Product()
            {
                CreateTime = DateTime.Now,
                Active = true,
                Deleted = false,
                Title = detail.Title,
                Description = detail.Description,
                Campaign= detail.Campaign,
                CampaignRate = detail.CampaignRate,
                SubcategoryId= detail.SubcategoryId,
                Price= detail.Price
            };
            Repositories.productRepo.InsertOne(entity);
        }
        public static void UpdateProduct(ProductDetail detail)
        {
            var orj_entity = Repositories.productRepo.ReadOne(detail.Id);
            var entity = new Product()
            {
                CreateTime = orj_entity.CreateTime,
                Active = orj_entity.Active,
                Deleted = orj_entity.Deleted,
                Title = detail.Title,
                Description = detail.Description,
                Campaign = detail.Campaign,
                CampaignRate = detail.CampaignRate,
                SubcategoryId = detail.SubcategoryId,
                Price = detail.Price,
                Id = detail.Id
            };
            Repositories.productRepo.UpdateOne(detail.Id, entity);
        }
    }
}
