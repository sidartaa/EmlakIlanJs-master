using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Business.EmlakEngine
{
    public class EmlakTapuDurumuEngine : BusinessEngineBase, IEmlakTapuDurumuEngine
    {
        private readonly IEmlakTapuDurumu _emlakTapuDurumuREpostory;
        public EmlakTapuDurumuEngine(IEmlakTapuDurumu emlakTapuDurumuRepostory)
        {
            _emlakTapuDurumuREpostory = emlakTapuDurumuRepostory;
        }
        public Task<List<EmlakTapuDurumuResponse>> GetAllEmlkaTapuDurumumAsync()
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var emlaktapudurumu = _emlakTapuDurumuREpostory.GetAll();
                return Mapper.Map<List<EmlakTapuDurumuResponse>>(await emlaktapudurumu.ToListAsync());
            });
        }
    }
}
