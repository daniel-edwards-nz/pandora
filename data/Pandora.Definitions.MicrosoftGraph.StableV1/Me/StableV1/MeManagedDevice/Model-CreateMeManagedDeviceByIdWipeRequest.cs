// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Me.StableV1.MeManagedDevice;

internal class CreateMeManagedDeviceByIdWipeRequestModel
{
    [JsonPropertyName("keepEnrollmentData")]
    public bool? KeepEnrollmentData { get; set; }

    [JsonPropertyName("keepUserData")]
    public bool? KeepUserData { get; set; }

    [JsonPropertyName("macOsUnlockCode")]
    public string? MacOsUnlockCode { get; set; }

    [JsonPropertyName("persistEsimDataPlan")]
    public bool? PersistEsimDataPlan { get; set; }
}
