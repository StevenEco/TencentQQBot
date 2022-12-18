using TencentQQBot.Sdk.Config;

namespace TencentQQBot.Sdk;
public class Token
{
    private string? accessToken;
    private UInt64 appId;
    private string? type;

    public string? Type { get => type; set => type = value; }
    public UInt64 AppId { get => appId; set => appId = value; }
    public string? AccessToken { get => accessToken; set => accessToken = value; }

    public Token()
    {

    }
    public Token(UInt64 appId, string accessToken, string type)
    {
        this.appId = appId;
        this.accessToken = accessToken;
        this.Type = type;
    }
    public Token BotToken()
    {
        return this;
    }
    public Token BotToken(UInt64 appId, string accessToken)
    {
        return new Token(appId, accessToken, ConstValue.TypeBot);
    }
    public Token UserToken(UInt64 appId, string accessToken)
    {
        return new Token(appId, accessToken, ConstValue.TypeNormal);
    }
    public string? GetAccessToken()
    {
        if (string.IsNullOrEmpty(type)&&type == ConstValue.TypeNormal)
        {
            return accessToken;
        }
        return string.Format("{}.{}", appId, accessToken);
    }
    //todo add read from config
    public Token ReadFromConfig(string configPath)
    {
        return default;
    }
}