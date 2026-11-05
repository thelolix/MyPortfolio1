namespace MYAcedemy_Portfolio_Project.Entites
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public List<Project> Projects { get; set; }
    }
}
