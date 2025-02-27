// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;

internal class OnlineMeetingModel
{
    [JsonPropertyName("allowAttendeeToEnableCamera")]
    public bool? AllowAttendeeToEnableCamera { get; set; }

    [JsonPropertyName("allowAttendeeToEnableMic")]
    public bool? AllowAttendeeToEnableMic { get; set; }

    [JsonPropertyName("allowMeetingChat")]
    public OnlineMeetingAllowMeetingChatConstant? AllowMeetingChat { get; set; }

    [JsonPropertyName("allowParticipantsToChangeName")]
    public bool? AllowParticipantsToChangeName { get; set; }

    [JsonPropertyName("allowTeamworkReactions")]
    public bool? AllowTeamworkReactions { get; set; }

    [JsonPropertyName("allowedPresenters")]
    public OnlineMeetingAllowedPresentersConstant? AllowedPresenters { get; set; }

    [JsonPropertyName("attendanceReports")]
    public List<MeetingAttendanceReportModel>? AttendanceReports { get; set; }

    [JsonPropertyName("attendeeReport")]
    public string? AttendeeReport { get; set; }

    [JsonPropertyName("audioConferencing")]
    public AudioConferencingModel? AudioConferencing { get; set; }

    [JsonPropertyName("broadcastSettings")]
    public BroadcastMeetingSettingsModel? BroadcastSettings { get; set; }

    [JsonPropertyName("chatInfo")]
    public ChatInfoModel? ChatInfo { get; set; }

    [JsonPropertyName("creationDateTime")]
    public DateTime? CreationDateTime { get; set; }

    [JsonPropertyName("endDateTime")]
    public DateTime? EndDateTime { get; set; }

    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("isBroadcast")]
    public bool? IsBroadcast { get; set; }

    [JsonPropertyName("isEntryExitAnnounced")]
    public bool? IsEntryExitAnnounced { get; set; }

    [JsonPropertyName("joinInformation")]
    public ItemBodyModel? JoinInformation { get; set; }

    [JsonPropertyName("joinMeetingIdSettings")]
    public JoinMeetingIdSettingsModel? JoinMeetingIdSettings { get; set; }

    [JsonPropertyName("joinWebUrl")]
    public string? JoinWebUrl { get; set; }

    [JsonPropertyName("lobbyBypassSettings")]
    public LobbyBypassSettingsModel? LobbyBypassSettings { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("participants")]
    public MeetingParticipantsModel? Participants { get; set; }

    [JsonPropertyName("recordAutomatically")]
    public bool? RecordAutomatically { get; set; }

    [JsonPropertyName("recordings")]
    public List<CallRecordingModel>? Recordings { get; set; }

    [JsonPropertyName("shareMeetingChatHistoryDefault")]
    public OnlineMeetingShareMeetingChatHistoryDefaultConstant? ShareMeetingChatHistoryDefault { get; set; }

    [JsonPropertyName("startDateTime")]
    public DateTime? StartDateTime { get; set; }

    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    [JsonPropertyName("transcripts")]
    public List<CallTranscriptModel>? Transcripts { get; set; }

    [JsonPropertyName("videoTeleconferenceId")]
    public string? VideoTeleconferenceId { get; set; }

    [JsonPropertyName("watermarkProtection")]
    public WatermarkProtectionValuesModel? WatermarkProtection { get; set; }
}
