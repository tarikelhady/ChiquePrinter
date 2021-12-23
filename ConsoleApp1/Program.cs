using ChiquePrinter.Domain.Models;
using ChiquePrinter.Domain.Services;
using ChiquePrinter.Infrastructure;
using ChiquePrinter.Infrastructure.Services;

DbContextFactory dbContextFactory = new DbContextFactory();
IDataService<User> UserDataService = new GenericDataService<User>(dbContextFactory);

//UserDataService.Create(new User
//{
//    Name = "LOGY",
//    Password = "123456",
//    No = 2,
//    CreateById = new Guid("112C8DD8-346B-426E-B06C-75BBA97DCD63"),
//    CreateDate = DateTime.Now,
//    ModifyDate = DateTime.Now
//});
UserDataService.GetAll().Result.ToList<User>().ForEach((user) => Console.WriteLine($"No : {user.No.ToString()} , Name { user.Name }"));
//Console.WriteLine(UserDataService.Get(2).Result.Name);
Console.ReadLine();

