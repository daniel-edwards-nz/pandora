using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Sql.v2023_02_01_preview.ManagedInstanceAdministrators;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ManagedInstanceAdministratorTypeConstant
{
    [Description("ActiveDirectory")]
    ActiveDirectory,
}
