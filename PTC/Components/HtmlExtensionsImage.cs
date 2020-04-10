
using System.Text;
using System.Web.Mvc;


namespace PTC
{
    public static class HtmlExtensionsImage
    {
        public static MvcHtmlString Image(this HtmlHelper htmlHelper,
            string src,
            string altText, 
            string cssClass)
        {
            TagBuilder tb = new TagBuilder("img");

            tb.MergeAttribute("src", src);
            tb.MergeAttribute("alt", altText);

            if (!string.IsNullOrWhiteSpace(cssClass)) {
                tb.AddCssClass(cssClass);
            }

            return MvcHtmlString.Create(tb.ToString(TagRenderMode.SelfClosing));
        }
    }
}