using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.VoiceServices.v2023_09_01.CommunicationsGateways;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ApiBridgeActivationStateConstant
{
    [Description("disabled")]
    Disabled,

    [Description("enabled")]
    Enabled,
}
