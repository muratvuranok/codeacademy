using Microsoft.AspNetCore.Razor.TagHelpers;

namespace DataTransferToViewAndPartailView.CustomHelpers
{

    [HtmlTargetElement("td", Attributes = "item-id")]
    public class ActionGroup : TagHelper
    {

        public int ItemId { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string content = @$"<div class='dropdown'>
                                  <button class='btn text-warning bg-light btn-sm dropdown-toggle'
                                          type='button' id='dropdownMenuButton1'
                                          data-bs-toggle='dropdown'
                                          aria-expanded='false'>
                                            <i class='fa fa-cogs'></i>
                                  </button>
                                  <ul class='dropdown-menu' aria-labelledby='dropdownMenuButton1'>
                                    <li><a class='dropdown-item' href='details/{ItemId}'><i class='fa fa-search text-primary'></i> &nbsp;          Details</a></li>
                                    <li><a class='dropdown-item' href='edit/{ItemId}'><i class='fa fa-pen text-warning'></i>    &nbsp;          Edit</a></li>
                                    <li><a class='dropdown-item' href='delete/{ItemId}'><i class='fa fa-trash text-danger'></i>   &nbsp;          Delete</a></li>
                                </ul>
                        </div>";


            output.Content.SetHtmlContent(content);
            base.Process(context, output);
        }
    }
}
