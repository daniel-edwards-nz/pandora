using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2023_04_01_preview.MachineLearningComputes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ApplicationSharingPolicyConstant
{
    [Description("Personal")]
    Personal,

    [Description("Shared")]
    Shared,
}
