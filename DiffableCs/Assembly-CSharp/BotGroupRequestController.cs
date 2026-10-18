//Type is in global namespace

public class BotGroupRequestController
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__16_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <TryActivateThrowGrenadeRequest>b__16_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__8`1
	{
		public static readonly <>c__8 <>9; //Field offset: 0x0
		public static Func <>9__8_0; //Field offset: 0x0

		private static <>c__8`1() { }

		public <>c__8`1() { }

		internal bool <GetRequestsCount>b__8_0(BotRequest x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public Player requester; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal bool <RemoveAllRequestByRequester>b__0(BotRequest x) { }

	}

	private readonly List _listOfRequests; //Field offset: 0x10
	private readonly BotsGroup _botGroup; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnAddRequest; //Field offset: 0x20

	public event Action OnAddRequest
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public int RequestsCount
	{
		 get { } //Length: 65
	}

	public BotGroupRequestController(BotsGroup botGroup) { }

	[CompilerGenerated]
	public void add_OnAddRequest(Action value) { }

	public void FindForMe(BotOwner executer) { }

	public int get_RequestsCount() { }

	public int GetRequestsCount() { }

	[CompilerGenerated]
	public void remove_OnAddRequest(Action value) { }

	public void RemoveAllRequestByRequester(Player requester) { }

	public void RemoveRequest(BotRequest botRequest) { }

	public bool TryActivateGetInCover(IPlayer player, BotOwner posibleExecuter, Nullable nearestPoint, float period = -1) { }

	public void TryActivateGoToCheckRequest(IPlayer player, BotOwner posibleExecuter) { }

	public bool TryActivateGoToPointRequest(IPlayer requester, Vector3 point, Action completeCallback = null, Action disposeCallback = null) { }

	public bool TryActivateOpenDoorRequest(IPlayer requester, Door door, Action completeCallback) { }

	public bool TryActivateSuppressionRequest(IPlayer requester, EnemyInfo enemy) { }

	public void TryActivateSuppressionRequest(IPlayer player, BotOwner posibleExecuter) { }

	public bool TryActivateThrowGrenadePlaceRequest(IPlayer requester, Player targetToThrow, Action callbackFinish = null) { }

	public bool TryActivateThrowGrenadeRequest(IPlayer requester, Player targetToThrow, bool onlyCached) { }

	public bool TryActivateThrowGrenadeRequest(IPlayer requester, Player targetToThrow, bool onlyCached = false, Action callbackFinish = null) { }

	public bool TryActivateThrowGrenadeRequest(IPlayer requester, BotOwner posibleExecuter, Nullable throwType = null) { }

	public bool TryActivateThrowGrenadeRequest(IPlayer requester, Vector3 placeToThrow, Nullable throwType, out ThrowGrenadePointRequest request) { }

	public bool TryActivateThrowGrenadeRequest(IPlayer requester, AIGreanageThrowData throwData, out ThrowGrenadePointRequest request) { }

	public bool TryActivateWait(IPlayer player, BotOwner posibleExecuter) { }

	public bool TryAddRequest(BotRequest request) { }

	private bool TryAddRequestByPlayer(IPlayer player, BotRequest request, BotOwner posibleExecuter) { }

	public bool TryAskFollowMeRequest(IPlayer player, BotOwner posibleExecuter) { }

	public void TryAskHideRequest(IPlayer player, BotOwner posibleExecuter) { }

	public bool TryAskHideRequest(IPlayer requester) { }

	public void TryAskHoldRequest(IPlayer player, BotOwner posibleExecuter) { }

	public bool TryAskSuppressionRequest(IPlayer requester, EnemyInfo player) { }

}

