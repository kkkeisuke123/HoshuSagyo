// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using HoshuSagyo.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace HoshuSagyo.Areas.Identity.Pages.Account.Manage
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly HoshuSagyoDbContext _hoshuSagyoDbContext;

        public IndexModel(
            UserManager<IdentityUser> userManager, HoshuSagyoDbContext hoshuSagyoDbContext)
        {
            _userManager = userManager;
            _hoshuSagyoDbContext = hoshuSagyoDbContext;
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [Display(Name ="ユーザー名")]
        public string Username { get; set; }

        [Display(Name ="管轄名")]
        public string KankatsuName { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [TempData]
        public string StatusMessage { get; set; }

        private async Task LoadAsync(IdentityUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            Username = userName;

            // クレームから管轄を取得
            int kankatsu = int.Parse(User.Claims.FirstOrDefault(x => x.Type == "Kankatsu").Value);

            // DBから管轄名を取得
            KankatsuName = _hoshuSagyoDbContext.M_Kankatsu.FirstOrDefault(x => x.Kankatsu == kankatsu).KankatsuName;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }
    }
}
