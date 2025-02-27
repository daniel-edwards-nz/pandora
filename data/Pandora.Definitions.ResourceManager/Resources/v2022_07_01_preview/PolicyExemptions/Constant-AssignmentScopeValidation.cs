using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Resources.v2022_07_01_preview.PolicyExemptions;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum AssignmentScopeValidationConstant
{
    [Description("Default")]
    Default,

    [Description("DoNotValidate")]
    DoNotValidate,
}
