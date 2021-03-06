﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TodoApi.Context;
using TodoApi.Repositories.Interfaces;

namespace TodoApi.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected readonly TodoApiContext _db;

        public RepositoryBase(TodoApiContext db)
        {
            _db = db;
        }

        public bool Add(TEntity obj)
        {
            _db.Set<TEntity>().Add(obj);
            return _db.SaveChanges() > 0;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _db.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _db.Set<TEntity>().Find(id);
        }

        public bool Remove(TEntity obj)
        {
            _db.Set<TEntity>().Remove(obj);
            return  _db.SaveChanges() > 0;
        }

        public bool Update(TEntity obj)
        {
            _db.Entry(obj).State = EntityState.Modified;
            return _db.SaveChanges() > 0;

        }
    }

}
