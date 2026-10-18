//Type is in global namespace

public class BotRequestController
{
	public const float PHRASE_DIST_SQRT = 25; //Field offset: 0x0
	private const float DELTA_TIME_ACTIVATE_REQUEST_SEC = 10; //Field offset: 0x0
	private const float DELTA_TIME_SEARCH_REQUEST_FO_SELF = 10; //Field offset: 0x0
	public BotRequest CurRequest; //Field offset: 0x10
	private readonly BotOwner _owner; //Field offset: 0x18
	private float _nextFindTime; //Field offset: 0x20
	private float _nextRequestTime; //Field offset: 0x24
	private float _nextGoToPointRequestTime; //Field offset: 0x28
	private float _nextThrowGrenadeRequestTime; //Field offset: 0x2C
	private BotGroupRequestController _groupRequestController; //Field offset: 0x30
	private readonly Dictionary _blockUntil; //Field offset: 0x38
	private float _lastSetRequestTime; //Field offset: 0x40

	public BotGroupRequestController GroupRequestController
	{
		 get { } //Length: 544
	}

	public float LastSetRequestTime
	{
		 get { } //Length: 6
	}

	public BotRequestController(BotOwner owner) { }

	private bool CanActivateRequest() { }

	private void CheckIsCurRequestEnds() { }

	public void CompleteRequest(BotRequest botRequest) { }

	public void Dispose() { }

	public void DoNotAcceptRequests(BotRequest lastRequestFailed) { }

	public BotGroupRequestController get_GroupRequestController() { }

	public float get_LastSetRequestTime() { }

	public int GetRequestsCount() { }

	public bool HaveActivatedRequests() { }

	public bool IsAvailableByTime(BotRequestType brt) { }

	private void OnAddRequest(BotRequest obj) { }

	public void RemoveAllRequestByRequester(Player getPlayer) { }

	public void ResetTimer() { }

	public void SetCurrentRequest(BotRequest possibleRequest) { }

	public bool TryActivateGoToPointRequest(Vector3 point, Action completeCallback = null, Action disposeCallback = null) { }

	public bool TryActivateOpenDoorRequest(Door door, Action completeCallback) { }

	public bool TryActivateThrowGrenadeRequest(Player targetToThrow, bool onlyCached = false, Action callbackFinish = null) { }

	public bool TryActivateThrowGrenadeRequest(Vector3 placeToThrow, Nullable throwType, out ThrowGrenadePointRequest request) { }

	public bool TryActivateThrowGrenadeRequestToPlace(Player targetToThrow, Action callbackFinish = null) { }

	public void TrySayNegative(IPlayer player, BotRequestType rejectedRequest) { }

	public bool TryStopCurrent(Player player, bool withTalk = true) { }

	public bool TryThrowSuppressionRequest() { }

	public void TryToFind() { }

	public void Update() { }

}

