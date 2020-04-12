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
            string id,
            HtmlExtensionsCommon.HtmlButtonTypes buttonType = HtmlExtensionsCommon.HtmlButtonTypes.submit,
            object htmlAttributes = null)
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

            switch (buttonType)
            {
                case HtmlExtensionsCommon.HtmlButtonTypes.submit:
                    tb.MergeAttribute("type", "submit");
                    break;
                case HtmlExtensionsCommon.HtmlButtonTypes.reset:
                    tb.MergeAttribute("type", "reset");
                    break;
                case HtmlExtensionsCommon.HtmlButtonTypes.button:
                    tb.MergeAttribute("type", "button");
                    break;

            }
            

            return MvcHtmlString.Create(tb.ToString());
        }
    }
}