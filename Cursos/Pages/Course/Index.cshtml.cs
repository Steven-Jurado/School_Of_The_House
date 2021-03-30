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
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
        public CourseEntity Courses { get; set; }
        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPostDelete(string id)
        {
            Courses = B_Course.CourseById(id);
            if (Courses == null)
            {
                return NotFound();
            }
            B_Course.DeleteCourse(Courses);
            Message = "Delete successful 😎";
            return RedirectToPage("Index");
        }
    }
}
