using Microsoft.AspNetCore.Razor.TagHelpers;

namespace DataTransferToViewAndPartailView.CustomHelpers;


[HtmlTargetElement("email", TagStructure = TagStructure.WithoutEndTag)]
public class Email : TagHelper
{
    [HtmlAttributeName("recipient")]
    public string MailTo { get; set; }

    [HtmlAttributeName("kime")]
    public string To { get; set; }
    private const string EmailDomain = "code.edu.az";
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        string email = $"{MailTo}@{EmailDomain}";
         
        output.TagName = "a";
        output.Attributes.SetAttribute("href", $"mailto:{email}");
        output.Content.SetContent($"{To} : {email}");
    }
}
