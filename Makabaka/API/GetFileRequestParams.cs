using System;
using System.Collections.Generic;
using System.Text;

namespace Makabaka.API
{
    /// <summary>
    /// 获取文件
    /// </summary>
    /// <param name="FileId">文件ID</param>
    public record class GetFileRequestParams(
        string FileId
        )
    {
    }
}
