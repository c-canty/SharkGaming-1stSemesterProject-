using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Services.UserServiceFile;
using SharkGaming.Users;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace SharkGaming.Pages.Login
{
    public class LogInPageModel : PageModel
    {
        private UserService _userService;

        public static User LoggedInUser { get; set; } = null;

        public LogInPageModel(UserService userService)
        {
            _userService = userService;
        }

        [BindProperty] public string UserName { get; set; }

        [BindProperty, DataType(DataType.Password)] public string Password { get; set; }

        public string Message { get; set; }

        public async Task<IActionResult> OnPost()
        {
            List<User> users = _userService._users;
            foreach (User user in users)
            {
                if (UserName == user.Username && Password == user.Password)
                {
                    LoggedInUser = user;
                    var claims = new List<Claim>
                            {
                                new Claim(ClaimTypes.Name, UserName)
                            };

                    if (UserName == "admin") claims.Add(new Claim(ClaimTypes.Role, "admin"));

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                    return RedirectToPage("/index");
                }
            }

            Message = "Invalid attempt";
            return Page();
        }
    }
}
