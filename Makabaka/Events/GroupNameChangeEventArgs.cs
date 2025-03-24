using System;
using System.Collections.Generic;
using System.Text;

namespace Makabaka.Events
{
    /// <summary>
    /// 群名称变更事件参数
    /// </summary>
    public class GroupNameChangeEventArgs : NotifyEventArgs
    {
        /// <summary>
        /// QQ 群号
        /// </summary>
        public ulong GroupId { get; set; }

        /// <summary>
        /// 操作者 QQ 号
        /// </summary>
        public ulong UserId { get; set; }

        /// <summary>
        /// 新群名称
        /// </summary>
        public string NameNew { get; set; } = string.Empty;
    }
}
