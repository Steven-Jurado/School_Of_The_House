﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cursos.Pages.User
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
        public UserEntity Student { get; set; }
        public async Task<IActionResult> OnPostDelete(string id)
        {
            Student = B_User.UserById(id);
            if (Student == null)
            {
                return NotFound();
            }
            B_User.DeleteUser(Student);
            Message = "Successful Removal 😎 ";
            return RedirectToPage("Index");
        }
    }
}
