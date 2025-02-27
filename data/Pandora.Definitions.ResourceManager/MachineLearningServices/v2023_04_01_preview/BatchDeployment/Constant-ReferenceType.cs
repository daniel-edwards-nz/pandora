using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2023_04_01_preview.BatchDeployment;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ReferenceTypeConstant
{
    [Description("DataPath")]
    DataPath,

    [Description("Id")]
    Id,

    [Description("OutputPath")]
    OutputPath,
}
