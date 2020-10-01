using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Factory;
using TokoBeDia.Model;

namespace TokoBeDia.Repository
{
    public class UserRepository
    {
        public static TokoBeDiaEntities db = new TokoBeDiaEntities();

        public static List<MsUser> GetUser(string Email, string Password)
        {
            return (from x
                    in db.MsUsers
                    where x.Email == Email
                    where x.Password == Password
                    select x).ToList();
        }
        public static List<MsUser> CheckUser(string Email)
        {
            return (from x
                    in db.MsUsers
                    where x.Email == Email
                    where x.Status != "D"
                    select x).ToList();
        }
        public static void InsertUser(string Name, string Email, string Password, string Gender)
        {
            db.MsUsers.Add(UserFactory.InitUser(2, Name, Email, Password, Gender, "A"));
            db.SaveChanges();
        }
        public static List<MsUser> GetAllUserExcept(string Email, string Name)
        {
            return (from x
                    in db.MsUsers
                    where x.Email != Email
                    where x.Name != Name
                    select x).ToList();
        }
        public static List<MsRole> GetAllRole()
        {
            return (from x
                    in db.MsRoles
                    select x).ToList();
        }
        public static void UpdateUser(int ID, int Roles, string Status)
        {
            MsUser user = db.MsUsers.Single(x => x.ID == ID);
            user.RoleID = Roles;
            user.Status = Status;
            db.SaveChanges();
        }
        public static List<MsUser> GetUserProfile(int ID)
        {
            return (from x
                    in db.MsUsers
                    where x.ID == ID
                    select x).ToList();
        }
        public static void UpdateUserProfile(int ID, string Email, string Name, string Gender)
        {
            MsUser user = db.MsUsers.Single(x => x.ID == ID);
            user.Email = Email;
            user.Name = Name;
            user.Gender = Gender;
            db.SaveChanges();
        }
        public static List<MsUser> CheckPassword(int ID, string password)
        {
            return (from x
                   in db.MsUsers
                    where x.ID == ID
                    where x.Password == password
                    select x).ToList();
        }
        public static void ResetPassword(int ID, string Password)
        {
            MsUser user = db.MsUsers.Single(x => x.ID == ID);
            user.Password = Password;
            db.SaveChanges();
        }
    }
}