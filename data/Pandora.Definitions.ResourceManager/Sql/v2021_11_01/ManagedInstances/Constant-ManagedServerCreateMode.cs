using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Sql.v2021_11_01.ManagedInstances;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ManagedServerCreateModeConstant
{
    [Description("Default")]
    Default,

    [Description("PointInTimeRestore")]
    PointInTimeRestore,
}
