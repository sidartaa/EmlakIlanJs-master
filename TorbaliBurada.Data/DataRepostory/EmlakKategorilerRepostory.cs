using System;
using System.Data.Entity;
using System.Linq;
using TorbaliBurada.Data;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
   public class EmlakKategorilerRepostory:RepostoryBase<EmlakKategoriler,int>,IEmlakKategoriler
    {
       // private readonly DbContext _dbContext;
       // private readonly sidart_torbaliBuradaEntities _db;
        public EmlakKategorilerRepostory(DbContext dbContext)
            :base(dbContext)
        {
            //_dbContext = dbContext;
          //  _db = db;
        }

        //public IQueryable<EmlakKategoriler> GetParentId(int id)
        //{
        //  return  this._dbContext.Set<EmlakKategoriler>().Where(x => x.ParentID == id);
        //   // return _db.EmlakKategoriler.Where(x=>x.ParentID==id);

        //}
    }
}
