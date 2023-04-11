using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManagerApp9000.Domain.Entities;
using TaxiManagerApp9000.Services.Interfaces;

namespace TaxiManagerApp9000.Services
{
    public class UserService : BaseService<User>, IUserService
    {
        public bool ChangePassword(int id, string oldPassword, string newPassword)
        {
            User user = Db.GetById(id);
            if (user == null)
            {
                throw new Exception("User not found");
            }
            if(user.Password == oldPassword)
            {
                user.Password = newPassword;
                return true;
            }
            else
            {
                Console.WriteLine("New password can not be previous password.");
                return false;
            }
        }

        public User? Login(string username, string password)
        {
            return Db.GetAll().FirstOrDefault(x=>x.UserName == username && x.Password == password);
        }
    }
}
