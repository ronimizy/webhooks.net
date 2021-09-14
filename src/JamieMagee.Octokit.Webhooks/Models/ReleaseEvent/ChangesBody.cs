﻿namespace JamieMagee.Octokit.Webhooks.Models.ReleaseEvent
{
    using System.Text.Json.Serialization;

    public sealed record ChangesBody
    {
        [JsonPropertyName("from")]
        public string From { get; init; } = null!;
    };
}