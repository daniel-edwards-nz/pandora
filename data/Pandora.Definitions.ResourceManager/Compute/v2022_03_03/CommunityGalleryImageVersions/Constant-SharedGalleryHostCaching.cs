using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Compute.v2022_03_03.CommunityGalleryImageVersions;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum SharedGalleryHostCachingConstant
{
    [Description("None")]
    None,

    [Description("ReadOnly")]
    ReadOnly,

    [Description("ReadWrite")]
    ReadWrite,
}
