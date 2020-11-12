using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Business.EmlakEngine
{
    public class EmlakKonutTipiEngine : BusinessEngineBase, IEmlakKonutTipiEngine
    {
        IEmlakKonutTipi _emlakKonutTipiEngine;
        public EmlakKonutTipiEngine(IEmlakKonutTipi emlakKonutTipi)
        {
            _emlakKonutTipiEngine = emlakKonutTipi;
        }
        public Task<List<EmlakKonutTipiResponse>> GetAllEmlakKonutTipiSayisiAsync()
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var emlakkonuttipi = _emlakKonutTipiEngine.GetAll();
                return Mapper.Map<List<EmlakKonutTipiResponse>>(await emlakkonuttipi.ToListAsync());
            });
        }
    }
}
