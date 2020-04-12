using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;

namespace PTC
{
    public static class HtmlExtensionsTextBox
    {

        public static MvcHtmlString BoostrapTextBoxFor<TModel, TValue>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TValue>> expression,
            HtmlExtensionsCommon.Html5InputTypes inputType,
            object htmlAttributes = null
            )
        {
            return BoostrapTextBoxFor(htmlHelper, expression, inputType, 
                                      string.Empty, string.Empty, 
                                      false, false, string.Empty, htmlAttributes);
        }

        public static MvcHtmlString BoostrapTextBoxFor<TModel, TValue>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TValue>> expression,
            HtmlExtensionsCommon.Html5InputTypes inputType,
            string cssClass,
            object htmlAttributes = null
            )
        {
            return BoostrapTextBoxFor(htmlHelper, expression, inputType,
                                      string.Empty, string.Empty,
                                      false, false, cssClass, htmlAttributes);
        }

        public static MvcHtmlString BoostrapTextBoxFor<TModel, TValue>(
        this HtmlHelper<TModel> htmlHelper,
        Expression<Func<TModel, TValue>> expression,
        HtmlExtensionsCommon.Html5InputTypes inputType,
        string title,
        string placeholder,
        bool isRequired,
        bool isAutoFocus,
        string cssClass = "",
        object htmlAttributes = null
        )
        {
            RouteValueDictionary rvd;
            rvd = new RouteValueDictionary(
                                   HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));

            rvd.Add("type", inputType.ToString());

            if (!string.IsNullOrEmpty(title))
            {
                rvd.Add("title", title);
            }

            if (!string.IsNullOrEmpty(placeholder))
            {
                rvd.Add("placeholder", placeholder);
            }

            if (isRequired)
            {
                rvd.Add("required", "required");
            }

            if (isAutoFocus)
            {
                rvd.Add("autofocus", "autofocus");
            }

            if (!string.IsNullOrEmpty(cssClass))
            {
                cssClass = "form-control";
            }
            else
            {
                cssClass = "form-control" + cssClass;
            }

            rvd.Add("class", cssClass);

            return InputExtensions.TextBoxFor(htmlHelper, expression, rvd);
        }
    }
}