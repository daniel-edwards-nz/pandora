// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ImportedWindowsAutopilotDeviceIdentityStateDeviceImportStatusConstant
{
    [Description("Unknown")]
    @unknown,

    [Description("Pending")]
    @pending,

    [Description("Partial")]
    @partial,

    [Description("Complete")]
    @complete,

    [Description("Error")]
    @error,
}
