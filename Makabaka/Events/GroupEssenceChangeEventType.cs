using System;
using System.Collections.Generic;
using System.Text;

namespace Makabaka.Events
{
    /// <summary>
 /// 群精华消息变动类型
 /// </summary>
    public enum GroupEssenceChangeEventType
    {
        /// <summary>
        /// 增加精华消息
        /// </summary>
        Add,

        /// <summary>
        /// 取消精华消息
        /// </summary>
        Delete,
    }
}
