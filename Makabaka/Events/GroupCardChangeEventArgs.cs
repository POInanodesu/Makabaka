using System;
using System.Collections.Generic;
using System.Text;

namespace Makabaka.Events
{
    /// <summary>
    /// 群名片更改事件参数
    /// </summary>
    public class GroupCardChangeEventArgs : NoticeEventArgs
    {
        /// <summary>
        /// 群号
        /// </summary>
        public ulong GroupId { get; set; }

        /// <summary>
        /// QQ 号
        /// </summary>
        public ulong UserId { get; set; }

        /// <summary>
        /// 新名片
        /// </summary>
        public string? CardNew { get; set; }

        /// <summary>
        /// 旧名片
        /// </summary>
        public string? CardOld { get; set; }
    }
}
