using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManagerApp9000.Domain.Entities;
using TaxiManagerApp9000.Domain.Enums;

namespace TaxiManagerApp9000.Services.UIServices
{
    public class UIService 
    {
        private readonly UserService _userService; 
        public UIService() { 
        
            _userService = new UserService();
            User user1 = new User("admin", "admin", Role.Administrator);
            User user2 = new User("manager", "manager", Role.Manager);
            User user3 = new User("maintenance", "maintenance", Role.Maintenance);
            _userService.Add(user1);
            _userService.Add(user2);
            _userService.Add(user3);
        }
        public void Login()
        {
            Console.WriteLine("TAXI MANAGER");
            Console.WriteLine("Enter username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            if ((_userService.Login(username, password)) == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong username or password. Try Again");
                Console.ReadKey();
                Console.ResetColor();
                Console.Clear();
                Login();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Logged in {username}");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
            }
        }
        public void Register()
        {
            Console.WriteLine("Create a new user");
            Console.WriteLine("Enter username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            Console.WriteLine("Choose role: \n 1. Administrator \n 2. Manager \n 3. Maintenance");
            Role userRole = (Role)Enum.Parse(typeof(Role), Console.ReadLine());


            if (username == null || password == null || userRole < (Role)1 || userRole > (Role)3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong input you need to try again");
                Console.ReadKey();
                Console.ResetColor();
                Console.Clear();
                Register();
            }
            else
            {
                User user = new User(username, password, userRole);
                _userService.Add(user);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{user.Username} was successfuly added");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
            }
        }
        public void TerminateUser()
        {
            Console.WriteLine("Remove users from app");
            Console.WriteLine("All users:");
            _userService.GetAll();
            //for (int i = 1; i < king.Count - 1; i++)
            //{
            //    Console.WriteLine(i + " " + king[i].Username);
            //}
        }
    }
}
