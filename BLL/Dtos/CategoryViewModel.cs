namespace BLL.Dtos
{
    public class CategoryViewModel
    {
       
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public string Description { get; set; }
    }
}
