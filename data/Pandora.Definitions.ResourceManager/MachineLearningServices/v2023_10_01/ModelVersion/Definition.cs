using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2023_10_01.ModelVersion;

internal class Definition : ResourceDefinition
{
    public string Name => "ModelVersion";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListOperation(),
        new PublishOperation(),
        new RegistryModelVersionsCreateOrGetStartPendingUploadOperation(),
        new RegistryModelVersionsCreateOrUpdateOperation(),
        new RegistryModelVersionsDeleteOperation(),
        new RegistryModelVersionsGetOperation(),
        new RegistryModelVersionsListOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(AssetProvisioningStateConstant),
        typeof(ListViewTypeConstant),
        typeof(PendingUploadCredentialTypeConstant),
        typeof(PendingUploadTypeConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(BlobReferenceForConsumptionDtoModel),
        typeof(DestinationAssetModel),
        typeof(FlavorDataModel),
        typeof(ModelVersionModel),
        typeof(ModelVersionResourceModel),
        typeof(PendingUploadCredentialDtoModel),
        typeof(PendingUploadRequestDtoModel),
        typeof(PendingUploadResponseDtoModel),
        typeof(SASCredentialDtoModel),
    };
}
