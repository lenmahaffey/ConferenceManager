using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ConferenceManager.TagHelpers
{
    [HtmlTargetElement("temp-message")]
    public class TempMessageTagHelper : TagHelper
    {
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewCtx { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var td = ViewCtx.TempData;
            if (td.ContainsKey("message"))
            {
                output.BuildTag("h4", "bg-danger text-white text-center p-2 mt-2 rounded");
                output.Content.SetContent(td["message"].ToString());
            }
            else
            {
                output.SuppressOutput();
            }
        }

    }
}
