using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Nodes;

namespace Makabaka.Messages
{
    /// <summary>
    /// 未定义的段消息
    /// </summary>
    [Segment(SegmentType.Undefined)]
    public class UndefinedSegment : Segment<JsonNode>
    {
    }
}
