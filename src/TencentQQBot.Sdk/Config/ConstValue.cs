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
    public const string GetCureenUser = "/users/@me";

}
