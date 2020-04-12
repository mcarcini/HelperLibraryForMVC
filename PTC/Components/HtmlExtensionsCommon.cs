using System.Web.Mvc;

namespace PTC
{
    public static class HtmlExtensionsCommon
    {
        public static void AddName(TagBuilder tb, string name, string id) {
            if (!string.IsNullOrWhiteSpace(name))
            {
                name = TagBuilder.CreateSanitizedId(name);
                tb.MergeAttribute("name", name);
            }

            if (!string.IsNullOrWhiteSpace(id))
            {
                id = TagBuilder.CreateSanitizedId(id);
                tb.GenerateId(id);
            }

                
        }
    }
}