//Type is in global namespace

public class ForcedForHelpAssaultLayer : BaseLogicLayer
{
	private float _enemyDistanceToStartFight; //Field offset: 0x90
	private float _chanceToRun; //Field offset: 0x94
	private int _closeRuns; //Field offset: 0x98
	private CustomNavigationPoint _coverInMiddle; //Field offset: 0xA0
	private readonly List _currentInfos; //Field offset: 0xA8
	private bool _nextFindAnyway; //Field offset: 0xB0
	private readonly BotDistCheck _botDistCheck; //Field offset: 0xB8
	private readonly BotsConnections _connections; //Field offset: 0xC0
	private Vector3 _lastRunZigZagPos; //Field offset: 0xC8
	private Vector3 _offsetIfEnv; //Field offset: 0xD4
	private bool _isHoldingAtCover; //Field offset: 0xE0
	private float _nextCheckCoverInMiddle; //Field offset: 0xE4
	private readonly float TOO_FAR_FROM_CALLER; //Field offset: 0xE8

	public ForcedForHelpAssaultLayer(BotOwner bot, int priority, float enemyDistanceToStartFight = -1, float chanceToRun = -1) { }

	private AICoreActionResult AssaultMode() { }

	private bool CanGo(Vector3 testTarget, bool findPlaceNear, out Vector3 vector3) { }

	protected virtual bool CanSearchEnemy() { }

	private AICoreActionResult CloseDist() { }

	public virtual void Dispose() { }

	protected virtual AICoreActionEnd EndAttackMoving() { }

	protected virtual AICoreActionEnd EndDogFight() { }

	protected virtual AICoreActionEnd EndGoToEnemy() { }

	protected virtual AICoreActionEnd EndGoToPoint() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndRunToEnemy() { }

	private AICoreActionResult FarestDist() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	protected virtual BotLogicDecision HoldFor(float sec) { }

	private AICoreActionResult MidDist() { }

	private BotLogicDecision MoveToEnemy() { }

	public virtual string Name() { }

	protected virtual void OnActivate() { }

	private void OnGrenadeThrowStart() { }

	protected void RecheckCoverAtMiddle() { }

	private CoverSearchData RecheckCoverData(CoverSearchData data = null) { }

	private BotLogicDecision RunZigZag() { }

	public virtual bool ShallUseNow() { }

	private AICoreActionResult ShootFromPlaceOrGo() { }

}

