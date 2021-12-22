using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiquePrinter.Domain.Services
{
    public interface IDataService<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get (Guid id);
        Task<T> Update(T entity);
        Task<T> Create(Guid id,T entity);
        Task<bool> Delete(Guid id);

    }
}
