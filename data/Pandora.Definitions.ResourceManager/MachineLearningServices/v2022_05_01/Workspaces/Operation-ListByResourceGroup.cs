using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2022_05_01.Workspaces;

internal class ListByResourceGroupOperation : Pandora.Definitions.Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override ResourceID? ResourceId() => new ResourceGroupId();

    public override Type NestedItemType() => typeof(WorkspaceModel);

    public override Type? OptionsObject() => typeof(ListByResourceGroupOperation.ListByResourceGroupOptions);

    public override string? UriSuffix() => "/providers/Microsoft.MachineLearningServices/workspaces";

    internal class ListByResourceGroupOptions
    {
        [QueryStringName("$skip")]
        [Optional]
        public string Skip { get; set; }
    }
}
