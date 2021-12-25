using ChiquePrinter.Domain.Models;
using ChiquePrinter.Domain.Services;
using ChiquePrinter.Infrastructure;
using ChiquePrinter.Infrastructure.Services;
using Microsoft.AspNet.Identity;

DbContextFactory dbContextFactory = new DbContextFactory();
IDataService<User> UserDataService = new GenericDataService<User>(dbContextFactory);
IPasswordHasher passwordHasher = new PasswordHasher();
User usercarmin = new User
{
    Name = "Mohsen",
    Password = passwordHasher.HashPassword("123456"),
    Username ="mohsen",
    Email="mohsen@gmail.com",
    No = 3,
    CreateById = new Guid("112C8DD8-346B-426E-B06C-75BBA97DCD63"),
    CreateDate = DateTime.Now,
    ModifyDate = DateTime.Now
};

UserDataService.Create( usercarmin);
//Console.WriteLine(UserDataService.Delete(new Guid("83bb2113-b510-43b6-e87b-08d9c60abcce")).Result) ;
UserDataService.GetAll().Result.ToList<User>().ForEach((user) => Console.WriteLine($"No : {user.No.ToString()} , Name { user.Username } , Name { user.Password }"));
 
//Console.WriteLine(UserDataService.Get(2).Result.Name);
Console.ReadLine();

