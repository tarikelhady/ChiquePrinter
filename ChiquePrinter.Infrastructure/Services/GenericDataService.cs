using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ChiquePrinter.Domain.Models;
using ChiquePrinter.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ChiquePrinter.Domain.Models.Shared;
using ChiquePrinter.Infrastructure.Services.Common;

namespace ChiquePrinter.Infrastructure.Services
{
    public class GenericDataService<T> : IDataService<T> where T : ModelBase
    {
        private readonly DbContextFactory _contextFactory;
        private readonly NonQueryDataService<T> _nonQueryDataService;

        public GenericDataService(DbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
            _nonQueryDataService = new NonQueryDataService<T>(contextFactory);
        }

        public async Task<T> Create(T entity)
        {
            return await _nonQueryDataService.Create(entity);
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _nonQueryDataService.Delete(id);
        }

        public async Task<T> Get(Guid id)
        {
            using (ChiquePrinterDbContext context = _contextFactory.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);
                return entity;
            }
        }

        public async Task<T> Get(int no)
        {
            using (ChiquePrinterDbContext context = _contextFactory.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.No == no);
                return entity;
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            using (ChiquePrinterDbContext context = _contextFactory.CreateDbContext())
            {
                IEnumerable<T> entities = await context.Set<T>().ToListAsync();
                return entities;
            }
        }

        public async Task<T> Update(Guid id, T entity)
        {
            return await _nonQueryDataService.Update(id, entity);
        }
    }
}