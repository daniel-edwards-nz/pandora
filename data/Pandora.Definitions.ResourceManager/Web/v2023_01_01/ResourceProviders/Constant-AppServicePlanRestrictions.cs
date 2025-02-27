using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Web.v2023_01_01.ResourceProviders;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum AppServicePlanRestrictionsConstant
{
    [Description("Basic")]
    Basic,

    [Description("Free")]
    Free,

    [Description("None")]
    None,

    [Description("Premium")]
    Premium,

    [Description("Shared")]
    Shared,

    [Description("Standard")]
    Standard,
}
