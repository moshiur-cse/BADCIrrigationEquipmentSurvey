using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;


namespace BADCIrrigationEquipmentSurvey.Models.BasicModels
{
    [HtmlTargetElement("input", Attributes = "asp-for")]
    public class MaxLengthTagHelper : TagHelper
    {
        public override int Order { get; } = 999;

        [HtmlAttributeName("asp-for")]
        public ModelExpression For { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);

            // Process only if 'maxlength' attr is not present
            if (context.AllAttributes["maxlength"] != null) return;

            // Attempt to check for a MaxLength annotation
            var maxLength = GetMaxLength(For.ModelExplorer.Metadata.ValidatorMetadata);
            if (maxLength > 0)
            {
                output.Attributes.Add("maxlength", maxLength);
            }
        }

        private static int GetMaxLength(IReadOnlyList<object> validatorMetadata)
        {
            for (var i = 0; i < validatorMetadata.Count; i++)
            {
                switch (validatorMetadata[i])
                {
                    case StringLengthAttribute stringLengthAttribute when stringLengthAttribute.MaximumLength > 0:
                        return stringLengthAttribute.MaximumLength;
                    case MaxLengthAttribute maxLengthAttribute when maxLengthAttribute.Length > 0:
                        return maxLengthAttribute.Length;
                }
            }

            return 0;
        }
    }



    [HtmlTargetElement("input", Attributes = "asp-for")]
    public class RequiredTagHelper : TagHelper
    {
        public override int Order => int.MaxValue;

        [HtmlAttributeName("asp-for")]
        public ModelExpression For { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);

            if (context.AllAttributes["required"] != null) return;

            var isRequired = For.ModelExplorer.Metadata.ValidatorMetadata.Any(a => a is RequiredAttribute);
            if (!isRequired) return;

            var requiredAttribute = new TagHelperAttribute("required");
            output.Attributes.Add(requiredAttribute);
        }
    }

}