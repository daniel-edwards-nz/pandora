using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.DataBoxEdge.v2023_07_01.AvailableSkus;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum SkuAvailabilityConstant
{
    [Description("Available")]
    Available,

    [Description("Unavailable")]
    Unavailable,
}
