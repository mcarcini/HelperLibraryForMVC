
using System.Text;
using System.Web.Mvc;


namespace PTC
{
    public static class HtmlExtensionsImage
    {
        public static MvcHtmlString Image(this HtmlHelper htmlHelper,
            string src,
            string altText)
        {
            StringBuilder sb = new StringBuilder(512);
            sb.AppendFormat("<img src='{0}' alt='{1}' />",src,altText);

            return MvcHtmlString.Create(sb.ToString());
        }
    }
}