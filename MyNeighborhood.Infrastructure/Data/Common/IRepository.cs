using System.Linq.Expressions;

namespace MyNeighborhood.Infrastructure.Data.Common
{
    //abstractoin of repository access methods!Typeparam T - Repository type
    public interface IRepository : IDisposable
    {
        //returns  Queryable expression tree
        IQueryable<T> All<T>() where T : class;

        IQueryable<T> All<T>(Expression<Func<T, bool>> search) where T : class;

        //The result collection won't be tracked by the context

        IQueryable<T> AllReadonly<T>() where T : class;

        IQueryable<T> AllReadonly<T>(Expression<Func<T, bool>> search) where T : class;

        //Gets specific record/s from database by primary key

        Task<T> GetByIdAsync<T>(object id) where T : class;

        Task<T> GetByIdsAsync<T>(object id) where T : class;

        Task AddAsync<T>(T entity) where T : class;

        //Adds collection of entities to the database

        Task AddRangeAsync<T>(IEnumerable<T> entities) where T : class;

        //updates a record in th database

        void Update<T>(T entity) where T : class;

        void UpdateRange<T>(IEnumerable<T> entities) where T : class;

        Task DeleteAsync<T>(object id) where T : class;

        void Delete<T>(T entity) where T : class;

        void DeleteRange<T>(IEnumerable<T> entities) where T : class;
        void DeleteRange<T>(Expression<Func<T, bool>> deleteWhereClause) where T : class;

        //detach given entity from the context

        void Detach<T>(T entity) where T : class;

        //Saves all changes in transaction, returns error code

        int SaveChanges();
        Task<int> SaveChangesAsync();




    }
}
