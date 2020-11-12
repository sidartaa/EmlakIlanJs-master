using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Business.EmlakEngine
{
    public class EmlakKategorilerEngine : BusinessEngineBase, IEmlakKategorilerEngine
    {
        private readonly IEmlakKategoriler _emlakKategorilerRepostory;
        public EmlakKategorilerEngine(IEmlakKategoriler emlakKategorilerRepostory)
        {
            _emlakKategorilerRepostory = emlakKategorilerRepostory;
        }
        public Task<List<EmlakKategoilerResponse>> GetAllEmlakKategorilerAsync()
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var emlakkategiler = _emlakKategorilerRepostory.GetAll();
                return Mapper.Map<List<EmlakKategoilerResponse>>(await emlakkategiler.ToListAsync());
            });
        }

        public Task<List<EmlakKategoilerResponse>> GetParentIdKategorilerAsync(int id)
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                //var lista = repo.Pega( i => i.EstadoId == 1 );
                var emlakkategiler = _emlakKategorilerRepostory.GetParametre(i=>i.ParentID==id);
                return Mapper.Map<List<EmlakKategoilerResponse>>(await emlakkategiler.ToListAsync());
            });
        }
    }
}
