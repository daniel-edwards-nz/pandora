using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.RecoveryServicesBackup.v2022_04_01.BackupProtectionIntent;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum WorkloadItemTypeConstant
{
    [Description("Invalid")]
    Invalid,

    [Description("SAPAseDatabase")]
    SAPAseDatabase,

    [Description("SAPAseSystem")]
    SAPAseSystem,

    [Description("SAPHanaDatabase")]
    SAPHanaDatabase,

    [Description("SAPHanaSystem")]
    SAPHanaSystem,

    [Description("SQLDataBase")]
    SQLDataBase,

    [Description("SQLInstance")]
    SQLInstance,
}
