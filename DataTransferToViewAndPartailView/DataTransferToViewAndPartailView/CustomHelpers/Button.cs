using Microsoft.AspNetCore.Razor.TagHelpers;

namespace DataTransferToViewAndPartailView.CustomHelpers
{
    [HtmlTargetElement("a", ParentTag = "td")]
    public class Button : TagHelper
    {
        public string Color { get; set; }
        public string Icon { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class", "btn btn-sm shadow-sm");
            output.Attributes.SetAttribute("id", "btn");

            output.Content.SetHtmlContent($"<i class='fa-md fas fa-{this.Icon} text-{this.Color}'></i>");
            base.Process(context, output);
        }
    }
}
