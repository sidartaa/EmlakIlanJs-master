using System.Diagnostics;

namespace WebApiService.ActionFilter.Logger
{
    public class OutputScreenLogger : ILoggerr
    {
        public void Log(string message)
        {
            Debug.WriteLine(message);
        }
    }
}