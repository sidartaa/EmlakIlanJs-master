using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Business.EmlakEngine
{
    public class EmlakBanyoSayisiEngine:BusinessEngineBase,IEmlakBanyoSayisiEngine
    {
        private readonly IEmlakBanyoSayisi _emlakBanyoSayisiRepostory;
        public EmlakBanyoSayisiEngine(IEmlakBanyoSayisi emlakBanyoSayisiRepostory)
        {
            _emlakBanyoSayisiRepostory = emlakBanyoSayisiRepostory;
        }

        public Task<List<EmlakBanyoSayisiResponse>> GetAllEmlakBanyoSayisiAsync()
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var emlakBanyoSayisi = _emlakBanyoSayisiRepostory.GetAll();
                return Mapper.Map<List<EmlakBanyoSayisiResponse>>(await emlakBanyoSayisi.ToListAsync());
            });
        }
    }
}
