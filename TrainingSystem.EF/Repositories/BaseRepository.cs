using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingSystem.Core.Interfaces;
using TrainingSystem.EF.Data;

namespace TrainingSystem.EF.Repositories
{
    public class DataAccessException : Exception
    {
        public DataAccessException(string message, Exception innerException): base(message, innerException)
        {
        }
    }
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        // just here the place where I need to use the ApplicationDbContext
        protected ApplicationDbContext _context;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<T> GetByIdAsync(int id)
        {
            try
            {
                return await _context.Set<T>().FindAsync(id);
            }
            catch (DbUpdateException ex)
            {
                throw new DataAccessException("An error occurred while fetching an entity by ID.", ex);
            }
        }


        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                return await _context.Set<T>().ToListAsync();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("An error occurred while fetching all entities.", ex);
            }
        }

        public async Task<T> AddAsync(T entity)
        {
            try
            {
                await _context.Set<T>().AddAsync(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (DbUpdateException ex)
            {
                throw new DataAccessException("An error occurred while saving data.", ex);
            }
        }

       public async Task<T> FindAsync(Expression<Func<T, bool>> criteria)
        {
            try
            {
                return await _context.Set<T>().SingleOrDefaultAsync(criteria);
            }
            catch (Exception ex)
            {
                // Handle the exception here, you can log it or re-throw a custom exception if needed.
                throw new DataAccessException("An error occurred while finding the entity.", ex);
            }

        }
        public async Task<T> FindAsync(Expression<Func<T, bool>> criteria, string[] includes = null)
        {
            try
            {
                // Start with a query that targets the main entity type.
                IQueryable<T> query = _context.Set<T>();

                // If includes are specified, loop through them and include related entities.
                if (includes != null)
                {
                    foreach (var include in includes)
                    {
                        query = query.Include(include);
                    }
                }

                // Use the criteria lambda expression to filter the results and return a single entity.
                return await query.SingleOrDefaultAsync(criteria);
            }
            catch (Exception ex)
            {
                // Handle the exception here, you can log it or re-throw a custom exception if needed.
                throw new DataAccessException("An error occurred while finding the entity.", ex);
            }
        }


    }

}
