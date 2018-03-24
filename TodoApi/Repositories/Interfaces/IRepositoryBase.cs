using System;
using System.Collections.Generic;

namespace TodoApi.Repositories.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        bool Add(TEntity obj);

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        bool Update(TEntity obj);

        bool Remove(TEntity obj);

        void Dispose();

    }
}
