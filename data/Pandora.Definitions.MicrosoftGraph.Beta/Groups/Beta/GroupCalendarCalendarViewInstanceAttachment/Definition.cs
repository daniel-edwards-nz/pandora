// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Groups.Beta.GroupCalendarCalendarViewInstanceAttachment;

internal class Definition : ResourceDefinition
{
    public string Name => "GroupCalendarCalendarViewInstanceAttachment";

    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateGroupByIdCalendarCalendarViewByIdInstanceByIdAttachmentCreateUploadSessionOperation(),
        new CreateGroupByIdCalendarCalendarViewByIdInstanceByIdAttachmentOperation(),
        new DeleteGroupByIdCalendarCalendarViewByIdInstanceByIdAttachmentByIdOperation(),
        new GetGroupByIdCalendarCalendarViewByIdInstanceByIdAttachmentByIdOperation(),
        new GetGroupByIdCalendarCalendarViewByIdInstanceByIdAttachmentCountOperation(),
        new ListGroupByIdCalendarCalendarViewByIdInstanceByIdAttachmentsOperation()
    };

    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };

    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(CreateGroupByIdCalendarCalendarViewByIdInstanceByIdAttachmentCreateUploadSessionRequestModel)
    };
}
