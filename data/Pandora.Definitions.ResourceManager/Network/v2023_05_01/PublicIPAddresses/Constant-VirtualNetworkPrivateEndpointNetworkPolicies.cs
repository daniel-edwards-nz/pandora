using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2023_05_01.PublicIPAddresses;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum VirtualNetworkPrivateEndpointNetworkPoliciesConstant
{
    [Description("Disabled")]
    Disabled,

    [Description("Enabled")]
    Enabled,
}
