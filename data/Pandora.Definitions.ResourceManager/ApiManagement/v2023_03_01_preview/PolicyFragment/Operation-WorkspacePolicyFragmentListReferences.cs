using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ApiManagement.v2023_03_01_preview.PolicyFragment;

internal class WorkspacePolicyFragmentListReferencesOperation : Pandora.Definitions.Operations.PostOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.OK,
        };

    public override Type? RequestObject() => null;

    public override ResourceID? ResourceId() => new WorkspacePolicyFragmentId();

    public override Type? ResponseObject() => typeof(ResourceCollectionModel);

    public override Type? OptionsObject() => typeof(WorkspacePolicyFragmentListReferencesOperation.WorkspacePolicyFragmentListReferencesOptions);

    public override string? UriSuffix() => "/listReferences";

    internal class WorkspacePolicyFragmentListReferencesOptions
    {
        [QueryStringName("$skip")]
        [Optional]
        public int Skip { get; set; }

        [QueryStringName("$top")]
        [Optional]
        public int Top { get; set; }
    }
}
