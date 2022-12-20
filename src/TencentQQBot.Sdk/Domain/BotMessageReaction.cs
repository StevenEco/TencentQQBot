using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TencentQQBot.Sdk.Domain;
/// <summary>
/// 表情表态
/// </summary>
public class MessageReaction
{
    /// <summary>
    /// 用户Id
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;
    /// <summary>
    /// 频道Id
    /// </summary>
    [JsonPropertyName("guild_id")]
    public string GuildId { get; set; } = string.Empty;
    /// <summary>
    /// 子频道Id
    /// </summary>
    [JsonPropertyName("channel_id")]
    public string? ChannelId { get; set; }
    /// <summary>
    /// 表态对象
    /// </summary>
    [JsonPropertyName("target")]
    public ReactionTarget? Target { get; set; }
    /// <summary>
    /// 表态所用表情
    /// </summary>
    [JsonPropertyName("emoji")]
    public BotEmoji? Emoji { get; set; }
}
/// <summary>
/// 表态对象
/// </summary>
public class ReactionTarget
{
    /// <summary>
    /// 表态对象ID
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    /// <summary>
    /// 表态对象类型
    /// </summary>
    [JsonPropertyName("type")]
    public ReactionTargetType Type { get; set; }
}
/// <summary>
/// 表态对象类型
/// </summary>
public enum ReactionTargetType
{
    /// <summary>
    /// 消息
    /// </summary>
    Message = 0,
    /// <summary>
    /// 帖子
    /// </summary>
    Post,
    /// <summary>
    /// 评论
    /// </summary>
    Comment,
    /// <summary>
    /// 回复
    /// </summary>
    Reply,
}