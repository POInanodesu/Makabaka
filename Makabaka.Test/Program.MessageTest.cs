﻿using Makabaka.Events;
using Makabaka.Messages;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace Makabaka.Test
{
	internal partial class Program
	{
		private static Task OnPrivateMessage(object sender, PrivateMessageEventArgs e)
		{
			return e.Message.ToString() switch
			{
				"联系人测试" => e.ReplyAsync([new ContactSegment(ContactType.Qq, e.Sender.UserId)]),
				_ => HandleMessageAsync(e.Message, e.MessageId, e.Context, e),
			};
		}

		private static async Task OnGroupMessage(object sender, GroupMessageEventArgs e)
		{
			switch (e.Message.ToString())
			{
				case "At测试":
					await e.ReplyAsync([new AtSegment(e.Sender!.UserId)]);
					break;
				case "联系人测试":
					await e.ReplyAsync([new ContactSegment(ContactType.Group, e.GroupId)]);
					break;
				case "群禁言测试":
					await e.Context.MuteGroupAsync(e.GroupId, true);
					await Task.Delay(3000);
					await e.Context.MuteGroupAsync(e.GroupId, false);
					break;
				case "设置群名测试":
					await e.Context.SetGroupNameAsync(e.GroupId, "测试群名");
					break;
				case "退群测试":
					await e.Context.LeaveGroupAsync(e.GroupId);
					break;
				default:
					await HandleMessageAsync(e.Message, e.MessageId, e.Context, e);
					break;
			}
		}

		private static readonly JsonSerializerOptions _jsonSerializerDisplayOptions = new()
		{
			WriteIndented = true,
			PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
			Converters =
			{
				new JsonStringEnumConverter(JsonNamingPolicy.SnakeCaseLower)
			},
			Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
		};

		private static async Task HandleMessageAsync(Message message, long messageId, IBotContext botContext, IMessageHandler reply)
		{
			switch (message.ToString())
			{
				/* ===== 段消息测试 ===== */

				case "骰子测试":
					await reply.ReplyAsync([new DiceSegment()]);
					return;
				case "表情测试":
					await reply.ReplyAsync([new FaceSegment("14")]);
					return;
				case "文本测试":
					await reply.ReplyAsync([new TextSegment("测试")]);
					return;
				case "转发测试":

					return;
				case "商城表情测试":
					var emojiId = "f9af2410431e5ee59d7087ada014cdb3";
					var keys = await botContext.FetchMarketFaceKeyAsync([emojiId]);
					if (keys.Data == null)
					{
						await reply.ReplyAsync([new TextSegment("获取商城表情密钥失败")]);
						return;
					}
					if (keys.Data.Length == 0)
					{
						await reply.ReplyAsync([new TextSegment("获取的商城表情密钥为空")]);
						return;
					}
					await reply.ReplyAsync([new MarketFaceSegment(
						"https://gxh.vip.qq.com/club/item/parcel/item/f9/f9af2410431e5ee59d7087ada014cdb3/raw300.gif",
						235308,
						emojiId,
						keys.Data.First(),
						"[测试]"
						)]);
					return;
				case "戳一戳测试":
					await reply.ReplyAsync([new PokeSegment("1", "-1")]);
					return;
				case "回复测试":
					await reply.ReplyAsync([new ReplySegment(messageId), new TextSegment("回复测试")]);
					return;
				case "图片测试":
					await reply.ReplyAsync([ImageSegment.FromFile("test.png")]);
					return;

				/* ===== API 测试 ===== */

				case "撤回消息测试":
					{
						var data = (await reply.ReplyAsync([new TextSegment("撤回测试")])).Result;
						await Task.Delay(3000);
						await botContext.RevokeMessageAsync(data.MessageId);
					}
					return;
				case "获取消息测试":
					{
						var data = (await botContext.GetMessageAsync(messageId)).Result;
						await reply.ReplyAsync([new TextSegment(JsonSerializer.Serialize(data, _jsonSerializerDisplayOptions))]);
					}
					return;
				case "获取登录信息测试":
					{
						var data = (await botContext.GetLoginInfoAsync()).Result;
						await reply.ReplyAsync([new TextSegment(JsonSerializer.Serialize(data, _jsonSerializerDisplayOptions))]);
					}
					return;
				case "获取好友列表测试":
					{
						var friends = (await botContext.GetFriendListAsync()).Result;
						var sb = new StringBuilder();
						foreach (var friend in friends)
						{
							sb.Append('[')
								.Append(friend.UserId)
								.Append("] ");
							if (string.IsNullOrEmpty(friend.Remark))
							{
								sb.AppendLine(friend.Nickname);
							}
							else
							{
								sb.AppendLine(friend.Remark);
							}
						}
						await reply.ReplyAsync([new TextSegment(sb.ToString())]);
					}
					return;

				default:
					break;
			}

			var match = GetStrangerInfoTestRegex().Match(message.ToString());
			if (match.Success)
			{
				var qq = long.Parse(match.Groups["qq"].Value);
				var data = (await botContext.GetStrangerInfoAsync(qq)).Result;
				await reply.ReplyAsync([new TextSegment(JsonSerializer.Serialize(data, _jsonSerializerDisplayOptions))]);
				return;
			}

			match = GetGroupInfoTestRegex().Match(message.ToString());
			if (match.Success)
			{
				var qq = long.Parse(match.Groups["group"].Value);
				var data = (await botContext.GetGroupInfoAsync(qq)).Result;
				await reply.ReplyAsync([new TextSegment(JsonSerializer.Serialize(data, _jsonSerializerDisplayOptions))]);
				return;
			}
		}

		[GeneratedRegex(@"^获取陌生人信息测试 (?<qq>[0-9]+)$", RegexOptions.Compiled)]
		private static partial Regex GetStrangerInfoTestRegex();

		[GeneratedRegex(@"^获取群信息测试 (?<group>[0-9]+)$", RegexOptions.Compiled)]
		private static partial Regex GetGroupInfoTestRegex();
	}
}
