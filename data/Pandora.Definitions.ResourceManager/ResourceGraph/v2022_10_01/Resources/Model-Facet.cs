using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ResourceGraph.v2022_10_01.Resources;


internal abstract class FacetModel
{
    [JsonPropertyName("expression")]
    [Required]
    public string Expression { get; set; }

    [JsonPropertyName("resultType")]
    [ProvidesTypeHint]
    [Required]
    public string ResultType { get; set; }
}
