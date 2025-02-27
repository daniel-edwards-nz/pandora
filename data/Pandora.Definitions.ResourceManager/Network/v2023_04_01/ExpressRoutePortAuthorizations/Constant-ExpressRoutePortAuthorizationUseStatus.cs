using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2023_04_01.ExpressRoutePortAuthorizations;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ExpressRoutePortAuthorizationUseStatusConstant
{
    [Description("Available")]
    Available,

    [Description("InUse")]
    InUse,
}
