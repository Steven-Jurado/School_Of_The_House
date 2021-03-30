using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cursos.Pages.User
{
    public class UpdateUsersModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
        [BindProperty]
        public UserEntity Student { get; set; }
        public void OnGet(string id)
        {
            Student = B_User.UserById(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            B_User.UpdateUser(Student);
            Message = "Successful Update ✨ ";
            return RedirectToPage("Index");
        }

    }
}
