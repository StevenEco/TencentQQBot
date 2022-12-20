using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TencentQQBot.Sdk.Domain;
public class BotAudioControl
{
    /// <summary>
    /// 音频数据的 url status 为 0 时传
    /// </summary>
    [JsonPropertyName("audio_url")]
    public string? AudioUrl { get; set; }
    /// <summary>
    /// 状态文本（比如：简单爱-周杰伦），可选，status 为 0 时传，其他操作不传
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
    [JsonPropertyName("status")]
    public BotAudioStatus Status { get; set; } = 0;
}
public class BotAudioAction
{
    /// <summary>
    /// 音频数据的 url status 为 0 时传
    /// </summary>
    [JsonPropertyName("audio_url")]
    public string? AudioUrl { get; set; }
    /// <summary>
    /// 状态文本（比如：简单爱-周杰伦），可选，status 为 0 时传，其他操作不传
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
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
}

public enum BotAudioStatus
{
    START = 0,
    PAUSE = 1,
    RESUME = 2,
    STOP = 3
}