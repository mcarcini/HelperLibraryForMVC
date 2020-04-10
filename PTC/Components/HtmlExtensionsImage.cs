using System.Web.Mvc;


namespace PTC
{
    public static class HtmlExtensionsImage
    {

        public static MvcHtmlString Image(this HtmlHelper htmlHelper,
           string src,
           string altText,                      
           object htmlAttributes = null)

        {
            return Image(htmlHelper, src, altText, string.Empty, string.Empty, htmlAttributes);
        }

        public static MvcHtmlString Image(this HtmlHelper htmlHelper,
           string src,
           string altText,
           string cssClass,
           object htmlAttributes = null)

        {
            return Image(htmlHelper, src, altText, cssClass, string.Empty, htmlAttributes);
        }

        public static MvcHtmlString Image(this HtmlHelper htmlHelper,
        string src,
        string altText,
        string cssClass,
        string name,
        object htmlAttributes = null)
        {
            TagBuilder tb = new TagBuilder("img");

            tb.MergeAttribute("src", src);
            tb.MergeAttribute("alt", altText);

            if (!string.IsNullOrWhiteSpace(cssClass))
            {
                tb.AddCssClass(cssClass);
            }

            if (!string.IsNullOrWhiteSpace(name))
            {
                name = TagBuilder.CreateSanitizedId(name);
                tb.GenerateId(name);
                tb.MergeAttribute("name", name);
            }

            tb.MergeAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));

            return MvcHtmlString.Create(tb.ToString(TagRenderMode.SelfClosing));
        }
    }
}