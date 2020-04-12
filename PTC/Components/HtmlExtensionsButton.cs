using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTC
{
    public static class HtmlExtensionsButton
    {
        public static MvcHtmlString BoostrapButton(this HtmlHelper htmlHelper,
            string innerHtml, 
            string cssClass,
            string name,
            string id)
        {
            TagBuilder tb = new TagBuilder("button");

            if (string.IsNullOrWhiteSpace(cssClass))
            {
                cssClass = "btn-primary";
            }            

            tb.AddCssClass(cssClass);
            tb.AddCssClass("btn");

            HtmlExtensionsCommon.AddName(tb, name, id);

            tb.InnerHtml = innerHtml;

            tb.MergeAttribute("type", "submit");

            return MvcHtmlString.Create(tb.ToString());
        }
    }
}