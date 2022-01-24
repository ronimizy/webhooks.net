﻿namespace Octokit.Webhooks.Models.CheckRunEvent
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using JetBrains.Annotations;

    [PublicAPI]
    public sealed record CheckRun
    {
        [JsonPropertyName("id")]
        public long Id { get; init; }

        [JsonPropertyName("node_id")]
        public string NodeId { get; init; } = null!;

        [JsonPropertyName("head_sha")]
        public string HeadSha { get; init; } = null!;

        [JsonPropertyName("external_id")]
        public string ExternalId { get; init; } = null!;

        [JsonPropertyName("url")]
        public string Url { get; init; } = null!;

        [JsonPropertyName("html_url")]
        public string HtmlUrl { get; init; } = null!;

        [JsonPropertyName("details_url")]
        public string DetailsUrl { get; init; } = null!;

        [JsonPropertyName("status")]
        public CheckRunStatus Status { get; init; }

        [JsonPropertyName("conclusion")]
        public CheckRunConclusion? Conclusion { get; init; }

        [JsonPropertyName("started_at")]
        public string StartedAt { get; init; } = null!;

        [JsonPropertyName("completed_at")]
        public string CompletedAt { get; init; } = null!;

        [JsonPropertyName("output")]
        public CheckRunOutput Output { get; init; } = null!;

        [JsonPropertyName("name")]
        public string Name { get; init; } = null!;

        [JsonPropertyName("check_suite")]
        public CheckSuite CheckSuite { get; init; } = null!;

        [JsonPropertyName("app")]
        public App App { get; init; } = null!;

        [JsonPropertyName("pull_requests")]
        public IEnumerable<CheckRunPullRequest> PullRequests { get; init; } = null!;
    }
}