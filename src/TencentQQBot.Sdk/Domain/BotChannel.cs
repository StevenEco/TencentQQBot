﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TencentQQBot.Sdk.Domain;
/// <summary>
/// 子频道对象
/// </summary>
public class BotChannel
{
    /// <summary>
    /// 子频道id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;
    /// <summary>
    /// 频道id
    /// </summary>
    [JsonPropertyName("guild_id")]
    public string GuildId { get; set; } = string.Empty;
    /// <summary>
    /// 子频道名称
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    /// <summary>
    /// 子频道类型
    /// </summary>
    [JsonPropertyName("type")]
    public ChannelType Type { get; set; }
    /// <summary>
    /// 子频道子类型
    /// </summary>
    [JsonPropertyName("sub_type")]
    public ChannelSubType? SubType { get; set; }
    /// <summary>
    /// 频道位置排序，非必填，但不能够和其他子频道的值重复
    /// </summary>
    [JsonPropertyName("position")]
    public int Possition { get; set; }
    /// <summary>
    /// 分组Id
    /// </summary>
    [JsonPropertyName("parent_id")]
    public string? ParentId { get; set; }
    /// <summary>
    /// 创建人Id
    /// </summary>
    [JsonPropertyName("owner_id")]
    public string? OwerId { get; set; }
    /// <summary>
    /// 子频道私密类型
    /// </summary>
    [JsonPropertyName("private_type")]
    public ChannelPrivateType PrivateType { get; set; }
    /// <summary>
    /// 子频道私密类型成员Id
    /// </summary>
    [JsonPropertyName("private_user_ids")]
    public List<string>? PrivateUserIds { get; set; }
    /// <summary>
    /// 子频道发言权限
    /// </summary>
    [JsonPropertyName("speak_permission")]
    public ChannelSpeakPermission SpeakPermission { get; set; }
    /// <summary>
    /// 用于标识应用子频道应用类型，仅应用子频道时会使用该字段
    /// <para>具体定义请参考 <see href="https://bot.q.qq.com/wiki/develop/api/openapi/channel/model.html#应用子频道的应用类型">应用子频道的应用类型</see></para>
    /// </summary>
    [JsonPropertyName("application_id")]
    public string? ApplicationId { get; set; }
    /// <summary>
    /// 应用子频道类型列表
    /// </summary>
    public static Dictionary<string, string> AppType => new()
        {
            { "1000000", "王者开黑大厅" },
            { "1000001", "互动小游戏" },
            { "1000010", "腾讯投票" },
            { "1000051", "飞车开黑大厅" },
            { "1000050", "日程提醒" },
            { "1000070", "CoDM开黑大厅" },
            { "1010000", "和平精英开黑大厅" },
        };
}
/// <summary>
/// 子频道类型
/// </summary>
public enum ChannelType
{
    /// <summary>
    /// 文字子频道
    /// </summary>
    文字 = 0,
    /// <summary>
    /// 保留，不可用
    /// </summary>
    Reserve1 = 1,
    /// <summary>
    /// 语音子频道
    /// </summary>
    语音 = 2,
    /// <summary>
    /// 保留，不可用
    /// </summary>
    Reserve2 = 3,
    /// <summary>
    /// 子频道分组
    /// </summary>
    分组 = 4,
    /// <summary>
    /// 直播子频道
    /// </summary>
    直播 = 10005,
    /// <summary>
    /// 应用子频道
    /// </summary>
    应用 = 10006,
    /// <summary>
    /// 论坛子频道
    /// </summary>
    论坛 = 10007
}
/// <summary>
/// 子频道子类型(目前只有文字子频道有)
/// </summary>
public enum ChannelSubType
{
    /// <summary>
    /// 闲聊
    /// </summary>
    闲聊,
    /// <summary>
    /// 公告
    /// </summary>
    公告,
    /// <summary>
    /// 攻略
    /// </summary>
    攻略,
    /// <summary>
    /// 开黑
    /// </summary>
    开黑
}
/// <summary>
/// 子频道私密类型
/// </summary>
public enum ChannelPrivateType
{
    /// <summary>
    /// 公开频道
    /// </summary>
    Public,
    /// <summary>
    /// 群主和管理员可见
    /// </summary>
    Admin,
    /// <summary>
    /// 群主和管理员+指定成员可见
    /// </summary>
    Members
}
/// <summary>
/// 子频道发言权限
/// </summary>
public enum ChannelSpeakPermission
{
    /// <summary>
    /// 无效类型
    /// </summary>
    Null,
    /// <summary>
    /// 所有人
    /// </summary>
    Everyone,
    /// <summary>
    /// 群主和管理员+指定成员
    /// </summary>
    Members
}