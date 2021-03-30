using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Course
    {
        public static List<CourseEntity> CourseList()
        {
            using (var db = new CursoContext())
            {
                return db.Course.ToList();
            }
        }

        public static void CreateCourse(CourseEntity OCourse)
        {
            using (var db = new CursoContext())
            {
                db.Course.Add(OCourse);
                db.SaveChanges();
            }
        }

        public static void UpdateCourse(CourseEntity OCourse)
        {
            using (var db = new CursoContext())
            {
                db.Course.Update(OCourse);
                db.SaveChanges();
            }
        }

        public static void DeleteCourse(CourseEntity OCourse)
        {
            using (var db = new CursoContext())
            {
                db.Course.Remove(OCourse);
                db.SaveChanges();
            }
        }

        public static CourseEntity CourseById(string id)
        {
            using (var db = new CursoContext())
            {
                return db.Course.ToList().LastOrDefault(u => u.IdCourse == id.Trim());
            }
        }
    }
}
