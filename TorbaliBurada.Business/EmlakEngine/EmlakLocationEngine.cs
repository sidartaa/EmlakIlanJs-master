using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Business.EmlakEngine
{
    public class EmlakLocationEngine : BusinessEngineBase, IEmlakLocationEngine
    {
       private readonly IEmlakLocation _emlakLokationRepostory;
        public EmlakLocationEngine(IEmlakLocation emlakLocationRepostory)
        {
            _emlakLokationRepostory = emlakLocationRepostory;
        }
        public Task<List<EmlakLocationResponse>> GetAllEmlakLocationAsync()
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var emlaklocation = _emlakLokationRepostory.GetAll();
                return Mapper.Map<List<EmlakLocationResponse>>(await emlaklocation.ToListAsync());
            });
        }

        public Task<List<EmlakLocationCheckResponse>> GetEmlakLocationAsync(int id)
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var emlaklocation = _emlakLokationRepostory.GetParametre(i => i.ParentID == id);
                return Mapper.Map<List<EmlakLocationCheckResponse>>(await emlaklocation.ToListAsync());
            });
        }
    }
}
