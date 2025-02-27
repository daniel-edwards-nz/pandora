// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Users.Beta.UserDeviceRegisteredUser;

internal class UserIdDeviceIdRegisteredUserId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/users/{userId}/devices/{deviceId}/registeredUsers/{directoryObjectId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticUsers", "users"),
        ResourceIDSegment.UserSpecified("userId"),
        ResourceIDSegment.Static("staticDevices", "devices"),
        ResourceIDSegment.UserSpecified("deviceId"),
        ResourceIDSegment.Static("staticRegisteredUsers", "registeredUsers"),
        ResourceIDSegment.UserSpecified("directoryObjectId")
    };
}
