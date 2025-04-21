using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CIS_174_Project.TagHelpers
{
    [HtmlTargetElement("styled-submit")]
    public class StyledSubmitTagHelper : TagHelper
    {
        public string Text { get; set; } = "Submit";

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";
            output.TagMode = TagMode.StartTagAndEndTag;

            output.Attributes.SetAttribute("type", "submit");

            string newClasses = "btn btn-primary";
            string oldClasses = output.Attributes["class"]?.Value.ToString() ?? "";
            string classes = (string.IsNullOrEmpty(oldClasses)) ? newClasses : $"{oldClasses} {newClasses}";
            output.Attributes.SetAttribute("class", classes);
        }
    }
}
