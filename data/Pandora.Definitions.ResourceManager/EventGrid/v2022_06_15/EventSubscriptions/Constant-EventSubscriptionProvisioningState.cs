using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.EventGrid.v2022_06_15.EventSubscriptions;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum EventSubscriptionProvisioningStateConstant
{
    [Description("AwaitingManualAction")]
    AwaitingManualAction,

    [Description("Canceled")]
    Canceled,

    [Description("Creating")]
    Creating,

    [Description("Deleting")]
    Deleting,

    [Description("Failed")]
    Failed,

    [Description("Succeeded")]
    Succeeded,

    [Description("Updating")]
    Updating,
}
