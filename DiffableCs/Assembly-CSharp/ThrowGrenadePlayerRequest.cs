//Type is in global namespace

public class ThrowGrenadePlayerRequest : ThrowGrenadeRequest
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__0_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <FindPlace>b__0_0(ThrowGrenadePlace x) { }

	}

	private readonly bool _onlyCached; //Field offset: 0x88
	private Vector3 posToThrow; //Field offset: 0x8C
	private readonly Action _callbackFinish; //Field offset: 0x98
	[CompilerGenerated]
	private readonly Player <PlayerToThrow>k__BackingField; //Field offset: 0xA0

	public virtual Vector3 PlaceToThrow
	{
		 get { } //Length: 25
	}

	private Player PlayerToThrow
	{
		[CompilerGenerated]
		private get { } //Length: 8
	}

	public ThrowGrenadePlayerRequest(Player requester, Player targetToThrow, bool onlyCached, Action callbackFinish) { }

	public virtual void Dispose() { }

	[CanBeNull]
	public static ThrowGrenadePlace FindPlace(Player playerToThrow) { }

	public virtual Vector3 get_PlaceToThrow() { }

	[CompilerGenerated]
	private Player get_PlayerToThrow() { }

	public virtual void Take(BotOwner executor) { }

}

