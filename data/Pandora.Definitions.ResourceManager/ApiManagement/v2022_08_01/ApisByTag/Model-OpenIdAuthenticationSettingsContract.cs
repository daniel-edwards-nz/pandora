using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ApiManagement.v2022_08_01.ApisByTag;


internal class OpenIdAuthenticationSettingsContractModel
{
    [JsonPropertyName("bearerTokenSendingMethods")]
    public List<BearerTokenSendingMethodsConstant>? BearerTokenSendingMethods { get; set; }

    [JsonPropertyName("openidProviderId")]
    public string? OpenidProviderId { get; set; }
}
