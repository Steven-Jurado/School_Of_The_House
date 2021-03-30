using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entity;
using Business;

namespace Cursos.Pages.User
{
    public class CreateUserModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
        [BindProperty]
        public UserEntity Student { get; set; }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            B_User.CreateUser(Student);
            Message = "Successfully Created Student 🤩 ";
            return RedirectToPage("Index");
        }
    }
}
