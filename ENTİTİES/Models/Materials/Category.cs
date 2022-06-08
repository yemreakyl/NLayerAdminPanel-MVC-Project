using System.Collections.Generic;

namespace ENTİTİES.Materials
{
    public class Category: BaseEntity
    {
        public virtual ICollection<Subcategory> Subcategories { get; set; }
    }
}
