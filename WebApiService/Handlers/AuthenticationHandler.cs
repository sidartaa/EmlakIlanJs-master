using System;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace WebApiService.Handlers
{
    public class AuthenticationHandler : DelegatingHandler
    {


        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            try
            {
                if (request.Headers.Authorization == null)
                {
                    // var response = new HttpResponseMessage(HttpStatusCode.Forbidden);
                    var response = new HttpResponseMessage(HttpStatusCode.OK);
                    var taskCompletionSource = new TaskCompletionSource<HttpResponseMessage>();
                    taskCompletionSource.SetResult(response);
                    return taskCompletionSource.Task;
                }
                var tokens = request.Headers.Authorization.Parameter;
                if (tokens != null)
                {
                    byte[] data = Convert.FromBase64String(tokens);
                    string decodedString = Encoding.UTF8.GetString(data);
                    string[] tokensValues = decodedString.Split(':');

                    string requestUserName = tokensValues[0];
                    string requestUserPassword = tokensValues[1];

                    if (requestUserName == WebConfigurationHelper.ClientCredentialUserName && requestUserPassword == WebConfigurationHelper.ClientCredentialPassword)
                    {
                        IPrincipal principal = new GenericPrincipal(new GenericIdentity(WebConfigurationHelper.ClientCredentialUserName), new string[] { WebConfigurationHelper.ClientCredentialRole });
                        Thread.CurrentPrincipal = principal;
                        HttpContext.Current.User = principal;
                    }
                    else
                    {
                        var response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
                        var taskCompletionSource = new TaskCompletionSource<HttpResponseMessage>();
                        taskCompletionSource.SetResult(response);
                        return taskCompletionSource.Task;
                    }
                }
                else
                {
                    //  var response = new HttpResponseMessage(HttpStatusCode.Forbidden);
                    var response = new HttpResponseMessage(HttpStatusCode.OK);
                    var taskCompletionSource = new TaskCompletionSource<HttpResponseMessage>();
                    taskCompletionSource.SetResult(response);
                    return taskCompletionSource.Task;
                }

                return base.SendAsync(request, cancellationToken);
            }
            catch (Exception)
            {
                var response = new HttpResponseMessage(HttpStatusCode.Forbidden);
                var taskCompletionSource = new TaskCompletionSource<HttpResponseMessage>();
                taskCompletionSource.SetResult(response);
                return taskCompletionSource.Task;
            }
        }
    }
}