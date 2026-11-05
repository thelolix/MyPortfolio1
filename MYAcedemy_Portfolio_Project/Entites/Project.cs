namespace MYAcedemy_Portfolio_Project.Entites
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string GitHubUrl { get; set; }
        public string CoverImageurl { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
