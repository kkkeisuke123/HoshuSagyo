using HoshuSagyo.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;

namespace HoshuSagyo.Helper
{
    public class IdentityUserClaimsPrincipalFactory : UserClaimsPrincipalFactory<IdentityUser>
    {
        private readonly ApplicationDbContext _dbContext;

        public IdentityUserClaimsPrincipalFactory(
            UserManager<IdentityUser> userManager,
            IOptions<IdentityOptions> options,
            ApplicationDbContext dbContext
            ) : base(userManager, options)
        {
            _dbContext = dbContext;
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(IdentityUser user)
        {
            var identity = await base.GenerateClaimsAsync(user);

            // ユーザーの情報をDBから取得し、クレームに追加する
            var dbUser = _dbContext.Users.FirstOrDefault(u => u.Id == user.Id);
            identity.AddClaim(new Claim("Id", dbUser.Id));

            return identity;
        }
    }
}
