using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.RequestMessages.IlanResimler;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts.IEmlakEngine;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;
using System.Web;
using System.Web.Mvc;
namespace TorbaliBurada.Business.EmlakEngine
{
    public class IlanResimlerEngine : BusinessEngineBase, IIlanResimlerEngine
    {
       private readonly IIlanResimler _ilanResimRepostory;
        public IlanResimlerEngine(IIlanResimler ilanResimRepostory)
        {
            _ilanResimRepostory = ilanResimRepostory;
        }
        public Task<IlanResimlerResponse> CreateAsync(IlanResimlerRequest request)
        {
            
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                IlanResimlerRequeste r = new IlanResimlerRequeste();
                IlanResimlerResponse rr = new IlanResimlerResponse();
                foreach (var item in request.Resimler)
                {
                    r.IlanId = request.IlanId;
                    r.Resim = item;
                    var resim = Mapper.Map<IlanResimler>(r);
                    _ilanResimRepostory.Add(resim);
                    await _ilanResimRepostory.SaveChangeAsync();
                }
               // rr.Id = 1;
                rr.IlanId = 46;
                rr.Resim = "x.jpg";
                return Mapper.Map<IlanResimlerResponse>(rr);
            });
        }

        public IlanResimlerResponse CreateeAsync(IlanResimlerRequest request)
        {
            return base.ExecuteWithExceptionHandledOperation(() =>
            {
                IlanResimlerRequeste r = new IlanResimlerRequeste();
                IlanResimlerResponse rr = new IlanResimlerResponse();
                foreach (var item in request.Resimler)
                {
                    r.IlanId = request.IlanId;
                    if (item.Trim() == null || item.Trim()=="")
                        r.Resim = "noimages.jpg";
                    else
                        r.Resim = item;
                    var resim = Mapper.Map<IlanResimler>(r);
                    _ilanResimRepostory.Add(resim);
                    _ilanResimRepostory.SaveChangeAsync();
                }
                // rr.Id = 1;
                rr.IlanId = 46;
                rr.Resim = "x.jpg";
                return Mapper.Map<IlanResimlerResponse>(rr);
            });
        }

        public Task DeleteAsync(int id)
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var a = await _ilanResimRepostory.GetAsync(id);
                string silinecekresim = HttpContext.Current.Server.MapPath("~/Userimage/" + a.Resim.ToString());
                System.IO.File.Delete(silinecekresim);
                

                await _ilanResimRepostory.Delete(id);

                await _ilanResimRepostory.SaveChangeAsync();
            });
        }

        public Task<IlanResimlerResponse> GetAsync(int id)
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var user = await _ilanResimRepostory.GetAsync(id);

                return Mapper.Map<IlanResimlerResponse>(user);
            });
        }

        public  Task<IlanResimlerResponse> GetResimAsync(IlanResimlerRequeste request)
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var user = _ilanResimRepostory.GetParametre(x=>x.IlanId==request.IlanId);
                if (user.Count() > 0)
                    return Mapper.Map<IlanResimlerResponse>(await user.FirstAsync());
                else
                    return null;
                
            });
        }
        public Task<List<IlanResimlerResponse>> GetListResimAsync(IlanResimlerRequeste request)
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var user = _ilanResimRepostory.GetParametre(x => x.IlanId == request.IlanId);
                if (user.Count() > 0)
                    return Mapper.Map<List<IlanResimlerResponse>>(await user.ToListAsync());
                else
                    return null;

            });
        }
    }
}
