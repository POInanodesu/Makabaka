using System;
using System.Collections.Generic;
using System.Text;

namespace Makabaka.Events
{
    /// <summary>
    /// 群精华消息变动事件参数
    /// </summary>
    public class GroupEssenceChangeEventArgs : NoticeEventArgs
    {
        /// <summary>
        /// 事件子类型，分别表示增加和取消精华消息
        /// </summary>
        public GroupEssenceChangeEventType SubType { get; set; }

        /// <summary>
        /// 群号
        /// </summary>
        public ulong GroupId { get; set; }

        /// <summary>
        /// 消息发送者 QQ 号
        /// </summary>
        public ulong SenderId { get; set; }

        /// <summary>
        /// 操作者 QQ 号
        /// </summary>
        public ulong OperatorId { get; set; }

        /// <summary>
        /// 消息 ID
        /// </summary>
        public ulong MessageId { get; set; }
    }
}
