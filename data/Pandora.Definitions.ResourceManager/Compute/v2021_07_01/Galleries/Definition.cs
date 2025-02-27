using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Compute.v2021_07_01.Galleries;

internal class Definition : ResourceDefinition
{
    public string Name => "Galleries";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListOperation(),
        new ListByResourceGroupOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(GallerySharingPermissionTypesConstant),
        typeof(ProvisioningStateConstant),
        typeof(SelectPermissionsConstant),
        typeof(SharingProfileGroupTypesConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(GalleryModel),
        typeof(GalleryIdentifierModel),
        typeof(GalleryPropertiesModel),
        typeof(GalleryUpdateModel),
        typeof(SharingProfileModel),
        typeof(SharingProfileGroupModel),
        typeof(SoftDeletePolicyModel),
    };
}
