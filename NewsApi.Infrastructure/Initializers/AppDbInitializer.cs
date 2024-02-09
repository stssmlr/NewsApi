using Microsoft.EntityFrameworkCore;
using NewsApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Infrastructure.Initializers
{
    internal static class AppDbInitializer
    {
        public static async Task SeedCategory(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category[]
                {
                    new Category() { Id = 1, Name = "Sport", Description = "Category about sport" },
                    new Category() { Id = 2, Name = "Science", Description = "Category about science" },
                    new Category() { Id = 3, Name = "Medicine", Description = "Category about medicine" }
                }
            );
        }
        public static async Task SeedNews(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<News>().HasData(new News[]
                {
                    new News() { Id = 1, Title = "Six big NBA trades we want to see before the deadline",
                        Description = "Our insiders makes the moves they think NBA GMs should be making ahead of Feb. " +
                        "8, including a big deal to shake up the Lakers.",
                        Text = "The 2024 NBA trade deadline is fast approaching, and while some teams have already been " +
                        "active, there are still plenty of others who need to make moves.\r\n\r\nWith that in mind, we asked our" 
                        ,
                        AuthorId = 1, CategoryId = 1, ImageName = "image1.jpg" },
                    new News() { Id = 2, Title = "Barnwell: The truth behind Detroit's disastrous second half and Baltimore's " +
                        "botched Super Bowl chance",
                        Description = "The Lions surrendered a 17-point second-half lead, while the " +
                        "vaunted Ravens scored just 10 points. Here's how the 49ers and Chiefs won.",
                        Text = "Chiefs-Ravens was a slow burn, as Kansas City got out to an early lead and held onto it " +
                        "throughout. Baltimore got closer and closer to competing as the game went along, but mistakes at " 
                        ,
                        AuthorId = 2, CategoryId = 1, ImageName = "image2.jpg"  },
                    new News() { Id = 3, Title = "Under very rare conditions, Alzheimer’s disease may be transmitted",
                        Description = "Alzheimer’s isn’t contagious. But contaminated growth hormone injections caused " +
                        "early-onset Alzheimer’s in some recipients, a new study suggests.",
                        Text = "Under extremely rare circumstances, it appears that Alzheimer’s " +
                        "disease can be transmitted between people. Five people who received ",
                        AuthorId = 3, CategoryId = 2, ImageName = "image3.jpg"  },
                    new News() { Id = 4, Title = "Cold, dry snaps accompanied three plagues that struck the Roman Empire",
                        Description = "New climate data for ancient Italy point to temperature and " +
                        "rainfall influences on past infectious disease outbreaks.",
                        Text = "For those who enjoy pondering the Roman Empire’s rise and fall — you know who " +
                        "you are — consider the close link between ancient climate change and infectious disease outbreaks. ", 
                        
                        AuthorId = 4, CategoryId = 2 , ImageName = "image4.jpg" },
                    new News() { Id = 5, Title = "The Emerging Physician-Scientist Crisis in America",
                        Description = "A lack of funding, mentorship, and compensation for clinician-researchers could " +
                        "threaten America's standing as the world leader in biomedicine.",
                        Text = "Recent reporting has shown that the number of physician-scientists — doctors who " +
                        "both practice medicine and perform scientific research — in the United States is dropping rapidly." +
                        " That's a problem, because physician-scientists are uniquely equipped to make scientific" 
                        ,
                        AuthorId = 5, CategoryId = 3, ImageName = "image5.jpg"  },
                    new News() { Id = 6, Title = "Could some diets help manage long COVID?",
                        Description = "There is some evidence — both scientific and anecdotal — " +
                        "that some diets may help with the management of long COVID symptoms. Which...",
                        Text = "For many people, particularly following vaccination, infection with " +
                        "SARS-CoV-2, the virus that causes COVID-19, resolves within a few days. " 
                        ,
                        AuthorId = 6, CategoryId = 3, ImageName = "image6.jpg"  }
                }
            );
        }
        public static async Task SeedAuthor(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author[]
                {
                    new Author() { Id = 1, Name = "Stas", Surname = "Smoliar", Age = 23 },
                    new Author() { Id = 2, Name = "Denys", Surname = "Vakulin", Age = 12 },
                    new Author() { Id = 3, Name = "Sergii", Surname = "Brown", Age = 42 },
                    new Author() { Id = 4, Name = "Andrii", Surname = "Bower", Age = 22 },
                    new Author() { Id = 5, Name = "Ktay", Surname = "Tyson", Age = 32 },
                    new Author() { Id = 6, Name = "Ali", Surname = "Muhamed", Age = 54 }
                }
            );
        }
        public static async Task SeedStatistics(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Statistics>().HasData(new Statistics[]
                {
                    new Statistics() { Id = 1, UserIp = "143.234.523.1", UserSource = "Mozilla", UserRegion = "Ukraine", NewsId = 1},
                    new Statistics() { Id = 2, UserIp = "883.674.263.2", UserSource = "Google", UserRegion = "US", NewsId = 2},
                    new Statistics() { Id = 3, UserIp = "773.234.573.3", UserSource = "Explorer", UserRegion = "Canada", NewsId = 2},
                    new Statistics() { Id = 4, UserIp = "123.664.563.4", UserSource = "Explorer", UserRegion = "UK", NewsId = 4},
                    new Statistics() { Id = 5, UserIp = "743.234.503.5", UserSource = "Mozilla", UserRegion = "France", NewsId = 4},
                    new Statistics() { Id = 6, UserIp = "843.774.563.6", UserSource = "Google", UserRegion = "Spain", NewsId = 1},
                    new Statistics() { Id = 7, UserIp = "213.244.713.7", UserSource = "Explorer", UserRegion = "France", NewsId = 3},
                }
            );
        }
        public static async Task SeedUser(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User[]
                {
                    new User(){Id = 1,Name="Richard",Surname = "Pati", Age = 19,Email = "richardpatti11@gmail.com",Phone = "+380971373212",RoleId = 2},
                    new User(){Id = 2,Name="Thom",Surname = "Booking", Age = 32,Email = "thombook33@gmail.com",Phone = "+380667776655",RoleId = 3},
                    new User(){Id = 3,Name="Eldar",Surname = "Nig", Age = 22,Email = "eldarnig00@gmail.com",Phone = "+380112223344",RoleId = 1},
                    new User(){Id = 4,Name="Griffin",Surname = "Simpson", Age = 46,Email = "griff_simpson@gmail.com",Phone = "+380112223344",RoleId = 1},
                    new User(){Id = 5,Name="March",Surname = "Simpsons", Age = 25,Email = "marchsimp@gmail.com",Phone = "+380112223344",RoleId = 1}
                }

             );
        }
        public static async Task SeedRoles(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(new Role[]
                {
                    new Role(){Id = 1,Name="Admin", Description = "Admin Role"},
                    new Role(){Id = 2,Name="Redactor", Description = "Redactor Role"},
                    new Role(){Id = 3,Name="Writer", Description = "Writer Role",}
                }

             );
        }
    }
}
