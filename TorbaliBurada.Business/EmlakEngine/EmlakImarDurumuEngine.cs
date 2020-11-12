using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Business.EmlakEngine
{
    public class EmlakImarDurumuEngine : BusinessEngineBase, IEmlakImarDurumuEngine
    {
        private readonly IEmlakImarDurumu _emlakImarDurumuRepostory;
        public EmlakImarDurumuEngine(IEmlakImarDurumu emlakimardurumurepostory)
        {
            _emlakImarDurumuRepostory = emlakimardurumurepostory;
        }
        public Task<List<EmlakImarDurumuResponse>> GetAllEmlakImarAsync()
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var emlakimardurumu = _emlakImarDurumuRepostory.GetAll();
                return Mapper.Map<List<EmlakImarDurumuResponse>>(await emlakimardurumu.ToListAsync());
            });
        }
    }
}
