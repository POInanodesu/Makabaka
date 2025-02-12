namespace Makabaka.Events
{
	/// <summary>
	/// 群内通知事件类型
	/// </summary>
	public enum NotifyEventType
	{
		/// <summary>
		/// 群内戳一戳
		/// </summary>
		Poke,

		/// <summary>
		/// 群红包运气王
		/// </summary>
		LuckyKing,

		/// <summary>
		/// 群成员荣誉变更
		/// </summary>
		Honor,

		/// <summary>
		/// 输入状态
		/// </summary>
		InputStatus,

		/// <summary>
		/// 点赞
		/// </summary>
        ProfileLike,

        /// <summary>
        /// 群成员头衔变更
        /// </summary>
        Ttitle,
    }
}
