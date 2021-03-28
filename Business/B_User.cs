using DataAccess;
using Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business
{
    public class B_User
    {
        public string Message { get; set; }
        public static  List<UserEntity> UserList()
        {
            using (var db = new CursoContext())
            {
                return db.Users.ToList();
            }
        }

        public static void CreateUser(UserEntity OUser)
        {
            using (var db = new CursoContext())
            {
                db.Users.Add(OUser);
                db.SaveChanges();
            }
        }

        public static void UpdateUser(UserEntity OUser)
        {
            using (var db = new CursoContext())
            {
                db.Users.Update(OUser);
                db.SaveChanges();
            }
        }

        public static void DeleteUser(UserEntity OUser)
        {
            using (var db = new CursoContext())
            {
                db.Users.Remove(OUser);
                db.SaveChanges();
            }
        }

        public static UserEntity UserById(string id)
        {
            using (var db = new CursoContext())
            {
                return db.Users.ToList().LastOrDefault(u => u.IdUser == id.Trim());
            }
        }
    }
}
