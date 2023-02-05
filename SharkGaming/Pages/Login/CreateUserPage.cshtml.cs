using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Services.UserServiceFile;
using SharkGaming.Users;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace SharkGaming.Pages.Login
{
    //[Authorize(Roles = "admin")]

    public class CreateUserPageModel : PageModel
    {
        private UserService _userService;

        [BindProperty]
        public string UserName { get; set; }

        [BindProperty, DataType(DataType.Password)]
        public string Password { get; set; }

        public CreateUserPageModel(UserService userService)
        {
            _userService = userService;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _userService.AddUser(new User(UserName, Password));
            return RedirectToPage("/login/logInPage");
        }
    }
}
