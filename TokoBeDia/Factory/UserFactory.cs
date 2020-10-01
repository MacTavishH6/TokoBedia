using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.Model;

namespace TokoBeDia.Factory
{
    public class UserFactory
    {
        public static MsUser InitUser(int RoleID, string Name, string Email, string Password, string Gender, string Status)
        {
            MsUser User = new MsUser()
            {
                RoleID = RoleID,
                Name = Name,
                Email = Email,
                Password = Password,
                Gender = Gender,
                Status = Status
            };
            return User;
        }
    }
}