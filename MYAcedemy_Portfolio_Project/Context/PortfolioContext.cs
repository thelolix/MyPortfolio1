using Microsoft.EntityFrameworkCore;
using MYAcedemy_Portfolio_Project.Entites;

namespace MYAcedemy_Portfolio_Project.Context
{


    //DbContext yazıyoruz bunu yazmamızın sebebi sql ile ilişki kurucaz
    public class PortfolioContext : DbContext
    {
        //About bizim classslarımız ama Abouts'ise sqldeki tabloların ismi olucak


        //ovverride methodunu kullanmamızın sebebi DbContextOptionsBuilder optionsBuilder parametresini kullanmak için
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=Talha\SQLEXPRESS;Database=PortfolioDB;Integrated Security=True;TrustServerCertificate=True");
        }
        
        public DbSet<About> Abouts { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<HeroSection> HeroSections { get; set; }

    }
}

//override
