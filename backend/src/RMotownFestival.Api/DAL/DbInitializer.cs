using RMotownFestival.Api.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMotownFestival.Api.DAL
{
    public static class DbInitializer
    {
        public static void Initialize(MotownDbContext context)
        {
            context.Database.EnsureCreated();
            // Look for any students.
            if (context.Artists.Any())
            {
                return;   // DB has been seeded
            }
            var artists = new Artist[]
            {
                      new Artist { Name = "The Commodores", ImagePath = "thecommodores.jpg", Website = new Uri("http://en.wikipedia.org/wiki/Commodores") },
                      new Artist { Name = "Stevie Wonder", ImagePath = "steviewonder.jpg", Website = new Uri("http://www.steviewonder.net/") },
                      new Artist { Name = "Lionel Richie", ImagePath = "lionelrichie.jpg", Website = new Uri("http://lionelrichie.com/") },
                      new Artist { Name = "Marvin Gaye", ImagePath = "marvingaye.jpg", Website = new Uri("http://www.marvingayepage.net/") }
            };
            foreach (Artist a in artists)
            {
                context.Artists.Add(a);
            }
            context.SaveChanges();

        }
    }
}
