using Pandora.Definitions.Attributes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;

namespace Pandora.Definitions.ResourceManager.Attestation.v2020_10_01.AttestationProviders
{
    internal class CreateOperation : Operations.PutOperation
    {
        public override Type? RequestObject()
        {
            return typeof(AttestationServiceCreationParamsModel);
        }

        public override ResourceID? ResourceId()
        {
            return new AttestationProviderId();
        }

        public override Type? ResponseObject()
        {
            return typeof(AttestationProviderModel);
        }


    }
}
