using AspNetAtmApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace AspNetAtmApp.Data
{
    public class SeedDataContext
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AspNetAtmAppContext(serviceProvider.GetRequiredService
                                                              <DbContextOptions<AspNetAtmAppContext>>()))
            {
                context.Database.EnsureCreated();    // Zorg dat de databank bestaat

                if (!context.User.Any())      // Voeg enkele groepen toe
                {
                    context.User.AddRange
                            (
                                     new User { Firstname = "?", Lastname = "?", Email = "?", Password = "?", PhoneNumber = "?", },
                                     new User { Firstname = "Firstname", Lastname = "Lastname", Email = "yourmail@gmail.com", Password = "Password", PhoneNumber = "yournumber",}
                            );
                    context.SaveChanges();
                }
            }
        }
    }
}
