using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTİTİES.Materials
{
    public class Product: BaseEntity
    {
        public decimal Price { get; set; }
        public bool Campaign { get; set; }
        public int CampaignRate { get; set; }
        [ForeignKey("Subcategory")]
        public int SubcategoryId { get; set; }
        public virtual Subcategory Subcategory { get; set; }
    }
}
