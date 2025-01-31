using Makabaka.Utils;

using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace Makabaka.Messages
{
    /// <summary>
    /// 文件消息
    /// </summary>
    /// <param name="file">
    /// 文件<br/>
    /// ✔ 收<br/>
    /// ✔ 发[1]<br/><br/>
    /// [1] 发送时，file 参数除了支持使用收到的文件名直接发送外，还支持：<br/>
    /// - 绝对路径，例如 file:///C:\\Users\Richard\Pictures\1.txt，格式使用 <a href="https://tools.ietf.org/html/rfc8089">file URI</a><br/>
    /// </param>
    /// <param name="fileName">
    /// ✔ 收<br/>
    /// ✔ 发
    /// 例如：文件.txt
    /// </param>
    [Segment(SegmentType.File)]
    public class FileSegment(
        string file,
        string fileName = ""
        ) : Segment<FileData>(
            SegmentType.File.ToSerializedString(),
            new()
            {
                File = file,
                Name = fileName
            })
    {
        /// <summary>
        /// 反序列化保留，请使用其它构造函数
        /// </summary>
        public FileSegment() : this(string.Empty)
        {
        }


        /// <summary>
        /// 从文件创建文件段消息
        /// </summary>
        /// <param name="path">文件</param>
        /// <returns>文件段消息</returns>
        public static FileSegment FromFile(string path)
        {
            return new FileSegment(path);
        }
    }
}
