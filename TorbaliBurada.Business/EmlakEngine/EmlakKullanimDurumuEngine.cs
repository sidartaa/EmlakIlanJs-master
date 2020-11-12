using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Business.EmlakEngine
{
    public class EmlakKullanimDurumuEngine : BusinessEngineBase, IEmlakKullanimDurumuEngine
    {
       private readonly IEmlakKullanimDurumu _emlakKullanimDurumuRepostory;
        public EmlakKullanimDurumuEngine(IEmlakKullanimDurumu emlakKullanimDurumuRepostory)
        {
            _emlakKullanimDurumuRepostory = emlakKullanimDurumuRepostory;
        }
        public Task<List<EmlakKullanimDurumuResponse>> GetAllEmlakKullanimDurumuAsync()
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var emlakkullanimdurumu = _emlakKullanimDurumuRepostory.GetAll();
                return Mapper.Map<List<EmlakKullanimDurumuResponse>>(await emlakkullanimdurumu.ToListAsync());
            });
        }
    }
}
