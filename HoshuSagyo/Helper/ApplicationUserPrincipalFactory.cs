using HoshuSagyo.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;

namespace HoshuSagyo.Helper
{
    public class IdentityUserClaimsPrincipalFactory : UserClaimsPrincipalFactory<IdentityUser>
    {
        private readonly HoshuSagyoDbContext _dbContext;

        public IdentityUserClaimsPrincipalFactory(
            UserManager<IdentityUser> userManager,
            IOptions<IdentityOptions> options,
            HoshuSagyoDbContext dbContext
            ) : base(userManager, options)
        {
            _dbContext = dbContext;
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(IdentityUser user)
        {
            var identity = await base.GenerateClaimsAsync(user);

            // ユーザーの情報をDBから取得し、クレームに追加する
            var dbUser = _dbContext.M_UserInfo.FirstOrDefault(u => u.UserId == user.Id);
            identity.AddClaim(new Claim("Keito", dbUser.Keito));
            identity.AddClaim(new Claim("Kankatsu", dbUser.Kankatsu));

            return identity;
        }
    }
}
