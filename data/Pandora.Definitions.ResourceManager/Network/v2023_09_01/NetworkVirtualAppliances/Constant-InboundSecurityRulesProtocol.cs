using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2023_09_01.NetworkVirtualAppliances;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum InboundSecurityRulesProtocolConstant
{
    [Description("TCP")]
    TCP,

    [Description("UDP")]
    UDP,
}
