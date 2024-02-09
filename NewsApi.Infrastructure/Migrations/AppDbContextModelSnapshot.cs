﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewsApi.Infrastructure;

#nullable disable

namespace NewsApi.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NewsApi.Core.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 23,
                            Name = "Stas",
                            Surname = "Smoliar"
                        },
                        new
                        {
                            Id = 2,
                            Age = 12,
                            Name = "Denys",
                            Surname = "Vakulin"
                        },
                        new
                        {
                            Id = 3,
                            Age = 42,
                            Name = "Sergii",
                            Surname = "Brown"
                        },
                        new
                        {
                            Id = 4,
                            Age = 22,
                            Name = "Andrii",
                            Surname = "Bower"
                        },
                        new
                        {
                            Id = 5,
                            Age = 32,
                            Name = "Ktay",
                            Surname = "Tyson"
                        },
                        new
                        {
                            Id = 6,
                            Age = 54,
                            Name = "Ali",
                            Surname = "Muhamed"
                        });
                });

            modelBuilder.Entity("NewsApi.Core.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Category about sport",
                            Name = "Sport"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Category about science",
                            Name = "Science"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Category about medicine",
                            Name = "Medicine"
                        });
                });

            modelBuilder.Entity("NewsApi.Core.Entities.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CountOfVisits")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.ToTable("News");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            CategoryId = 1,
                            CountOfVisits = 0,
                            Description = "Our insiders makes the moves they think NBA GMs should be making ahead of Feb. 8, including a big deal to shake up the Lakers.",
                            ImageName = "image1.jpg",
                            Text = "The 2024 NBA trade deadline is fast approaching, and while some teams have already been active, there are still plenty of others who need to make moves.\r\n\r\nWith that in mind, we asked our",
                            Title = "Six big NBA trades we want to see before the deadline"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            CategoryId = 1,
                            CountOfVisits = 0,
                            Description = "The Lions surrendered a 17-point second-half lead, while the vaunted Ravens scored just 10 points. Here's how the 49ers and Chiefs won.",
                            ImageName = "image2.jpg",
                            Text = "Chiefs-Ravens was a slow burn, as Kansas City got out to an early lead and held onto it throughout. Baltimore got closer and closer to competing as the game went along, but mistakes at ",
                            Title = "Barnwell: The truth behind Detroit's disastrous second half and Baltimore's botched Super Bowl chance"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 3,
                            CategoryId = 2,
                            CountOfVisits = 0,
                            Description = "Alzheimer’s isn’t contagious. But contaminated growth hormone injections caused early-onset Alzheimer’s in some recipients, a new study suggests.",
                            ImageName = "image3.jpg",
                            Text = "Under extremely rare circumstances, it appears that Alzheimer’s disease can be transmitted between people. Five people who received ",
                            Title = "Under very rare conditions, Alzheimer’s disease may be transmitted"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 4,
                            CategoryId = 2,
                            CountOfVisits = 0,
                            Description = "New climate data for ancient Italy point to temperature and rainfall influences on past infectious disease outbreaks.",
                            ImageName = "image4.jpg",
                            Text = "For those who enjoy pondering the Roman Empire’s rise and fall — you know who you are — consider the close link between ancient climate change and infectious disease outbreaks. ",
                            Title = "Cold, dry snaps accompanied three plagues that struck the Roman Empire"
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 5,
                            CategoryId = 3,
                            CountOfVisits = 0,
                            Description = "A lack of funding, mentorship, and compensation for clinician-researchers could threaten America's standing as the world leader in biomedicine.",
                            ImageName = "image5.jpg",
                            Text = "Recent reporting has shown that the number of physician-scientists — doctors who both practice medicine and perform scientific research — in the United States is dropping rapidly. That's a problem, because physician-scientists are uniquely equipped to make scientific",
                            Title = "The Emerging Physician-Scientist Crisis in America"
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 6,
                            CategoryId = 3,
                            CountOfVisits = 0,
                            Description = "There is some evidence — both scientific and anecdotal — that some diets may help with the management of long COVID symptoms. Which...",
                            ImageName = "image6.jpg",
                            Text = "For many people, particularly following vaccination, infection with SARS-CoV-2, the virus that causes COVID-19, resolves within a few days. ",
                            Title = "Could some diets help manage long COVID?"
                        });
                });

            modelBuilder.Entity("NewsApi.Core.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Admin Role",
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Redactor Role",
                            Name = "Redactor"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Writer Role",
                            Name = "Writer"
                        });
                });

            modelBuilder.Entity("NewsApi.Core.Entities.Statistics", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("NewsId")
                        .HasColumnType("int");

                    b.Property<string>("UserIp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserRegion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserSource")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NewsId");

                    b.ToTable("Statistics");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NewsId = 1,
                            UserIp = "143.234.523.1",
                            UserRegion = "Ukraine",
                            UserSource = "Mozilla"
                        },
                        new
                        {
                            Id = 2,
                            NewsId = 2,
                            UserIp = "883.674.263.2",
                            UserRegion = "US",
                            UserSource = "Google"
                        },
                        new
                        {
                            Id = 3,
                            NewsId = 2,
                            UserIp = "773.234.573.3",
                            UserRegion = "Canada",
                            UserSource = "Explorer"
                        },
                        new
                        {
                            Id = 4,
                            NewsId = 4,
                            UserIp = "123.664.563.4",
                            UserRegion = "UK",
                            UserSource = "Explorer"
                        },
                        new
                        {
                            Id = 5,
                            NewsId = 4,
                            UserIp = "743.234.503.5",
                            UserRegion = "France",
                            UserSource = "Mozilla"
                        },
                        new
                        {
                            Id = 6,
                            NewsId = 1,
                            UserIp = "843.774.563.6",
                            UserRegion = "Spain",
                            UserSource = "Google"
                        },
                        new
                        {
                            Id = 7,
                            NewsId = 3,
                            UserIp = "213.244.713.7",
                            UserRegion = "France",
                            UserSource = "Explorer"
                        });
                });

            modelBuilder.Entity("NewsApi.Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 19,
                            Email = "richardpatti11@gmail.com",
                            Name = "Richard",
                            Phone = "+380971373212",
                            RoleId = 2,
                            Surname = "Pati"
                        },
                        new
                        {
                            Id = 2,
                            Age = 32,
                            Email = "thombook33@gmail.com",
                            Name = "Thom",
                            Phone = "+380667776655",
                            RoleId = 3,
                            Surname = "Booking"
                        },
                        new
                        {
                            Id = 3,
                            Age = 22,
                            Email = "eldarnig00@gmail.com",
                            Name = "Eldar",
                            Phone = "+380112223344",
                            RoleId = 1,
                            Surname = "Nig"
                        },
                        new
                        {
                            Id = 4,
                            Age = 46,
                            Email = "griff_simpson@gmail.com",
                            Name = "Griffin",
                            Phone = "+380112223344",
                            RoleId = 1,
                            Surname = "Simpson"
                        },
                        new
                        {
                            Id = 5,
                            Age = 25,
                            Email = "marchsimp@gmail.com",
                            Name = "March",
                            Phone = "+380112223344",
                            RoleId = 1,
                            Surname = "Simpsons"
                        });
                });

            modelBuilder.Entity("NewsApi.Core.Entities.News", b =>
                {
                    b.HasOne("NewsApi.Core.Entities.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NewsApi.Core.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("NewsApi.Core.Entities.Statistics", b =>
                {
                    b.HasOne("NewsApi.Core.Entities.News", "News")
                        .WithMany()
                        .HasForeignKey("NewsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("News");
                });
#pragma warning restore 612, 618
        }
    }
}
