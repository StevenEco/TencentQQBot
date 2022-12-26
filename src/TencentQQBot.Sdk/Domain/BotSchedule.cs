using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TencentQQBot.Sdk.Domain;
public class BotSchedule
{
    /// <summary>
    /// 日程 id
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    /// <summary>
    /// 日程名称
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    /// <summary>
    /// 日程描述
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    /// <summary>
    /// 日程开始时间戳(ms)
    /// <para>必须大于当前时间</para>
    /// </summary>
    [JsonPropertyName("start_timestamp")]
    public string StartTimestamp { get; set; }
    /// <summary>
    /// 日程结束时间戳(ms)
    /// <para>必须大于开始时间</para>
    /// </summary>
    [JsonPropertyName("end_timestamp")]
    public string EndTimestamp { get; set; }
    /// <summary>
    /// 创建者
    /// </summary>
    [JsonPropertyName("creator")]
    public BotMember? Creator { get; set; }
    /// <summary>
    /// 日程开始时跳转到的子频道 id
    /// </summary>
    [JsonPropertyName("jump_channel_id")]
    public string? JumpChannelId { get; set; }
    /// <summary>
    /// 日程提醒类型
    /// </summary>
    [JsonPropertyName("remind_type"), JsonConverter(typeof(RemindTypeToStringNumberConverter))]
    public RemindType RemindType { get; set; }
}

/// <summary>
/// 日程提醒方式
/// </summary>
public enum RemindType
{
    /// <summary>
    /// 不提醒
    /// </summary>
    Never = 0,
    /// <summary>
    /// 开始时提醒
    /// </summary>
    OnStart = 1,
    /// <summary>
    /// 开始前5分钟提醒
    /// </summary>
    Early5Mins = 2,
    /// <summary>
    /// 开始前15分钟提醒
    /// </summary>
    Early15Mins = 3,
    /// <summary>
    /// 开始前30分钟提醒
    /// </summary>
    Early30Mins = 4,
    /// <summary>
    /// 开始前60分钟提醒
    /// </summary>
    Early60Mins = 5
}
