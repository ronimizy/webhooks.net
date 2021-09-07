﻿namespace Octokit.Webhooks.Models
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TeamPrivacy
    {
        [EnumMember(Value = "Open")] Open,
        [EnumMember(Value = "Closed")] Closed,
        [EnumMember(Value = "Secret")] Secret
    }
}