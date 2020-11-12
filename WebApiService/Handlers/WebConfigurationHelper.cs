using System.Configuration;

namespace WebApiService.Handlers
{
    public class WebConfigurationHelper
    {
        public static string ClientCredentialUserName
        {
            get { return ConfigurationManager.AppSettings["ClientCredentialUserName"].ToString(); }
        }
        public static string ClientCredentialPassword
        {
            get { return ConfigurationManager.AppSettings["ClientCredentialPassword"].ToString(); }
        }
        public static string ClientCredentialRole
        {
            get { return ConfigurationManager.AppSettings["ClientCredentialRole"].ToString(); }
        }
    }
}