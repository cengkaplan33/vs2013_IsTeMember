﻿using System.Linq;

namespace Membership.Business.Repository
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        T GetById(long id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(long id);
        void Detach(T entity);
    }
}
