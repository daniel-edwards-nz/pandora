using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Web.v2023_01_01.Provider;


internal class ApplicationStackModel
{
    [JsonPropertyName("dependency")]
    public string? Dependency { get; set; }

    [JsonPropertyName("display")]
    public string? Display { get; set; }

    [JsonPropertyName("frameworks")]
    public List<ApplicationStackModel>? Frameworks { get; set; }

    [JsonPropertyName("isDeprecated")]
    public List<ApplicationStackModel>? IsDeprecated { get; set; }

    [JsonPropertyName("majorVersions")]
    public List<StackMajorVersionModel>? MajorVersions { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
