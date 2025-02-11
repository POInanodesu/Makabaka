using System;
using System.Collections.Generic;
using System.Text;

namespace Makabaka.Events
{
    /// <summary>
    /// 点赞事件参数
    /// </summary>
    public class ProfileLikeEventArgs : NotifyEventArgs
    {
        /// <summary>
        /// 点赞者 QQ 号
        /// </summary>
        public ulong OperatorId { get; set; }

        /// <summary>
        /// 点赞者 昵称
        /// </summary>
        public ulong OperatorNick { get; set; }

        /// <summary>
        /// 点赞次数
        /// </summary>
        public int Times { get; set; }
    }
}
