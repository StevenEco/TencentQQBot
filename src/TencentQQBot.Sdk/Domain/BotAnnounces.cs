using System.Text.Json.Serialization;

namespace TencentQQBot.Sdk.Domain;
public class BotAnnounces
{
    /// <summary>
    /// 子频道 id
    /// </summary>
    [JsonPropertyName("channel_id")]
    public string? ChannelId { get; set; }
    /// <summary>
    /// 频道 id
    /// </summary>
    [JsonPropertyName("guild_id")]
    public string? GuildId { get; set; }
    /// <summary>
    /// 消息 id
    /// </summary>
    [JsonPropertyName("message_id")]
    public string? MessageID { get; set; }

    /// <summary>
    /// 推荐子频道列表
    /// </summary>
    [JsonPropertyName("recommend_channels")]
    public List<BotRecommendChannel>? RecommendChannels { get; set; }
    /// <summary>
    /// 推荐类别 0:成员公告; 1:欢迎公告
    /// </summary>
    [JsonPropertyName("announce_type")]
    public BotAnnouncesType AnnounceType { get; set; }

}
public class BotRecommendChannel
{

    /// <summary>
    /// 子频道 id
    /// </summary>
    [JsonPropertyName("channel_id")]
    public string? ChannelId { get; set; }
    /// <summary>
    /// 推荐语
    /// </summary>
    [JsonPropertyName("introduce")]
    public string? Introduce { get; set; }
}

public enum BotAnnouncesType
{
    MemberAnnounce = 0,
    WelcomeAnnounce = 1
}
