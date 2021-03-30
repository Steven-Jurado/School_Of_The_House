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
    public class CreateCourseModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
        [BindProperty]
        public CourseEntity Course { get; set; }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            B_Course.CreateCourse(Course);
            Message = "Course Created successful 🤩";
            return RedirectToPage("Index");
        }
    }
}
