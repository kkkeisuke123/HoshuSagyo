using HoshuSagyo.Data;
using HoshuSagyo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;

namespace HoshuSagyo.Helper
{
    public class ApplicationUserClaimsPrincipalFactory : UserClaimsPrincipalFactory<ApplicationUser>
    {
        private readonly ApplicationDbContext _dbContext;

        public ApplicationUserClaimsPrincipalFactory(
            UserManager<ApplicationUser> userManager,
            IOptions<IdentityOptions> options,
            ApplicationDbContext dbContext
            ) : base(userManager, options)
        {
            _dbContext = dbContext;
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(ApplicationUser user)
        {
            var identity = await base.GenerateClaimsAsync(user);

            // ユーザーの情報をDBから取得し、クレームに追加する
            var dbUser = _dbContext.Users.FirstOrDefault(u => u.Id == user.Id);
            identity.AddClaim(new Claim("Id", dbUser.Id));

            return identity;
        }
    }
}
