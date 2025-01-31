using System;
using System.Collections.Generic;
using System.Text;

namespace Makabaka.Models
{
    /// <summary>
    /// 文件信息
    /// </summary>
    public class FileInfo
    {
        /// <summary>
        /// 路径或链接
        /// </summary>
        public string File { get; set; } = string.Empty;
        /// <summary>
        /// 路径或链接
        /// </summary>
        public string Url { get; set; } = string.Empty;
        /// <summary>
        /// 文件大小
        /// </summary>
        public string FileSize { get; set; } = string.Empty;
        /// <summary>
        /// 文件名
        /// </summary>
        public string FileName { get; set; } = string.Empty;
        /// <summary>
        /// base64
        /// </summary>
        public string Base64 { get; set; } = string.Empty;
    }
}
