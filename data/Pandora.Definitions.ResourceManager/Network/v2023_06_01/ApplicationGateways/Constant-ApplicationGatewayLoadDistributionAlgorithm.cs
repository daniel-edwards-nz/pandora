using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2023_06_01.ApplicationGateways;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ApplicationGatewayLoadDistributionAlgorithmConstant
{
    [Description("IpHash")]
    IPHash,

    [Description("LeastConnections")]
    LeastConnections,

    [Description("RoundRobin")]
    RoundRobin,
}
