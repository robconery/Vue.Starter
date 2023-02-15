using Contoso.Data.Models;
namespace Contoso.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DB context)
        {
          context.Database.EnsureCreated();

          // Look for any users.
          if (context.Users.Any())
          {
              return;   // DB has been seeded
          }

          var users = new User[]
          {
              new User{First="Carson",Last="Alexander",Email="carson@test.com"},
              new User{First="Meredith",Last="Alonso",Email="meredith@test.com"},
              new User{First="Arturo",Last="Anand",Email="arturo@test.com"},
              new User{First="Gytis",Last="Barzdukas",Email="gytis@test.com"},
              new User{First="Yan",Last="Li",Email="yan@test.com"},
              new User{First="Peggy",Last="Justice",Email="justice@test.com"},
              new User{First="Laura",Last="Norman",Email="laura@test.com"},
              new User{First="Nino",Last="Olivetto",Email="nino@test.com"},
            };

          context.Users.AddRange(users);
          context.SaveChanges();
        }
    }
}