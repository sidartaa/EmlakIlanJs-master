using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts;
using Torbali.Core.Common.Contracts.ResponseMessages;

namespace TorbaliBurada.Business.Contracts.IEmlakEngine
{
   public interface IIlanIcOzelliklerEngine:IBusinessEngine
    {
        Task<IlanIcOzelliklerResponse> CreateAsync(int request);
        Task<IlanIcOzelliklerResponse> UpdateAsync(int request);
        Task DeleteAsync(int id);
        Task<IlanIcOzelliklerResponse> GetAsync(int id);
    }
}
