// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum RecurrencePatternIndexConstant
{
    [Description("First")]
    @first,

    [Description("Second")]
    @second,

    [Description("Third")]
    @third,

    [Description("Fourth")]
    @fourth,

    [Description("Last")]
    @last,
}
