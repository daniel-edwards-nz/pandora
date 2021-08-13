using Pandora.Definitions.Attributes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;

namespace Pandora.Definitions.ResourceManager.VMware.v2020_03_20.PrivateClouds
{
    internal class UpdateOperation : Operations.PatchOperation
    {
        public override bool LongRunning()
        {
            return true;
        }

        public override Type? RequestObject()
        {
            return typeof(PrivateCloudUpdateModel);
        }

        public override ResourceID? ResourceId()
        {
            return new PrivateCloudId();
        }

        public override Type? ResponseObject()
        {
            return typeof(PrivateCloudModel);
        }


    }
}
