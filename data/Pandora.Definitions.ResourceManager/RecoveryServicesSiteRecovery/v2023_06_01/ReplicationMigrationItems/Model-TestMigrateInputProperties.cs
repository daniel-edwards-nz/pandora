using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.RecoveryServicesSiteRecovery.v2023_06_01.ReplicationMigrationItems;


internal class TestMigrateInputPropertiesModel
{
    [JsonPropertyName("providerSpecificDetails")]
    [Required]
    public TestMigrateProviderSpecificInputModel ProviderSpecificDetails { get; set; }
}
