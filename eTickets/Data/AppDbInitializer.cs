using eTickets.Data.Enums;
using eTickets.Models;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                // Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "https://static.miraheze.org/avidwiki/thumb/5/56/IMAX_Corporation_%282004-%2C_v2%29.jpeg/454px-IMAX_Corporation_%282004-%2C_v2%29.jpeg",
                            Description = "This is the description of the first Cinema",
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "https://i.pinimg.com/600x315/13/ca/96/13ca96d4e542fff31ef4467cf18e6240.jpg",
                            Description = "This is the description of the second Cinema",
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "https://static.miraheze.org/avidwiki/thumb/5/56/IMAX_Corporation_%282004-%2C_v2%29.jpeg/454px-IMAX_Corporation_%282004-%2C_v2%29.jpeg",
                            Description = "This is the description of the third Cinema",
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "https://i.pinimg.com/600x315/13/ca/96/13ca96d4e542fff31ef4467cf18e6240.jpg",
                            Description = "This is the description of the fourth Cinema",
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "https://static.miraheze.org/avidwiki/thumb/5/56/IMAX_Corporation_%282004-%2C_v2%29.jpeg/454px-IMAX_Corporation_%282004-%2C_v2%29.jpeg",
                            Description = "This is the description of the fifth Cinema",
                        }
                    });
                    context.SaveChanges();
                }
                // Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "https://static1.cbrimages.com/wordpress/wp-content/uploads/2019/09/One-Piece-Monkey-D.-Luffy-Cropped.jpg",
                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://static1.cbrimages.com/wordpress/wp-content/uploads/2019/09/One-Piece-Monkey-D.-Luffy-Cropped.jpg",
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "This is the Bio of the third actor",
                            ProfilePictureURL = "https://static1.cbrimages.com/wordpress/wp-content/uploads/2019/09/One-Piece-Monkey-D.-Luffy-Cropped.jpg",
                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            Bio = "This is the Bio of the fourth actor",
                            ProfilePictureURL = "https://static1.cbrimages.com/wordpress/wp-content/uploads/2019/09/One-Piece-Monkey-D.-Luffy-Cropped.jpg",
                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            Bio = "This is the Bio of the fifth actor",
                            ProfilePictureURL = "https://static1.cbrimages.com/wordpress/wp-content/uploads/2019/09/One-Piece-Monkey-D.-Luffy-Cropped.jpg",
                        }
                    });
                    context.SaveChanges();
            }
                // Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the first producer",
                            ProfilePictureURL = "https://static1.cbrimages.com/wordpress/wp-content/uploads/2019/09/One-Piece-Monkey-D.-Luffy-Cropped.jpg",
                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the Bio of the second producer",
                            ProfilePictureURL = "https://static1.cbrimages.com/wordpress/wp-content/uploads/2019/09/One-Piece-Monkey-D.-Luffy-Cropped.jpg",
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "This is the Bio of the third producer",
                            ProfilePictureURL = "https://static1.cbrimages.com/wordpress/wp-content/uploads/2019/09/One-Piece-Monkey-D.-Luffy-Cropped.jpg",
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "This is the Bio of the fourth producer",
                            ProfilePictureURL = "https://static1.cbrimages.com/wordpress/wp-content/uploads/2019/09/One-Piece-Monkey-D.-Luffy-Cropped.jpg",
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            Bio = "This is the Bio of the fifth producer",
                            ProfilePictureURL = "https://static1.cbrimages.com/wordpress/wp-content/uploads/2019/09/One-Piece-Monkey-D.-Luffy-Cropped.jpg",
                        }
                    });
                    context.SaveChanges();
                }
                // Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Life",
                            Description = "This is the Life movie description",
                            Price = 39.50,
                            ImageURL = "https://m.media-amazon.com/images/I/91MZDyttl8L._AC_SL1500_.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImageURL = "https://irs.www.warnerbros.com/gallery-jpeg/the_shawshank_redemption_posterlarge_0-675188670.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Ghost",
                            Description = "This is the Ghost movie description",
                            Price = 39.50,
                            ImageURL = "https://assets.thehansindia.com/h-upload/2022/10/25/1317818-the-ghost.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Race",
                            Description = "This is the Race movie description",
                            Price = 39.50,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/0/02/Race_2016_film_poster.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 39.50,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/c/ca/Scoob_poster.png",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 39.50,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/5/52/Cold_souls_poster.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }
                // Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
