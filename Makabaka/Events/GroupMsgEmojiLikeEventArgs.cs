using System;
using System.Collections.Generic;
using System.Text;

namespace Makabaka.Events
{
    /// <summary>
    /// 群消息表情点赞事件参数
    /// </summary>
    public class GroupMsgEmojiLikeEventArgs : NoticeEventArgs
    {
        /// <summary>
        /// 群号
        /// </summary>
        public ulong GroupId { get; set; }

        /// <summary>
        /// 消息发送者 QQ 号
        /// </summary>
        public ulong UserId { get; set; }

        /// <summary>
        /// 点赞详情
        /// </summary>
        public List<LikeInfo>? Likes { get; set; }

        /// <summary>
        /// 点赞详情信息
        /// </summary>

        public class LikeInfo
        {
            /// <summary>
            /// 表情Id
            /// </summary>
            public string? EmojiId { get; set; }
            /// <summary>
            /// 点赞数量
            /// </summary>
            public int Count { get; set; }
        }
    }
}
