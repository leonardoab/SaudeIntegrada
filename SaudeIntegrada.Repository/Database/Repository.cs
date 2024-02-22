﻿
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SaudeIntegrada.Cross.Repository;
using SaudeIntegrada.Repository.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SaudeIntegrada.Repository.Database
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DbSet<T> Query { get; set; }
        protected DbContext Context { get; set; }

        public Repository(SaudeIntegradaContext context)
        {
            this.Context = context;
            this.Query = Context.Set<T>();
        }

        public async Task Delete(T entity)
        {
            this.Query.Remove(entity);
            await this.Context.SaveChangesAsync();
        }

        public async Task<T> Get(object id)
        {
            return await this.Query.FindAsync(id);
        }

        public async Task Save(T entity)
        {
            await this.Query.AddAsync(entity);
            await this.Context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            this.Query.Update(entity);
            await this.Context.SaveChangesAsync();
        }

        /*public async Task<T> FindOneByCriteria(Expression<Func<T, bool>> expression)
        {
            return await this.Query
                             .AsNoTrackingWithIdentityResolution()
                             .FirstOrDefaultAsync(expression);
        }

        public async Task<IEnumerable<T>> FindAllByCriteria(Expression<Func<T, bool>> expression)
        {
            return await this.Query
                             .AsNoTrackingWithIdentityResolution()
                             .Where(expression)
                             .ToListAsync();
        }

        public async Task<IDbContextTransaction> CreateTransaction(IsolationLevel isolation)
        {
            return await this.Context.Database.BeginTransactionAsync(isolation);
        }

        public async Task<IDbContextTransaction> CreateTransaction()
        {
            return await this.Context.Database.BeginTransactionAsync();
        }*/
    }
}