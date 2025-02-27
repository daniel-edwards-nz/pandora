using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Authorization.v2018_01_01_preview.RoleAssignments;

internal class ListForResourceOperation : Pandora.Definitions.Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override ResourceID? ResourceId() => new ScopeId();

    public override Type NestedItemType() => typeof(RoleAssignmentModel);

    public override Type? OptionsObject() => typeof(ListForResourceOperation.ListForResourceOptions);

    public override string? UriSuffix() => "/providers/Microsoft.Authorization/roleAssignments";

    internal class ListForResourceOptions
    {
        [QueryStringName("$filter")]
        [Optional]
        public string Filter { get; set; }
    }
}
