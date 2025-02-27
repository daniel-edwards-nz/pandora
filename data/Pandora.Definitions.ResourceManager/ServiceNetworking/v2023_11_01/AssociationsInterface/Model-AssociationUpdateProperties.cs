using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ServiceNetworking.v2023_11_01.AssociationsInterface;


internal class AssociationUpdatePropertiesModel
{
    [JsonPropertyName("associationType")]
    public AssociationTypeConstant? AssociationType { get; set; }

    [JsonPropertyName("subnet")]
    public AssociationSubnetUpdateModel? Subnet { get; set; }
}
