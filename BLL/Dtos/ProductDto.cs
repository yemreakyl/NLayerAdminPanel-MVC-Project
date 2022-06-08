using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Dtos
{
    public class ProductDto
    {

        [Display(Name ="Ürün Id")]
        public int Id { get; set; }
        [Display(Name = "Ürün Adı")]
        public string Title { get; set; }
        [Display(Name = "Alt Kategorisi")]
        public string Subcategory { get; set; }
        [Display(Name = "Kategorisi")]
        public string Category { get; set; }
        [Display(Name = "Eklenme Tarihi")]
        public DateTime CreateDate { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
    }
}
