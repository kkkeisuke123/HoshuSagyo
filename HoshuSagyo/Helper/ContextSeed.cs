using HoshuSagyo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HoshuSagyo.Helper
{
    public static class ContextSeed
    {
        public static async Task SeedRolesAsync(
            UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Shirei.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Genchi.ToString()));
        }

        public static async Task SeedSuperAdminAsync(
            UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Default User
            var defaultUser = new ApplicationUser
            {
                UserName = "TokyoShirei@gmail.com",
                Email = "TokyoShirei@gmail.com",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                Kankatsu = 1
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
