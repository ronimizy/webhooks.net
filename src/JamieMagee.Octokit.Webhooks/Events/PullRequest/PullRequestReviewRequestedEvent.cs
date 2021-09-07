﻿namespace Octokit.Webhooks.Events.PullRequest
{
    using System.Text.Json.Serialization;
    using Models;

    public class PullRequestReviewRequestedEvent : PullRequestEvent
    {
        [JsonPropertyName("action")] public override string Action => "review_requested";

        [JsonPropertyName("requested_reviewer")]
        public User? RequestedReviewer { get; set; }

        [JsonPropertyName("requested_team")] public Team? RequestedTeam { get; set; }
    }
}