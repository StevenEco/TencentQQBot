﻿namespace TencentQQBot.Sdk.Domain;
/// <summary>
/// 用户对象(User) 用户对象中所涉及的 ID 类数据，都仅在机器人场景流通，与真实的 ID 无关，请不要理解为真实的 ID。
/// </summary>
public class Bot_User
{
    /// <summary>
    /// 用户Id
    /// </summary>
    public string? Id { get; set; }
    /// <summary>
    /// 用户名
    /// </summary>
    public string? Username { get; set; }
    /// <summary>
    /// 用户头像地址
    /// </summary>
    public string? Avatar { get; set; }
    /// <summary>
    /// 是否为机器人
    /// </summary>
    public bool Bot { get; set; }
    /// <summary>
    /// 特殊关联应用的 openid，需要特殊申请并配置后才会返回。如需申请，请联系平台运营人员。
    /// </summary>
    public string? UnionOpenid { get; set; }
    /// <summary>
    /// 机器人关联的互联应用的用户信息，与 union_openid 关联的应用是同一个。如需申请，请联系平台运营人员。
    /// </summary>
    public string? UnionUserAccount { get; set; }
}
