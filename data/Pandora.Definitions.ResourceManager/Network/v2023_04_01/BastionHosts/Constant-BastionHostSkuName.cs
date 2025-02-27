using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2023_04_01.BastionHosts;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum BastionHostSkuNameConstant
{
    [Description("Basic")]
    Basic,

    [Description("Standard")]
    Standard,
}
