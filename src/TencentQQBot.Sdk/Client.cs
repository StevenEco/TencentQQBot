namespace TencentQQBot.Sdk;

//    """``Client` 是一个用于与 QQ频道机器人 Websocket 和 API 交互的类。"""

//    def __init__(
//        self,
//intents: Intents,
//        timeout: int = 5,
//        is_sandbox= False,
//        log_config: Union[str, dict] = None,
//        log_format: str = None,
//        log_level: int = None,
//        bot_log: Union[bool, None] = True,
//        ext_handlers: Union[dict, List[dict], bool] = True,
//    ):
//        """
//        Args:
//          intents (Intents): 通道：机器人需要注册的通道事件code，通过Intents提供的方法获取。
//          timeout (int): 机器人 HTTP 请求的超时时间。. Defaults to 5
//          is_sandbox: 是否使用沙盒环境。. Defaults to False

//          log_config: 日志配置，可以为dict或.json/.yaml文件路径，会从文件中读取(logging.config.dictConfig)。Default to None（不做更改）
//          log_format: 控制台输出格式(logging.basicConfig(format=))。Default to None（不做更改）
//          log_level: 控制台输出level。Default to None(不做更改),
//          bot_log: bot_log: bot_log: 是否启用bot日志 True/启用 None/禁用拓展 False/禁用拓展+控制台输出
//          ext_handlers: ext_handlers: 额外的handler，格式参考 logging.DEFAULT_FILE_HANDLER。Default to True(使用默认追加handler)
//        """

public enum LogConfigFileType
{
	xml,
	json,
	yaml,
	ini
}
public enum LogLevel
{
	None,
	Info,
	Warn,
	Error
}
public class Client
{
	public Client()
	{

	}
	//todo need add ext
	public Client(int timeout,bool isSandBox,(string,LogConfigFileType) logConfigPath,LogLevel logLevel)
	{

	}



}
