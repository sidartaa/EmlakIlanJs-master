using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using Torbali.Core.Common.Contracts.RequestMessages.IlanResimler;

namespace WebApiService.Helpers
{
    public static class FunctionHelper
    {
        public static string RemoveHtml(string text)
        {
            return Regex.Replace(text, @"<(.|\n)*?>", string.Empty);
        }

        public static bool IsIntValid(string value)
        {
            Regex regex = new Regex(@"\d+");
            Match match = regex.Match(value);

            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
        public static bool IsValid(string value)
        {
            bool valid = false;

            if (Regex.IsMatch(value, @"^[a-zA-Z0-9]*$"))
            {
                valid = true;
            }
            else
            {
                valid = false;
            }
            return valid;
        }
    }
    public class RequestModel
    {
        public IlanResimlerRequeste lanResimlerRequeste;
    }
}