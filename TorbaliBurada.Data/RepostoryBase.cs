using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TorbaliBurada.Data.Contracts;
using TorbaliBurada.Data.CodeFirst.Entity;
using System.Collections.Generic;

namespace TorbaliBurada.Data
{
    public abstract class RepostoryBase<TEntity, TKey> : IRepositoryBase<TEntity, TKey>, IDisposable
        where TEntity :EntityBase<int>
    {
       
        private readonly DbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;
        private bool _disposed;
        protected RepostoryBase(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }
        
        #region IRepository members
        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(TEntity entity)
        {
           // _dbSet.Remove(entity);
            
           _dbContext.Entry(entity).State = EntityState.Deleted;
         
        }

        public async Task Delete(TKey id)
        { 
            var entitim = await GetAsync(id);  
            Delete(entitim);
        }
        
        public Task<TEntity> GetAsync(TKey id)
        {
           
            return _dbSet.FindAsync(id);
        }
        public IQueryable<TEntity> GetAll()
        {
            return _dbSet.OrderBy(x=>x.Id);
        }
        public IQueryable<TEntity> GetAll(int skip, int take)
        {
             return _dbSet.OrderBy(q => q.Id).Skip(skip).Take(take);
        }
       
        public IQueryable<TEntity> GetAll(int skip, int take, Expression<Func<TEntity, bool>> predicate)
        {
            return GetAll(skip, take).Where(predicate).Include("IlanResimler");
        }
        public  IQueryable<TEntity> GetParametre(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }
        
      
        public Task<TEntity> GetIlanDetayAsync(TKey id)
        {
            int i = Convert.ToInt32(id);
            return _dbSet.Include("EmlakTakasli").FirstOrDefaultAsync(x => x.Id == i);
        }
        public Task SaveChangeAsync()
        {
            return _dbContext.SaveChangesAsync();
        }

        public void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
        #endregion#region IDisposable members

        #region
        public IQueryable<TEntity> GetAllIlan(int skip, int take)
        {
            return _dbSet.OrderBy(q => q.Id).Skip(skip).Take(take).Include("IlanResimler");
        }

        public IQueryable<TEntity> GetAllIlan(int skip, int take, Expression<Func<TEntity, bool>> predicate)
        {
            return GetAll(skip, take).Where(predicate).Include("IlanResimler");
        }
        public IQueryable<TEntity> GetParametreIlan(Expression<Func<TEntity, bool>> predicate)
        {

            return _dbSet.Include("IlanIlanlar").Where(predicate);
        }
        public  Task<TEntity> GetIlanDetay(TKey id)
        {
            int i = Convert.ToInt32(id);
            return  _dbSet.Include("IlanResimler").Include("IlanDisOzellikler").Include("IlanIcOzellikler").Include("IlanKonutTipiOzellikler").FirstOrDefaultAsync(x=>x.Id==i);
        }
        public Task<TEntity> GetIlanEmlakGenel(TKey id)
        {
            int i = Convert.ToInt32(id);
            return _dbSet.Include("EmlakIsitmaTuru").Include("EmlakOdaSayisi").Include("EmlakBulunduguKat").FirstOrDefaultAsync(x => x.Id==i);
            
        }
        public Task<TEntity> GetIlanKullanimAmaci(TKey id)
        {
            int i = Convert.ToInt32(id);
            return _dbSet.Include("EmlakKullanimAmaci").FirstOrDefaultAsync(x => x.Id == i);

        }

        public Task<TEntity> GetIlanImar(TKey id)
        {
            int i = Convert.ToInt32(id);
            return _dbSet.Include("EmlakImarDurumu").FirstOrDefaultAsync(x => x.Id == i);
        }

        public Task<TEntity> GetIlanTapu(TKey id)
        {
            int i = Convert.ToInt32(id);
            return _dbSet.Include("EmlakTapuDurumu").FirstOrDefaultAsync(x => x.Id == i);
        }


        public async Task<List<TEntity>> GetIlanIcOzellikler(Expression<Func<TEntity, bool>> predicate)
        {
          //  int i = Convert.ToInt32(id);
            
            return await _dbSet.Include("EmlakIcOzellikler").Where(predicate).ToListAsync();
        }

        public async Task<List<TEntity>> GetIlanImages(Expression<Func<TEntity,bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }
        public async Task<List<TEntity>> GetIlanDisOzellikler(Expression<Func<TEntity, bool>> predicate)
        {
           
            return await _dbSet.Include("EmlakDisOzellikler").Where(predicate).ToListAsync(); 
        }
        public async Task<List<TEntity>> GetEmlakKonutTipi(Expression<Func<TEntity, bool>> predicate)
        {

            return await _dbSet.Include("EmlakKonutTipi").Where(predicate).ToListAsync();
        }
        public async Task<List<TEntity>> GetIlanKategoriler(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.Include("EmlakKategoriler").Where(predicate).ToListAsync();
            // Where(d => d.Assessors.Any(a => a.AssessorID == UserID))
        }
       
        #endregion

        #region Disposing
        ~RepostoryBase() { Dispose(false); }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool v)
        {
            if (v && !_disposed)
            {
                _dbContext.Dispose();
            }
            _disposed = true;
        }

       



        #endregion
    }
}
