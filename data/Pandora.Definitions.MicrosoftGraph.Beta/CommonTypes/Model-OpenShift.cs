// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class OpenShiftModel
{
    [JsonPropertyName("createdBy")]
    public IdentitySetModel? CreatedBy { get; set; }

    [JsonPropertyName("createdDateTime")]
    public DateTime? CreatedDateTime { get; set; }

    [JsonPropertyName("draftOpenShift")]
    public OpenShiftItemModel? DraftOpenShift { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("isStagedForDeletion")]
    public bool? IsStagedForDeletion { get; set; }

    [JsonPropertyName("lastModifiedBy")]
    public IdentitySetModel? LastModifiedBy { get; set; }

    [JsonPropertyName("lastModifiedDateTime")]
    public DateTime? LastModifiedDateTime { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("schedulingGroupId")]
    public string? SchedulingGroupId { get; set; }

    [JsonPropertyName("schedulingGroupName")]
    public string? SchedulingGroupName { get; set; }

    [JsonPropertyName("sharedOpenShift")]
    public OpenShiftItemModel? SharedOpenShift { get; set; }

    [JsonPropertyName("teamId")]
    public string? TeamId { get; set; }

    [JsonPropertyName("teamName")]
    public string? TeamName { get; set; }
}
