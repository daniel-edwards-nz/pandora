using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2023_04_01.OnlineEndpoint;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum EndpointAuthModeConstant
{
    [Description("AADToken")]
    AADToken,

    [Description("AMLToken")]
    AMLToken,

    [Description("Key")]
    Key,
}
