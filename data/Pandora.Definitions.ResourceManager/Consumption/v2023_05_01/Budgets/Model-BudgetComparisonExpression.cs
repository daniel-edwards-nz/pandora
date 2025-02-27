using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Consumption.v2023_05_01.Budgets;


internal class BudgetComparisonExpressionModel
{
    [JsonPropertyName("name")]
    [Required]
    public string Name { get; set; }

    [JsonPropertyName("operator")]
    [Required]
    public BudgetOperatorTypeConstant Operator { get; set; }

    [MinItems(0)]
    [JsonPropertyName("values")]
    [Required]
    public List<string> Values { get; set; }
}
