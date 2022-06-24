namespace BLL.Dtos
{
    public class SubCategoryViewModel
    {
       
        public int Id { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
    }
}
