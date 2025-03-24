using System;
using System.Collections.Generic;
using System.Text;

namespace Makabaka.Events
{
    /// <summary>
    /// 群成员头衔变更事件参数
    /// </summary>
    public class GroupMemberTitleChangeEventArgs : NotifyEventArgs
    {
        /// <summary>
        /// QQ 群号
        /// </summary>
        public ulong GroupId { get; set; }

        /// <summary>
        /// 用户 QQ 号
        /// </summary>
        public ulong UserId { get; set; }

        /// <summary>
        /// 头衔
        /// </summary>
        public string Title { get; set; } = string.Empty;
    }
}
