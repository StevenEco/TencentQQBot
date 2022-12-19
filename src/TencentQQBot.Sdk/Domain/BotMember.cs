using System.Text.Json.Serialization;

namespace TencentQQBot.Sdk.Domain;
public class BotMember
{
    /// <summary>
    /// 频道id,不一定有
    /// </summary>
    [JsonPropertyName("guild_id")]
    public string GuildId { get; set; } = string.Empty;
    /// <summary>
    /// 用户基础信息，来自QQ资料，只有成员相关接口中会填充此信息
    /// </summary>
    [JsonPropertyName("user")]
    public BotUser? User { get; set; }
    /// <summary>
    /// 用户在频道内的昵称(默认为空)
    /// </summary>
    [JsonPropertyName("nick")]
    public string? Nick { get; set; }
    /// <summary>
    /// 用户在频道内的身份组ID, 默认值可参考DefaultRoles
    /// </summary>
    [JsonPropertyName("roles")]
    public List<string> Roles { get; set; } = new() { "1" };
    /// <summary>
    /// 用户加入频道的时间 ISO8601 timestamp
    /// </summary>
    [JsonPropertyName("joined_at"), JsonConverter(typeof(DateTimeToStringTimestamp))]
    public DateTime? JoinedAt { get; set; }
}
