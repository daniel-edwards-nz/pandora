using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Security.v2020_01_01.ApplicationWhitelistings;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum EnforcementSupportConstant
{
    [Description("NotSupported")]
    NotSupported,

    [Description("Supported")]
    Supported,

    [Description("Unknown")]
    Unknown,
}
