using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.CostManagement.v2023_03_01.Exports;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum StatusTypeConstant
{
    [Description("Active")]
    Active,

    [Description("Inactive")]
    Inactive,
}
