<div align="center">

<img width="160" src="logo.jpg" alt="logo">

# Makabaka

一个基于 [OneBot-11标准](https://github.com/botuniverse/onebot-11) 的、适配于 [Lagrange.Onebot](https://github.com/LagrangeDev/Lagrange.Core#lagrangeonebot) 的、[C# .NET Standard 2.1](https://github.com/dotnet/dotnet) 的异步机器人开发框架。

</div>

## 说明

> [!WARNING]
> 目前正在重构 Makabaka 2.0，绝大部分代码都使用 [DI](https://www.nuget.org/packages/Microsoft.Extensions.DependencyInjection/) 进行了重构，因此调用逻辑与 1.x 差异较大。如果你从 1.x 迁移到 2.0 ，可能需要改动较多代码。

本项目将持续跟进 [Lagrange.Core](https://github.com/LagrangeDev/Lagrange.Core) 项目进度。由于 [Lagrange.Core](https://github.com/LagrangeDev/Lagrange.Core) 项目仍在开发当中，可能有部分功能暂未支持。  
如果对该项目有任何问题，欢迎在 [Issues](https://github.com/XeronOwO/Makabaka/issues) 中提出。  

## 安装
Makabaka 已发布到 [NuGet](https://www.nuget.org/packages/Makabaka "前往NuGet") ，可以通过NuGet包管理器搜索并安装到工程。  
或者，可以直接去 [Releases](https://github.com/XeronOwO/Makabaka/releases) 中下载 .nupkg 文件。 

## 已适配内容
<Details>
<Summary>消息类型</Summary>

| 消息类型          | 是否支持 |
| ---------------- | :-----: |
| [Text]           |    🟢    |
| [Face]           |    🟢    |
| [Image]          |    🟢    |
| [Record]         |    🟢    |
| [Video]          |    🟢    |
| [At]             |    🟢    |
| [Rps]            |    🟢    |
| [Dice]           |    🟢    |
| [Shake]          |    🟢    |
| [Poke]           |    🟢    |
| [Anonymous]      |    🟢    |
| [Share]          |    🟢    |
| [Contact]        |    🟢    |
| [Location]       |    🟢    |
| [Music]          |    🟢    |
| [Reply]          |    🟢    |
| [Forward]        |    🟢    |
| [Node]           |    🟢    |
| [Xml]            |    🟢    |
| [Json]           |    🟢    |

[Text]: https://github.com/botuniverse/onebot-11/blob/master/message/segment.md#qq-%E8%A1%A8%E6%83%85
[Record]: https://github.com/botuniverse/onebot-11/blob/master/message/segment.md#%E8%AF%AD%E9%9F%B3
[Face]: https://github.com/botuniverse/onebot-11/blob/master/message/segment.md#qq-%E8%A1%A8%E6%83%85
[Image]: https://github.com/botuniverse/onebot-11/blob/master/message/segment.md#%E5%9B%BE%E7%89%87
[Shake]: https://github.com/botuniverse/onebot-11/blob/master/message/segment.md#%E7%AA%97%E5%8F%A3%E6%8A%96%E5%8A%A8%E6%88%B3%E4%B8%80%E6%88%B3-
[Poke]: https://github.com/botuniverse/onebot-11/blob/master/message/segment.md#%E6%88%B3%E4%B8%80%E6%88%B3
[Anonymous]: https://github.com/botuniverse/onebot-11/blob/master/message/segment.md#%E5%8C%BF%E5%90%8D%E5%8F%91%E6%B6%88%E6%81%AF-
[Location]: https://github.com/botuniverse/onebot-11/blob/master/message/segment.md#%E4%BD%8D%E7%BD%AE
[Video]: https://github.com/botuniverse/onebot-11/blob/master/message/segment.md#%E7%9F%AD%E8%A7%86%E9%A2%91
[At]: https://github.com/botuniverse/onebot-11/blob/master/message/segment.md#%E6%9F%90%E4%BA%BA
[Rps]: https://github.com/botuniverse/onebot-11/blob/master/message/segment.md#%E7%8C%9C%E6%8B%B3%E9%AD%94%E6%B3%95%E8%A1%A8%E6%83%85
[Dice]: https://github.com/botuniverse/onebot-11/blob/master/message/segment.md#%E6%8E%B7%E9%AA%B0%E5%AD%90%E9%AD%94%E6%B3%95%E8%A1%A8%E6%83%85
[share]: https://github.com/botuniverse/onebot-11/blob/master/message/segment.md#%E9%93%BE%E6%8E%A5%E5%88%86%E4%BA%AB
[Music]: https://github.com/botuniverse/onebot-11/blob/master/message/segment.md#%E9%9F%B3%E4%B9%90%E5%88%86%E4%BA%AB-
[Contact]: https://github.com/botuniverse/onebot-11/blob/master/message/segment.md#%E6%8E%A8%E8%8D%90%E5%A5%BD%E5%8F%8B
[Reply]: https://github.com/botuniverse/onebot-11/blob/master/message/segment.md#%E5%9B%9E%E5%A4%8D
[Forward]: https://github.com/botuniverse/onebot-11/blob/master/message/segment.md#%E5%90%88%E5%B9%B6%E8%BD%AC%E5%8F%91-
[Node]: https://github.com/botuniverse/onebot-11/blob/master/message/segment.md#%E5%90%88%E5%B9%B6%E8%BD%AC%E5%8F%91%E8%8A%82%E7%82%B9-
[Xml]: https://github.com/botuniverse/onebot-11/blob/master/message/segment.md#xml-%E6%B6%88%E6%81%AF
[Json]: https://github.com/botuniverse/onebot-11/blob/master/message/segment.md#json-%E6%B6%88%E6%81%AF

</Details>

<Details>
<Summary>API</Summary>

| API                        | 是否支持 |
| -------------------------- | :-----: |
| [/send_private_msg]        |    🟢    |
| [/send_group_msg]          |    🟢    |
| [/send_msg]                |    🟢    |
| [/delete_msg]              |    🟢    |
| [/get_msg]                 |    🟢    |
| [/get_forward_msg]         |    🟢    |
| [/send_like]               |    🟢    |
| [/set_group_kick]          |    🟢    |
| [/set_group_ban]           |    🟢    |
| [/set_group_anonymous_ban] |    🟢    |
| [/set_group_whole_ban]     |    🟢    |
| [/set_group_admin]         |    🟢    |
| [/set_group_anonymous]     |    🟢    |
| [/set_group_card]          |    🟢    |
| [/set_group_name]          |    🟢    |
| [/set_group_leave]         |    🟢    |
| [/set_group_special_title] |    🟢    |
| [/set_friend_add_request]  |    🟢    |
| [/set_group_add_request]   |    🟢    |
| [/get_login_info]          |    🟢    |
| [/get_stranger_info]       |    🟢    |
| [/get_friend_list]         |    🟢    |
| [/get_group_info]          |    🟢    |
| [/get_group_list]          |    🟢    |
| [/get_group_member_info]   |    🟢    |
| [/get_group_member_list]   |    🟢    |
| [/get_group_honor_info]    |    🟢    |
| [/get_cookies]             |    🟢    |
| [/get_csrf_token]          |    🟢    |
| [/get_credentials]         |    🟢    |
| [/get_record]              |    🟢    |
| [/get_image]               |    🟢    |
| [/can_send_image]          |    🟢    |
| [/can_send_record]         |    🟢    |
| [/get_status]              |    🟢    |
| [/get_version_info]        |    🟢    |
| [/set_restart]             |    🟢    |
| [/clean_cache]             |    🔴    |

[/send_private_msg]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#send_private_msg-%E5%8F%91%E9%80%81%E7%A7%81%E8%81%8A%E6%B6%88%E6%81%AF
[/send_group_msg]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#send_group_msg-%E5%8F%91%E9%80%81%E7%BE%A4%E6%B6%88%E6%81%AF 
[/send_msg]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#send_msg-发送消息
[/delete_msg]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#delete_msg-撤回消息
[/get_msg]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#get_msg-获取消息
[/get_forward_msg]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#get_forward_msg-获取合并转发消息
[/send_like]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#send_like-发送好友赞
[/set_group_kick]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#set_group_kick-群组踢人
[/set_group_ban]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#set_group_ban-群组单人禁言
[/set_group_anonymous_ban]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#set_group_anonymous_ban-群组匿名用户禁言
[/set_group_whole_ban]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#set_group_whole_ban-群组全员禁言
[/set_group_admin]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#set_group_admin-群组设置管理员
[/set_group_anonymous]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#set_group_anonymous-群组匿名
[/set_group_card]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#set_group_card-设置群名片群备注
[/set_group_name]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#set_group_name-设置群名
[/set_group_leave]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#set_group_leave-退出群组
[/set_group_special_title]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#set_group_special_title-设置群组专属头衔
[/set_friend_add_request]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#set_friend_add_request-处理加好友请求
[/set_group_add_request]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#set_group_add_request-处理加群请求邀请
[/get_login_info]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#get_login_info-获取登录号信息
[/get_stranger_info]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#get_stranger_info-获取陌生人信息
[/get_friend_list]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#get_friend_list-获取好友列表
[/get_group_info]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#get_group_info-获取群信息
[/get_group_list]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#get_group_list-获取群列表
[/get_group_member_info]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#get_group_member_info-获取群成员信息
[/get_group_member_list]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#get_group_member_list-获取群成员列表
[/get_group_honor_info]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#get_group_honor_info-获取群荣誉信息
[/get_cookies]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#get_cookies-获取-cookies
[/get_csrf_token]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#get_csrf_token-获取-csrf-token
[/get_credentials]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#get_credentials-获取-qq-相关接口凭证
[/get_record]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#get_record-获取语音
[/get_image]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#get_image-获取图片
[/can_send_image]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#can_send_image-检查是否可以发送图片
[/can_send_record]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#can_send_record-检查是否可以发送语音
[/get_status]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#get_status-获取运行状态
[/get_version_info]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#get_version_info-获取版本信息
[/set_restart]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#set_restart-重启-onebot-实现
[/clean_cache]: https://github.com/botuniverse/onebot-11/blob/master/api/public.md#clean_cache-清理缓存

</Details>

<Details>
<Summary>事件</Summary>

| 推送类型 | 事件名称                        | 是否支持 |
| -------- | ------------------------------ | :-----: |
| Message  | [Private Message]              |    🟢    |
| Message  | [Group Message]                |    🟢    |
| Notice   | [Group File Upload]            |    🟢    |
| Notice   | [Group Admin Change]           |    🟢    |
| Notice   | [Group Member Decrease]        |    🟢    |
| Notice   | [Group Member Increase]        |    🟢    |
| Notice   | [Group Mute]                   |    🟢    |
| Notice   | [Friend Add]                   |    🟢    |
| Notice   | [Group Recall Message]         |    🟢    |
| Notice   | [Friend Recall Message]        |    🟢    |
| Notice   | [Group Poke]                   |    🟢    |
| Notice   | [Group red envelope luck king] |    🟢    |
| Notice   | [Group Member Honor Changed]   |    🟢    |
| Request  | [Add Friend Request]           |    🟢    |
| Request  | [Group Request/Invitations]    |    🟢    |
| Meta     | [LifeCycle]                    |    🟢    |
| Meta     | [Heartbeat]                    |    🟢    |

[Private Message]: https://github.com/botuniverse/onebot-11/blob/master/event/message.md#%E7%A7%81%E8%81%8A%E6%B6%88%E6%81%AF
[Group Message]: https://github.com/botuniverse/onebot-11/blob/master/event/message.md#%E7%BE%A4%E6%B6%88%E6%81%AF
[Group File Upload]: https://github.com/botuniverse/onebot-11/blob/master/event/notice.md#%E7%BE%A4%E6%96%87%E4%BB%B6%E4%B8%8A%E4%BC%A0
[Group Admin Change]: https://github.com/botuniverse/onebot-11/blob/master/event/notice.md#%E7%BE%A4%E7%AE%A1%E7%90%86%E5%91%98%E5%8F%98%E5%8A%A8
[Group Member Decrease]: https://github.com/botuniverse/onebot-11/blob/master/event/notice.md#%E7%BE%A4%E6%88%90%E5%91%98%E5%87%8F%E5%B0%91
[Group Member Increase]: https://github.com/botuniverse/onebot-11/blob/master/event/notice.md#%E7%BE%A4%E6%88%90%E5%91%98%E5%A2%9E%E5%8A%A0
[Group Mute]: https://github.com/botuniverse/onebot-11/blob/master/event/notice.md#%E7%BE%A4%E7%A6%81%E8%A8%80
[Friend Add]: https://github.com/botuniverse/onebot-11/blob/master/event/notice.md#%E5%A5%BD%E5%8F%8B%E6%B7%BB%E5%8A%A0
[Group Recall Message]: https://github.com/botuniverse/onebot-11/blob/master/event/notice.md#%E7%BE%A4%E6%B6%88%E6%81%AF%E6%92%A4%E5%9B%9E
[Friend Recall Message]: https://github.com/botuniverse/onebot-11/blob/master/event/notice.md#%E5%A5%BD%E5%8F%8B%E6%B6%88%E6%81%AF%E6%92%A4%E5%9B%9E
[Group Poke]: https://github.com/botuniverse/onebot-11/blob/master/event/notice.md#%E7%BE%A4%E5%86%85%E6%88%B3%E4%B8%80%E6%88%B3
[Group red envelope luck king]: https://github.com/botuniverse/onebot-11/blob/master/event/notice.md#%E7%BE%A4%E7%BA%A2%E5%8C%85%E8%BF%90%E6%B0%94%E7%8E%8B
[Group Member Honor Changed]: https://github.com/botuniverse/onebot-11/blob/master/event/notice.md#%E7%BE%A4%E6%88%90%E5%91%98%E8%8D%A3%E8%AA%89%E5%8F%98%E6%9B%B4
[Add Friend Request]: https://github.com/botuniverse/onebot-11/blob/master/event/request.md#%E5%8A%A0%E5%A5%BD%E5%8F%8B%E8%AF%B7%E6%B1%82
[Group Request/Invitations]: https://github.com/botuniverse/onebot-11/blob/master/event/request.md#%E5%8A%A0%E7%BE%A4%E8%AF%B7%E6%B1%82%E9%82%80%E8%AF%B7
[LifeCycle]: https://github.com/botuniverse/onebot-11/blob/master/event/meta.md#%E7%94%9F%E5%91%BD%E5%91%A8%E6%9C%9F
[Heartbeat]: https://github.com/botuniverse/onebot-11/blob/master/event/meta.md#%E5%BF%83%E8%B7%B3

</Details>

<Details>
<Summary>适配器</Summary>

| 适配器类型          | 是否支持 |
| ------------------ | :-----: |
| [Http]             |    🔴    |
| [Http-Post]        |    🔴    |
| [ForwardWebSocket] |    🟢    |
| [ReverseWebSocket] |    🟢    |

[Http]: https://github.com/botuniverse/onebot-11/blob/master/communication/http.md
[Http-Post]: https://github.com/botuniverse/onebot-11/blob/master/communication/http-post.md
[ForwardWebSocket]: https://github.com/botuniverse/onebot-11/blob/master/communication/ws.md
[ReverseWebSocket]: https://github.com/botuniverse/onebot-11/blob/master/communication/ws-reverse.md

</Details>

<Details>
<Summary>拓展功能</Summary>

| 功能          | 是否支持 |
| ------------------ | :-----: |
| [获取收藏表情] |    🟢    |
| [获取好友历史消息记录] |    🟢    |
| [获取群组历史消息记录] |    🟢    |
| [构造合并转发消息] |    🟢    |
| [上传群文件] |    🟢    |
| [私聊发送文件] |    🟢    |
| [获取群根目录文件列表] |    🟢    |
| [获取群子目录文件列表] |    🟢    |
| [获取群文件资源链接] |    🟢    |
| [好友戳一戳] |    🟢    |
| [群组戳一戳] |    🟢    |

[获取收藏表情]: https://lagrangedev.github.io/Lagrange.Doc/Lagrange.OneBot/API/Extend/#%E8%8E%B7%E5%8F%96%E6%94%B6%E8%97%8F%E8%A1%A8%E6%83%85
[获取好友历史消息记录]: https://lagrangedev.github.io/Lagrange.Doc/Lagrange.OneBot/API/Extend/#%E8%8E%B7%E5%8F%96%E5%A5%BD%E5%8F%8B%E5%8E%86%E5%8F%B2%E6%B6%88%E6%81%AF%E8%AE%B0%E5%BD%95
[获取群组历史消息记录]: https://lagrangedev.github.io/Lagrange.Doc/Lagrange.OneBot/API/Extend/#%E8%8E%B7%E5%8F%96%E7%BE%A4%E7%BB%84%E5%8E%86%E5%8F%B2%E6%B6%88%E6%81%AF%E8%AE%B0%E5%BD%95
[构造合并转发消息]: https://lagrangedev.github.io/Lagrange.Doc/Lagrange.OneBot/API/Extend/#%E6%9E%84%E9%80%A0%E5%90%88%E5%B9%B6%E8%BD%AC%E5%8F%91%E6%B6%88%E6%81%AF
[上传群文件]: https://lagrangedev.github.io/Lagrange.Doc/Lagrange.OneBot/API/Extend/#%E4%B8%8A%E4%BC%A0%E7%BE%A4%E6%96%87%E4%BB%B6
[私聊发送文件]: https://lagrangedev.github.io/Lagrange.Doc/Lagrange.OneBot/API/Extend/#%E7%A7%81%E8%81%8A%E5%8F%91%E9%80%81%E6%96%87%E4%BB%B6
[获取群根目录文件列表]: https://lagrangedev.github.io/Lagrange.Doc/Lagrange.OneBot/API/Extend/#%E8%8E%B7%E5%8F%96%E7%BE%A4%E6%A0%B9%E7%9B%AE%E5%BD%95%E6%96%87%E4%BB%B6%E5%88%97%E8%A1%A8
[获取群子目录文件列表]: https://lagrangedev.github.io/Lagrange.Doc/Lagrange.OneBot/API/Extend/#%E8%8E%B7%E5%8F%96%E7%BE%A4%E5%AD%90%E7%9B%AE%E5%BD%95%E6%96%87%E4%BB%B6%E5%88%97%E8%A1%A8
[获取群文件资源链接]: https://lagrangedev.github.io/Lagrange.Doc/Lagrange.OneBot/API/Extend/#%E8%8E%B7%E5%8F%96%E7%BE%A4%E6%96%87%E4%BB%B6%E8%B5%84%E6%BA%90%E9%93%BE%E6%8E%A5
[好友戳一戳]: https://lagrangedev.github.io/Lagrange.Doc/Lagrange.OneBot/API/Extend/#%E5%A5%BD%E5%8F%8B%E6%88%B3%E4%B8%80%E6%88%B3
[群组戳一戳]: https://lagrangedev.github.io/Lagrange.Doc/Lagrange.OneBot/API/Extend/#%E7%BE%A4%E7%BB%84%E6%88%B3%E4%B8%80%E6%88%B3

</Details>

## 快速上手

### 配置文件

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "@Default": "日志等级，如果需要看到详细的收发数据包内容（例如提出 issue），请改成 Trace ，一般情况下用 Information 就行"
    }
  },
  "Bot": {
    "ForwardWebSocket": {
      "@ForwardWebSocket": "正向 WebSocket",
      "Enabled": true,
      "@Enabled": "是否启用。注意：一般情况下 ForwardWebSocket 与 ReverseWebSocket 同一时间只能存在一个",
      "Url": "ws://127.0.0.1:8081",
      "@Url": "远程 Lagrange.Onebot 的 ws 服务器地址",
      "AccessToken": "",
      "@AccessToken": "鉴权密钥",
      "ReconnectInterval": 1000,
      "ConnectionTimeout": 5000,
      "ApiTimeout": 10000
    },
    "ReverseWebSocket": {
      "@ReverseWebSocket": "反向 WebSocket",
      "Enabled": false,
      "@Enabled": "是否启用",
      "Url": "http://127.0.0.1:8082/onebot/v11/ws/",
      "@Url": "本地开启的 ws 服务器地址，请严格按照 http(s):// 开头、/ 结尾的格式，否则可能报错",
      "AccessToken": "",
      "@AccessToken": "鉴权密钥",
      "RestartInterval": 1000
    }
  }
}
```

无注释版本见 [appsettings.json](Makabaka/appsettings.json) 。  

### 代码

```csharp
using Makabaka;
using Makabaka.Events;
using Makabaka.Messages;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MyApp
{
    internal class Program
    {
        private static ILogger<Program> _logger = null!;

        static void Main(string[] args)
        {
            var builder = new MakabakaAppBuilder(args);
            var app = builder.Build();

            _logger = app.Services.GetRequiredService<ILogger<Program>>();
            app.BotContext.OnPrivateMessage += OnPrivateMessage;
            app.BotContext.OnGroupMessage += OnGroupMessage;

            app.Run();
        }

        private static Task OnPrivateMessage(object sender, PrivateMessageEventArgs e)
        {
            return OnMessage(e.Message, e);
        }

        private static Task OnGroupMessage(object sender, GroupMessageEventArgs e)
        {
            return OnMessage(e.Message, e);
        }

        private static async Task OnMessage(Message message, IMessageHandler reply)
        {
            if (message.ToString() == "文本测试")
            {
                await reply.ReplyAsync([new TextSegment("Hello, world!")]);
            }
        }
    }
}
```

详细的API见 [Makabaka.Test](Makabaka.Test/) 。  

## 开源协议
[GPL-3.0 license](https://github.com/XeronOwO/Makabaka/blob/main/LICENSE.txt)

## 特别声明
- 本项目完全免费，仅供学习、娱乐使用，请勿运用于商业、非法用途。  
- 因使用者使用不当而造成的法律责任，由使用者本人承担。  
