using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Business.EmlakEngine
{
    public class EmlakOdaSayisiEngine : BusinessEngineBase, IEmlakOdaSayisiEngine
    {
        private readonly IEmlakOdaSayisi _emlakOdaSayisiRepostory;
        public EmlakOdaSayisiEngine(IEmlakOdaSayisi emlakOdaSayisiRepostory)
        {
            _emlakOdaSayisiRepostory = emlakOdaSayisiRepostory;
        }
        public Task<List<EmlakOdaSayisiResponse>> GetAllEmlakOdaSayisiAsync()
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var emlakodasayisi = _emlakOdaSayisiRepostory.GetAll();
                return Mapper.Map<List<EmlakOdaSayisiResponse>>(await emlakodasayisi.ToListAsync());
            });
        }
    }
}
