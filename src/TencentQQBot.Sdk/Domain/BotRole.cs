using System.Drawing;
using System.Text.Json.Serialization;

namespace TencentQQBot.Sdk.Domain;
/// <summary>
/// 身份组对象
/// </summary>
public class BotRole
{
    /// <summary>
    /// 身份组ID, 默认值可参考 <see cref="DefaultRoles"/>
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;
    /// <summary>
    /// 身份组名称
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    /// <summary>
    /// 身份组颜色
    /// </summary>
    [JsonPropertyName("color"), JsonConverter(typeof(ColorToUint32Converter))]
    public Color Color { get; set; }
    /// <summary>
    /// 该身份组是否在成员列表中单独展示
    /// </summary>
    [JsonPropertyName("hoist"), JsonConverter(typeof(BoolToInt32Converter))]
    public bool Hoist { get; set; }
    /// <summary>
    /// 该身份组的人数
    /// </summary>
    [JsonPropertyName("number")]
    public uint Number { get; set; }
    /// <summary>
    /// 成员上限
    /// </summary>
    [JsonPropertyName("member_limit")]
    public uint MemberLimit { get; set; }

    private readonly Dictionary<string, string> defaultRoleIDs = new Dictionary<string, string>()
    {
        { "1","普通成员" },
        { "2" , "管理员" },
        { "4" , "频道主" },
        { "5" , "子频道管理员" }
    };
    [JsonIgnore]
    public Dictionary<string, string> DefaultRoleIDs { get=>defaultRoleIDs; }

    public string GetRoleName()
    {
        return defaultRoleIDs[this.Id];
    }
}