﻿namespace Makabaka.API
{
	/// <summary>
	/// 设置群聊机器人请求参数
	/// </summary>
	/// <param name="GroupId">群号</param>
	/// <param name="BotId">机器人 ID</param>
	/// <param name="Enable">是否启用</param>
	public record class SetGroupBotRequestParams(
		ulong GroupId,
		ulong BotId,
		uint Enable
		)
	{
	}
}
