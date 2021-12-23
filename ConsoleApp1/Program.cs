using ChiquePrinter.Domain.Models;
using ChiquePrinter.Domain.Services;
using ChiquePrinter.Infrastructure;
using ChiquePrinter.Infrastructure.Services;

DbContextFactory dbContextFactory = new DbContextFactory();
IDataService<User> UserDataService = new GenericDataService<User>(dbContextFactory);
Console.WriteLine(UserDataService.Get(new Guid("112c8dd8-346b-426e-b06c-75bba97dcd63")).Result);
Console.ReadLine();

