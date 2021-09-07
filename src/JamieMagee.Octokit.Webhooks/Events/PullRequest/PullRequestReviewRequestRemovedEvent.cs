﻿namespace Octokit.Webhooks.Events.PullRequest
{
    using System.Text.Json.Serialization;
    using Models;

    public class PullRequestReviewRequestRemovedEvent : PullRequestEvent
    {
        [JsonPropertyName("action")] public override string Action => "review_request_removed";

        [JsonPropertyName("requested_reviewer")]
        public User? RequestedReviewer { get; set; }

        [JsonPropertyName("requested_team")] public Team? RequestedTeam { get; set; }
    }
}