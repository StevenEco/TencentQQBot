using System.Text.Json.Serialization;

namespace TencentQQBot.Sdk.Domain;
/// <summary>
/// 精华消息
/// </summary>
public class BotPinsMessage
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
    /// 消息 ID 列表
    /// </summary>
    [JsonPropertyName("message_ids")]
    public List<string>? MessageIds { get; set; }
}