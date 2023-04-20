using TaxiManagerApp9000.Domain.Entities;
using TaxiManagerApp9000.Domain.Enums;
using TaxiManagerApp9000.Services;
using TaxiManagerApp9000.Services.UIServices;

UserService userService = new UserService();

//User user1 = new User("admin", "admin", Role.Administrator);
//User user2 = new User("manager", "manager", Role.Manager);
//User user3 = new User("maintenance", "maintenance", Role.Maintenance);

//userService.Add(user1);
//userService.Add(user2);
//userService.Add(user3);
//userService.GetAll().ForEach(user => Console.WriteLine(user.Username));
//Console.WriteLine("==================================");
UIService uiService = new UIService();
uiService.TerminateUser();
