using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace WebApiService.FormBuilderFactory
{
    public static class FormElements
    {
        public static MvcHtmlString TextBox(this HtmlHelper helper, string label, string ngmodel, string name, string placeholder, string type)
        {
            var sb = new StringBuilder();
            sb.Append("<div class=\"form-group\">");
            sb.Append("<label class=\"col-md-3 control-label\" for=\"userLoginEmail\">" + label + "</label>");
            sb.Append("<div class=\"col-md-9\">");
            sb.Append("<input class=\"form-control\" ng-model=\"" + ngmodel + "\" name=\"" + name + "\" placeholder=\"" + placeholder + "\" required type = \"" + type + "\">");
            sb.Append("</div>");
            sb.Append("</div>");
            return MvcHtmlString.Create(sb.ToString());
        }

        public static MvcHtmlString Radio(this HtmlHelper helper)
        {
            var sb = new StringBuilder();
            sb.Append("<div class=\"form-group\">");
            sb.Append("<label class=\"col-md-3 control-label\" for=\"userLoginEmail\">label</label>");
            sb.Append("<div class=\"col-md-9\">");
            sb.Append("<div class=\"funkyradio\">");
            sb.Append("<div class=\"funkyradio-success\">");
            sb.Append("<input type = \"radio\" name=\"radio\" id=\"radioBir\"  />");
            sb.Append("<label for=\"radioBir\">xxx</label>");
            sb.Append("</div>");
            sb.Append("</div>");
            sb.Append("</div>");
            sb.Append("</div>");
            return MvcHtmlString.Create(sb.ToString());
        }
       

        public static MvcHtmlString myCostumer(this HtmlHelper helper)
        {
            var sb = new StringBuilder();
            sb.Append("<div ng-controller=\"Controller\">");
            sb.Append("<div my-customer></div>");
            sb.Append("</div>");
            return MvcHtmlString.Create(sb.ToString());
        }
        public static MvcHtmlString ChechBox(this HtmlHelper helper)
        {
            var sb = new StringBuilder();

            return MvcHtmlString.Create(sb.ToString());
        }
    }
}