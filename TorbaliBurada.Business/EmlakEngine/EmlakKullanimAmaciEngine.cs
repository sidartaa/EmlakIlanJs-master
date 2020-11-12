using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Business.EmlakEngine
{
    public class EmlakKullanimAmaciEngine : BusinessEngineBase, IEmlakKullanimAmaciEngine
    {
      private readonly IEmlakKullanimAmaci _emlakKullanimAmaciRepostory;
        public EmlakKullanimAmaciEngine(IEmlakKullanimAmaci emlakKullanimAmaciRepostory)
        {
            _emlakKullanimAmaciRepostory = emlakKullanimAmaciRepostory;
        }
        public Task<List<EmlakKullanimAmaciResponse>> GetAllEmlakKullanimAmaciAsync()
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var emlakkullanimamaci = _emlakKullanimAmaciRepostory.GetAll();
                return Mapper.Map<List<EmlakKullanimAmaciResponse>>(await emlakkullanimamaci.ToListAsync());
            });
        }
    }
}
