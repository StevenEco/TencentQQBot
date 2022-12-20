using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TencentQQBot.Sdk.Domain;
public class BotMessage
{
    /// <summary>
    /// 消息id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = "";
    /// <summary>
    /// 子频道 id
    /// </summary>
    [JsonPropertyName("channel_id")]
    public string ChannelId { get; set; } = "";
    /// <summary>
    /// 频道 id
    /// </summary>
    [JsonPropertyName("guild_id")]
    public string GuildId { get; set; } = "";
    /// <summary>
    /// 消息内容
    /// </summary>
    [JsonPropertyName("content")]
    public string Content { get; set; } = "";
    /// <summary>
    /// 是否 @全员消息
    /// </summary>
    [JsonPropertyName("mention_everyone")]
    public bool MentionEveryone { get; set; }
    /// <summary>
    /// 消息创建时间
    /// </summary>
    [JsonPropertyName("timestamp"), JsonConverter(typeof(DateTimeToStringTimestamp))]
    public DateTime CreateTime { get; set; }
    /// <summary>
    /// 消息编辑时间
    /// </summary>
    [JsonPropertyName("edited_timestamp"), JsonConverter(typeof(DateTimeToStringTimestamp))]
    public DateTime EditedTime { get; set; }
    /// <summary>
    /// 消息创建者
    /// </summary>
    [JsonPropertyName("author")]
    public BotUser Author { get; set; } = new();

    /// <summary>
    /// 附件(可多个)
    /// </summary>
    [JsonPropertyName("attachments")]
    public List<BotMessageAttachment>? Attachments { get; set; }
    /// <summary>
    /// embed
    /// </summary>
    [JsonPropertyName("embeds")]
    public List<BotMessageEmbed>? Embeds { get; set; }
    /// <summary>
    /// 消息中@的人
    /// </summary>
    [JsonPropertyName("mentions")]
    public List<BotUser>? Mentions { get; set; }
    /// <summary>
    /// 消息创建者的member信息
    /// </summary>
    [JsonPropertyName("member")]
    public BotMember Member { get; set; } = new();
    /// <summary>
    /// ark消息
    /// </summary>
    [JsonPropertyName("ark")]
    public BotMessageArk? Ark { get; set; }

    /// <summary>    
    /// 用于消息间的排序，seq 在同一子频道中按从先到后的顺序递增
    /// ，不同的子频道之前消息无法排序。
    /// (目前只在消息事件中有值，后续废弃)
    /// </summary>
    [JsonPropertyName("seq")]
    public int Seq { get; set; }

    /// <summary>
    /// 子频道消息 seq，用于消息间的排序，seq 在同一子频道中按
    /// 从先到后的顺序递增，不同的子频道之前消息无法排序
    /// </summary>
    [JsonPropertyName("seq_in_channel")]
    public string? SeqInChannel { get; set; }
    /// <summary>
    /// 引用消息对象
    /// </summary>
    [JsonPropertyName("message_reference")]
    public BotMessageReference? MessageReference { get; set; }

}
public class BotMessageSendRequest
{
    /// <summary>
    /// 消息内容，文本内容，支持内嵌格式
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }
    /// <summary>
    /// embed 消息，一种特殊的 ark
    /// </summary>
    [JsonPropertyName("embed")]
    public BotMessageEmbed? Embed { get; set; }
    /// <summary>
    /// ark消息
    /// </summary>
    [JsonPropertyName("ark")]
    public BotMessageArk? Ark { get; set; }
    /// <summary>
    /// 图片 url 地址
    /// </summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }
    /// <summary>
    /// 要回复的消息 id。带了 msg_id 视为被动回复消息，否则视为主动推送消息
    /// </summary>
    [JsonPropertyName("msg_id")]
    public string? MessageId { get; set; }
    /// <summary>
    /// 引用消息对象
    /// </summary>
    [JsonPropertyName("message_reference")]
    public BotMessageReference? MessageReference { get; set; }
}
public class BotMessageEmbed
{
    /// <summary>
    /// 标题
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
    /// <summary>
    /// 描述
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    /// <summary>
    /// 弹窗内容
    /// </summary>
    [JsonPropertyName("prompt")]
    public string? Prompt { get; set; }
    /// <summary>
    /// 消息创建时间
    /// </summary>
    [JsonPropertyName("timestamp"), JsonConverter(typeof(DateTimeToStringTimestamp))]
    public DateTime CreateTime { get; set; }
    [JsonPropertyName("fields")]
    public List<BotMessageEmbedField>? Fields { get; set; }
}
public class BotMessageEmbedField
{
    /// <summary>
    /// 字段名
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    /// <summary>
    /// 字段值
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
public class BotMessageAttachment
{
    /// <summary>
    /// 附件下载地址
    /// </summary>
    public string Url { get; set; } = string.Empty;
}
public class BotMessageArk
{
    /// <summary>
    /// ark 模板 id（需要先申请）
    /// </summary>
    [JsonPropertyName("template_id")]
    public int TemplateId { get; set; }
    /// <summary>
    /// kv 值列表
    /// </summary>
    [JsonPropertyName("kv")]
    public List<BotMessageArkKv>? BotMessageArkKvs { get; set; }

}
public class BotMessageArkKv
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
    /// <summary>
    /// ark obj 类型的列表
    /// </summary>
    [JsonPropertyName("obj")]
    public List<BotMessageArkObj>? BotBotMessageArkObjs { get; set; }

}
public class BotMessageArkObj
{
    /// <summary>
    /// ark objkv 列表
    /// </summary>
    [JsonPropertyName("obj_kv")]
    public List<BotMessageArkKv>? ObjKvs { get; set; }
}
public class BotMessageArkObjKv
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
public class BotMessageReference
{
    /// <summary>
    /// 是 ｜ 需要引用回复的消息 ID
    /// </summary>
    [JsonPropertyName("message_id")]
    public string? MessageId { get; set; }
    /// <summary>
    /// 否 ｜ 是否忽略获取引用消息详情错误，默认否
    /// </summary>
    [JsonPropertyName("ignore_get_message_error")]
    public bool IgnoreGetMessageError { get; set; }
}
public class BotMessageAudited
{
    /// <summary>
    /// 消息审核Id
    /// </summary>
    [JsonPropertyName("audit_id")]
    public string AuditId { get; set; } = string.Empty;
    /// <summary>
    /// 被审核的消息Id
    /// <para>只有审核通过事件才会有值</para>
    /// </summary>
    [JsonPropertyName("message_id")]
    public string? MessageId { get; set; }
    /// <summary>
    /// 频道Id
    /// </summary>
    [JsonPropertyName("guild_id")]
    public string GuildId { get; set; } = string.Empty;
    /// <summary>
    /// 子频道Id
    /// </summary>
    [JsonPropertyName("channel_id")]
    public string ChannelId { get; set; } = string.Empty;
    /// <summary>
    /// 消息审核时间
    /// </summary>
    [JsonPropertyName("audit_time"), JsonConverter(typeof(DateTimeToStringTimestamp))]
    public DateTime AuditTime { get; set; }
    /// <summary>
    /// 消息创建时间
    /// </summary>
    [JsonPropertyName("create_time"), JsonConverter(typeof(DateTimeToStringTimestamp))]
    public DateTime CreateTime { get; set; }
    /// <summary>
    /// 子频道消息 seq，用于消息间的排序，
    /// seq 在同一子频道中按从先到后的顺序递增，不同的子频道之前消息无法排序
    /// </summary>
    [JsonPropertyName("seq_in_channel")]
    public string ?SeqInChannel { get; set; }
}