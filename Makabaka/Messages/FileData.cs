using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Makabaka.Messages
{
    /// <summary>
    /// 文件数据
    /// </summary>
    public class FileData
    {

        /// <summary>
        /// 文件名<br/>
        /// ✘ 收<br/>
        /// ✔ 发
        /// 例如：123.txt
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// 文件<br/>
        /// ✔ 收<br/>
        /// ✔ 发[1]<br/><br/>
        /// [1] 发送时，file 参数除了支持使用收到的文件名直接发送外，还支持：<br/>
        /// - 绝对路径，例如 file:///C:\\Users\Richard\Pictures\1.png，格式使用 <a href="https://tools.ietf.org/html/rfc8089">file URI</a><br/>
        /// - 网络 URL，例如 http://i1.piimg.com/567571/fdd6e7b6d93f1ef0.jpg<br/>
        /// - Base64 编码，例如 base64://iVBORw0KGgoAAAANSUhEUgAAABQAAAAVCAIAAADJt1n/AAAAKElEQVQ4EWPk5+RmIBcwkasRpG9UM4mhNxpgowFGMARGEwnBIEJVAAAdBgBNAZf+QAAAAABJRU5ErkJggg==
        /// </summary>
        public string File { get; set; } = string.Empty;

        /// <summary>
        /// 文件路径<br/>
        /// ✔ 收<br/>
        /// ✘ 发
        /// </summary>
        public string? Path { get; set; }

        /// <summary>
        /// 文件 URL<br/>
        /// ✔ 收<br/>
        /// ✘ 发
        /// </summary>
        public string? Url { get; set; }

        /// <summary>
        /// 文件 ID<br/>
        /// ✔ 收<br/>
        /// ✘ 发
        /// </summary>
        public string? FileId { get; set; }

        /// <summary>
        /// 文件 大小<br/>
        /// ✔ 收<br/>
        /// ✘ 发
        /// </summary>
        public string? FileSize { get; set; }

        /// <summary>
        /// 文件 Unique<br/>
        /// ✔ 收<br/>
        /// ✘ 发
        /// </summary>
        public string? FileUnique { get; set; }
    }
}
