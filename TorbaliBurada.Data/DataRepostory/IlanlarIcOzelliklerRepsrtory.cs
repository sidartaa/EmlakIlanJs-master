using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Data.DataRepostory
{
    public class IlanlarIcOzelliklerRepsrtory: RepostoryBase<IlanIcOzellikler,int>,IIlanlarIcOzellikler
    {
        public IlanlarIcOzelliklerRepsrtory(DbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
