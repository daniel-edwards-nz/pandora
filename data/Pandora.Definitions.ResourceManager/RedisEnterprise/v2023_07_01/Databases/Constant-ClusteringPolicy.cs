using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.RedisEnterprise.v2023_07_01.Databases;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ClusteringPolicyConstant
{
    [Description("EnterpriseCluster")]
    EnterpriseCluster,

    [Description("OSSCluster")]
    OSSCluster,
}
