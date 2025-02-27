using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Compute.v2022_03_01.VirtualMachines;


internal class VirtualMachineInstallPatchesResultModel
{
    [JsonPropertyName("error")]
    public ApiErrorModel? Error { get; set; }

    [JsonPropertyName("excludedPatchCount")]
    public int? ExcludedPatchCount { get; set; }

    [JsonPropertyName("failedPatchCount")]
    public int? FailedPatchCount { get; set; }

    [JsonPropertyName("installationActivityId")]
    public string? InstallationActivityId { get; set; }

    [JsonPropertyName("installedPatchCount")]
    public int? InstalledPatchCount { get; set; }

    [JsonPropertyName("maintenanceWindowExceeded")]
    public bool? MaintenanceWindowExceeded { get; set; }

    [JsonPropertyName("notSelectedPatchCount")]
    public int? NotSelectedPatchCount { get; set; }

    [JsonPropertyName("patches")]
    public List<PatchInstallationDetailModel>? Patches { get; set; }

    [JsonPropertyName("pendingPatchCount")]
    public int? PendingPatchCount { get; set; }

    [JsonPropertyName("rebootStatus")]
    public VMGuestPatchRebootStatusConstant? RebootStatus { get; set; }

    [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
    [JsonPropertyName("startDateTime")]
    public DateTime? StartDateTime { get; set; }

    [JsonPropertyName("status")]
    public PatchOperationStatusConstant? Status { get; set; }
}
