using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser()
                {
                    DisplayName = "Johnny",
                    Email = "johnny@test.com",
                    UserName = "johnny@test.com",
                    Address = new Address()
                    {
                        FirstName = "Johnny",
                        LastName = "Bravo",
                        Street = "15 Main Rd.",
                        Suburb = "Plumstead",
                        City = "Cape Town",
                        PostalCode = "7800"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}