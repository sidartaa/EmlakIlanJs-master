using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Business.EmlakEngine
{
    public class EmlakIsitmaTuruEngine : BusinessEngineBase, IEmlakIsıtmaTuruEngine
    {
        private readonly IEmlakIsitmaTuru _emlakIsitmaTuruRepostory;
        public EmlakIsitmaTuruEngine(IEmlakIsitmaTuru emlakIsitmaTuruRopostory)
        {
            _emlakIsitmaTuruRepostory = emlakIsitmaTuruRopostory;
        }
        public Task<List<EmlakIsitmaTuruResonse>> GetAllEmlakIsitmaTuruAsync()
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var emlakisitmaturu = _emlakIsitmaTuruRepostory.GetAll();
                return Mapper.Map<List<EmlakIsitmaTuruResonse>>(await emlakisitmaturu.ToListAsync());
            });
        }
    }
}
