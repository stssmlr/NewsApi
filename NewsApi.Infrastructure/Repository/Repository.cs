﻿using Ardalis.Specification;
using Microsoft.EntityFrameworkCore;
using NewsApi.Core.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Infrastructure.Repository
{
    internal class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        internal required AppDbContext context;
        internal required DbSet<TEntity> dbSet;

        public Repository(AppDbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public async virtual Task Delete(object id)
        {
            TEntity? entityToDelete = await dbSet.FindAsync(id);
            if (entityToDelete != null)
            {
                await Delete(entityToDelete);
                await Save();
            }
        }

        public async Task Delete(TEntity entityToDelete)
        {
            await Task.Run(() =>
            {
                if (context.Entry(entityToDelete).State == EntityState.Detached)
                {
                    dbSet.Attach(entityToDelete);
                }
                dbSet.Remove(entityToDelete);
            });
            await Save();
        }

        public async Task<IEnumerable<IEntity>> GetAll()
        {
            return await dbSet.ToListAsync();
        }

        public async virtual Task<IEntity?> GetByID(object id)
        {
            return await dbSet.FindAsync(id);
        }

        public async virtual Task Insert(TEntity entity)
        {
            await dbSet.AddAsync(entity);
            await Save();
        }

        public async Task Save()
        {
            await context.SaveChangesAsync();
        }

        public async virtual Task Update(TEntity entityToUpdate)
        {
            await Task.Run(() =>
            {
                dbSet.Attach(entityToUpdate);
                context.Entry(entityToUpdate).State = EntityState.Modified;
            });
            await Save();
        }
    }
}