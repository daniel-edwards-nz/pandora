using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.RecoveryServicesSiteRecovery.v2023_01_01.ReplicationRecoveryPlans;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum HyperVReplicaAzureRpRecoveryPointTypeConstant
{
    [Description("Latest")]
    Latest,

    [Description("LatestApplicationConsistent")]
    LatestApplicationConsistent,

    [Description("LatestProcessed")]
    LatestProcessed,
}
