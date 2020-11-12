using System;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts.IEmlakEngine;

namespace TorbaliBurada.Business.EmlakEngine
{
    public class IlanIcOzelliklerEngine : BusinessEngineBase, IIlanIcOzelliklerEngine
    {
        public Task<IlanIcOzelliklerResponse> CreateAsync(int request)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IlanIcOzelliklerResponse> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IlanIcOzelliklerResponse> UpdateAsync(int request)
        {
            throw new NotImplementedException();
        }
    }
}
