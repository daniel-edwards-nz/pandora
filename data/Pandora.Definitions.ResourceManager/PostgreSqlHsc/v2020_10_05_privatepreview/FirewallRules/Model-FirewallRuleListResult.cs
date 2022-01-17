using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.PostgreSqlHsc.v2020_10_05_privatepreview.FirewallRules
{

    internal class FirewallRuleListResultModel
    {
        [JsonPropertyName("value")]
        public List<FirewallRuleModel>? Value { get; set; }
    }
}
