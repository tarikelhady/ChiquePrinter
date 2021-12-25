using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ChiquePrinter.Domain.Models;
using ChiquePrinter.Domain.Services;
using ChiquePrinter.Infrastructure.Services.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChiquePrinter.Infrastructure.Services
{
    public class UserDataService : IUserService
    {
        private readonly DbContextFactory _contextFactory;
        private readonly NonQueryDataService<User> _nonQueryDataService;

        public UserDataService(DbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
            _nonQueryDataService = new NonQueryDataService<User>(contextFactory);
        }

        public async Task<User> Create(User entity)
        {
            return await _nonQueryDataService.Create(entity);
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _nonQueryDataService.Delete(id);
        }

        public async Task<User> Get(Guid id)
        {
            using (ChiquePrinterDbContext context = _contextFactory.CreateDbContext())
            {
                User entity = await context.Users
                    .FirstOrDefaultAsync((e) => e.Id == id);
                return entity;
            }
        }

        public async Task<User> Get(int number)
        {
            using (ChiquePrinterDbContext context = _contextFactory.CreateDbContext())
            {
                User entity = await context.Users
                    .FirstOrDefaultAsync((e) => e.No == number);
                return entity;
            }
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            using (ChiquePrinterDbContext context = _contextFactory.CreateDbContext())
            {
                IEnumerable<User> entities = await context.Users
                    .ToListAsync();
                return entities;
            }
        }

        public async Task<User> GetByEmail(string email)
        {
            using (ChiquePrinterDbContext context = _contextFactory.CreateDbContext())
            {
                return await context.Users
                    .FirstOrDefaultAsync(a => a.Email == email);
            }
        }

        public async Task<User> GetByUsername(string username)
        {
            using (ChiquePrinterDbContext context = _contextFactory.CreateDbContext())
            {
                return await context.Users
                    .FirstOrDefaultAsync(a => a.Username == username);
            }
        }

        public async Task<User> Update(Guid id, User entity)
        {
            return await _nonQueryDataService.Update(id, entity);
        }
    }
}
