using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.SecurityInsights.v2022_10_01_preview.AlertRuleTemplates;


internal class NrtAlertRuleTemplatePropertiesModel
{
    [JsonPropertyName("alertDetailsOverride")]
    public AlertDetailsOverrideModel? AlertDetailsOverride { get; set; }

    [JsonPropertyName("customDetails")]
    public Dictionary<string, string>? CustomDetails { get; set; }

    [JsonPropertyName("entityMappings")]
    public List<EntityMappingModel>? EntityMappings { get; set; }

    [JsonPropertyName("eventGroupingSettings")]
    public EventGroupingSettingsModel? EventGroupingSettings { get; set; }

    [JsonPropertyName("query")]
    [Required]
    public string Query { get; set; }

    [JsonPropertyName("sentinelEntitiesMappings")]
    public List<SentinelEntityMappingModel>? SentinelEntitiesMappings { get; set; }

    [JsonPropertyName("severity")]
    [Required]
    public AlertSeverityConstant Severity { get; set; }

    [JsonPropertyName("tactics")]
    public List<AttackTacticConstant>? Tactics { get; set; }

    [JsonPropertyName("techniques")]
    public List<string>? Techniques { get; set; }

    [JsonPropertyName("version")]
    [Required]
    public string Version { get; set; }
}
