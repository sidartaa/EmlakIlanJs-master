using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TorbaliBurada.Data.Contracts
{
    public  interface IRepositoryBase<TEntity,TKey>  where TEntity : class
    {
        Task<TEntity> GetAsync(TKey id);
        Task<TEntity> GetIlanDetayAsync(TKey id);
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetAll(int skip, int take);
        IQueryable<TEntity> GetAll(int skip, int take, Expression<Func<TEntity,bool>> predicate);
        IQueryable<TEntity> GetParametre(Expression<Func<TEntity,bool>> predicate);
        Task<TEntity> GetIlanDetay(TKey id);
        Task<TEntity> GetIlanEmlakGenel(TKey id);
        Task<TEntity> GetIlanKullanimAmaci(TKey id);
        Task<TEntity> GetIlanImar(TKey id);
        Task<TEntity> GetIlanTapu(TKey id);
        Task<List<TEntity>> GetIlanIcOzellikler (Expression<Func<TEntity, bool>> predicate);
        Task<List<TEntity>> GetIlanDisOzellikler(Expression<Func<TEntity, bool>> predicate);
        Task<List<TEntity>> GetIlanKategoriler(Expression<Func<TEntity, bool>> predicate);
        Task<List<TEntity>> GetIlanImages(Expression<Func<TEntity, bool>> predicate);
        void Add(TEntity entity);
        Task Delete(TKey id);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        Task SaveChangeAsync();
        IQueryable<TEntity> GetAllIlan(int skip, int take);
        IQueryable<TEntity> GetAllIlan(int skip, int take, Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> GetParametreIlan(Expression<Func<TEntity, bool>> predicate);
        

    }
}
