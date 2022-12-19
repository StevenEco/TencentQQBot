using TencentQQBot.Sdk.Config;

namespace TencentQQBot.Sdk.Domain;
public class BotToken
{
    private string? accessToken;
    private ulong appId;
    private string? type;
    private string? secret;
    private string? token;

    public string? Type { get => type; set => type = value; }
    public ulong AppId { get => appId; set => appId = value; }
    /// <summary>
    /// 机器人Token
    /// </summary>
    public string? Token { get => token; set => token = value; }
    /// <summary>
    /// 机器人密钥
    /// </summary>
    public string? Secret { get => secret; set => secret = value; }
    public string? AccessToken { get => accessToken; set => accessToken = value; }

    public BotToken()
    {

    }
    public BotToken(ulong appId, string accessToken, string type)
    {
        this.appId = appId;
        this.accessToken = accessToken;
        Type = type;
    }


    public BotToken GetBotToken()
    {
        return this;
    }
    public BotToken GetBotToken(ulong appId, string accessToken)
    {
        return new BotToken(appId, accessToken, ConstValue.TypeBot);
    }
    public BotToken GetUserToken(ulong appId, string accessToken)
    {
        return new BotToken(appId, accessToken, ConstValue.TypeNormal);
    }
    public string? GetAccessToken()
    {
        if (string.IsNullOrEmpty(type) && type == ConstValue.TypeNormal)
        {
            return accessToken;
        }
        return string.Format("{}.{}", appId, accessToken);
    }
    //todo add read from config
    public BotToken ReadFromConfig(string configPath)
    {
        return default;
    }
}