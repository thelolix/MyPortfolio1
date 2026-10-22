namespace MYAcedemy_Portfolio_Project.Entites
{
    public class Experience
    {
        public int ExperienceID { get; set; }
        public String ExperienceTitle { get; set; }

        public string CompanyName { get; set; }

        public string Description { get; set; }

        public string SideTitle { get; set; }

        public string Duration { get; set; }

        public string WorkType { get; set; }

        public bool IsActive { get; set; }
    }
}
