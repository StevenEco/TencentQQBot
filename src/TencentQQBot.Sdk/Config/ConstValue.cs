using System.Net;
using System.Text;

namespace TencentQQBot.Sdk.Config;
public class ConstValue
{
    public const string TypeBot = "Bot";
    public const string TypeNormal = "Bearer";
    public const string ApiProd = "https://api.sgroup.qq.com/";
    public const string ApiDev = "https://sandbox.api.sgroup.qq.com";
    }

public class ApiConstUrl
{
    /// <summary>
    /// 用于获取当前用户（机器人）详情。返回 User 对象。
    /// </summary>
    public string GetCureenUser()
    {
        return "/users/@me";
    }
    /// <summary>
    /// 用于获取当前用户（机器人）所加入的频道列表，支持分页。
    // 当 HTTP Authorization 中填入 Bot Token 是获取机器人的数据，
    // 填入 Bearer Token 则获取用户的数据
    /// </summary>
    /// <param name="beforeId">读此 guild id 之前的数据	before 设置时， 先反序，再分页</param>
    /// <param name="afterId">读此 guild id 之后的数据	after 和 before 同时设置时， after 参数无效</param>
    /// <param name="limit"></param>
    /// <returns>默认 100, 最大 100</returns>
    public string GetCureenUserChannel(string? beforeId,string? afterId,int? limit)
    {
        StringBuilder sb = new StringBuilder("/users/@me/guilds");
        return sb.ToString();
    }
}
