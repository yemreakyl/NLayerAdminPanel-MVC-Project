using System.ComponentModel.DataAnnotations;
namespace BLL.Dtos
{
    public class ProductDetail
    {
        [Display(Name = "Kimliği")]
        public int Id { get; set; }

        [Display(Name = "Ürün Adı")]
        [Required]
        [MinLength(5), MaxLength(150)]
        public string Title { get; set; }

        [Display(Name = "Ürün Açıklaması")]
        [Required]
        [MinLength(5), MaxLength(1000)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "Alt Kategori")]
        [Required]
        public int SubcategoryId { get; set; }

        [Display(Name = "Fiyat")]
        [Required]
        public decimal Price { get; set; }

        [Display(Name = "Kampanyalı mı?")]
        public bool Campaign { get; set; }

        [Display(Name = "Kampanya Oranı")]
        public int CampaignRate { get; set; }
    }
}
