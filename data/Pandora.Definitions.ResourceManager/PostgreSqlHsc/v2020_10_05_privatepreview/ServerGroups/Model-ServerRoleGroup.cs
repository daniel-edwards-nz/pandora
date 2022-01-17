using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.PostgreSqlHsc.v2020_10_05_privatepreview.ServerGroups
{

    internal class ServerRoleGroupModel
    {
        [JsonPropertyName("enableHa")]
        public bool? EnableHa { get; set; }

        [JsonPropertyName("enablePublicIp")]
        public bool? EnablePublicIp { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("role")]
        public ServerRoleConstant? Role { get; set; }

        [JsonPropertyName("serverCount")]
        public int? ServerCount { get; set; }

        [JsonPropertyName("serverEdition")]
        public ServerEditionConstant? ServerEdition { get; set; }

        [JsonPropertyName("serverNames")]
        public List<ServerNameItemModel>? ServerNames { get; set; }

        [JsonPropertyName("storageQuotaInMb")]
        public int? StorageQuotaInMb { get; set; }

        [JsonPropertyName("vCores")]
        public int? VCores { get; set; }
    }
}
