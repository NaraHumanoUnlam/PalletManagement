using GestionPallets.Application.Common;
using GestionPallets.Domain.Entities;
using GestionPallets.Infrastructure.Persistence;

namespace GetionPallets.Infrastructure.Persistence
{
    public static class SeedData
    {
        public static void Initialize(AppDbContext context, IToken tokenService)
        {
            if (!context.Users.Any())
            {
                var adminUser = new UserEntity
                {
                    Username = "admin",
                    Password = "admin",
                    Token = "",
                    TokenExpiration = DateTime.UtcNow.AddHours(1)
                };

                adminUser.Token = tokenService.GenerateToken(adminUser);

                var normalUser = new UserEntity
                {
                    Username = "user",
                    Password = "user",
                    Token = "",
                    TokenExpiration = DateTime.UtcNow.AddHours(1)
                };

                normalUser.Token = tokenService.GenerateToken(normalUser);

                context.Users.AddRange(adminUser, normalUser);
                context.SaveChanges();
            }
        }
    }
}
