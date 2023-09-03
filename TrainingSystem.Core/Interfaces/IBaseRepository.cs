using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSystem.Core.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
       Task<T> GetByIdAsync(int id);
       Task<IEnumerable<T>> GetAllAsync();
       Task<T> AddAsync(T entity);
       Task<T> FindAsync(Expression<Func<T, bool>> criteria);
       Task<T> FindAsync(Expression<Func<T, bool>> criteria, string[] includes = null);


    }
}
