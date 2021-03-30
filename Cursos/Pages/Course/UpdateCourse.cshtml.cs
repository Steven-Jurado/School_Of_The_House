using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cursos.Pages.Course
{
    public class UpdateCourseModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
        [BindProperty]
        public CourseEntity Course { get; set; }
        public async Task OnGet(string id)
        {
            Course = B_Course.CourseById(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            B_Course.UpdateCourse(Course);
            Message = "successful update 😁";
            return RedirectToPage("Index");
        }
    }
}
