using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ENTİTİES.Materials
{
    public class Subcategory : BaseEntity
    {
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Categories { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
