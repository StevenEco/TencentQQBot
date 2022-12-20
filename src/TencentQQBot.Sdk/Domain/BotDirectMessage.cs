using System.Text.Json.Serialization;

namespace TencentQQBot.Sdk.Domain;
/// <summary>
/// 私信
/// </summary>
public class BotDirectMessage
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
    /// 消息创建时间
    /// </summary>
    [JsonPropertyName("create_time"), JsonConverter(typeof(DateTimeToStringTimestamp))]
    public DateTime CreateTime { get; set; }
}
