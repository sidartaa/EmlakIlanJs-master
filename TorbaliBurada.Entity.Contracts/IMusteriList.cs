using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Data.Contracts;

namespace TorbaliBurada.Entity.Contracts
{
    public interface IMusteriList: IRepositoryBase<MusteriList, int>
    {
    }
}
