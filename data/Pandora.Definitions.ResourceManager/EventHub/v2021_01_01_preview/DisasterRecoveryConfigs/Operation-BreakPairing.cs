using Pandora.Definitions.Attributes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;

namespace Pandora.Definitions.ResourceManager.EventHub.v2021_01_01_preview.DisasterRecoveryConfigs
{
    internal class BreakPairingOperation : Operations.PostOperation
    {
        public override IEnumerable<HttpStatusCode> ExpectedStatusCodes()
        {
            return new List<HttpStatusCode>
            {
                HttpStatusCode.OK,
            };
        }

        public override Type? RequestObject()
        {
            return null;
        }

        public override ResourceID? ResourceId()
        {
            return new DisasterRecoveryConfigId();
        }

        public override string? UriSuffix()
        {
            return "/breakPairing";
        }


    }
}
