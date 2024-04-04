﻿using Microsoft.EntityFrameworkCore.Storage;
using System.Data;
using System.Linq.Expressions;

namespace SaudeIntegrada.Repository.IDataBase
{
    public interface IRepository<T> where T : class
    {
        Task Delete(T entity);

        Task<T> Get(object id);

        Task Save(T entity);

        Task Update(T entity);

        IEnumerable<T> GetAll();

        /*Task<IEnumerable<T>> FindAllByCriteria(Expression<Func<T, bool>> expression);

        Task<T> FindOneByCriteria(Expression<Func<T, bool>> expression);

        Task<IEnumerable<T>> GetAll();

        Task<IDbContextTransaction> CreateTransaction();

        Task<IDbContextTransaction> CreateTransaction(IsolationLevel isolation);*/
    }
}