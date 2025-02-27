using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.DataProtection.v2023_12_01.BackupVaults;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum AlertsStateConstant
{
    [Description("Disabled")]
    Disabled,

    [Description("Enabled")]
    Enabled,
}
