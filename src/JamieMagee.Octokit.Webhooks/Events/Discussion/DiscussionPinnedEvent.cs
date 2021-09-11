namespace JamieMagee.Octokit.Webhooks.Events.Discussion
{
    using System.Text.Json.Serialization;
    using JamieMagee.Octokit.Webhooks.Models;

    public sealed record DiscussionPinnedEvent : DiscussionEvent
    {
        [JsonPropertyName("action")]
        public override string Action => DiscussionAction.Pinned;
    }
}