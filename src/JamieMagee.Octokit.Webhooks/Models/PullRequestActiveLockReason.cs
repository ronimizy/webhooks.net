﻿namespace Octokit.Webhooks.Models
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PullRequestActiveLockReason
    {
        [EnumMember(Value = "Resolved")] Resolved,
        [EnumMember(Value = "off-topic")] OffTopic,
        [EnumMember(Value = "too heated")] TooHeated,
        [EnumMember(Value = "spam")] Spam
    }
}