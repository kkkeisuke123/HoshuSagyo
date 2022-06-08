using Microsoft.AspNetCore.Identity;

namespace HoshuSagyo.Helper
{
    public static class ContextSeed
    {
        public static async Task SeedRolesAsync(
            UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Shirei.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Genchi.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Mitei.ToString()));
        }

        public static async Task SeedSuperAdminAsync(
            UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Default User
            var defaultUser = new IdentityUser
            {
                UserName = "TokyoShirei@gmail.com",
                Email = "TokyoShirei@gmail.com",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "123Pa$$word.");
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.Shirei.ToString());
                }
            }
        }
    }
}
