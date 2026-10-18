//Type is in global namespace

public class BossKillaLayer : BaseLogicLayer
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass37_0
	{
		public BossKillaLayer <>4__this; //Field offset: 0x10
		public float d; //Field offset: 0x18
		public CustomNavigationPoint p; //Field offset: 0x20
		public bool v; //Field offset: 0x28

		public <>c__DisplayClass37_0() { }

		internal void <HavePointCloseForSupress>b__0(CustomNavigationPoint point) { }

	}

	private int _closeRuns; //Field offset: 0x90
	private float _contusionTime; //Field offset: 0x94
	protected CustomNavigationPoint _coverInMiddle; //Field offset: 0x98
	protected readonly List _curentInfos; //Field offset: 0xA0
	private float _runCanCalcWay; //Field offset: 0xA8
	private float _nextCheckCoverInMiddle; //Field offset: 0xAC
	protected readonly BotDistCheck _botDistCheck; //Field offset: 0xB0
	private readonly BotsConnections _connections; //Field offset: 0xB8
	protected Vector3 _lastRunZigZagPos; //Field offset: 0xC0
	private float _pointRecalcPeriod; //Field offset: 0xCC

	public BossKillaLayer(BotOwner owner, int priority) { }

	private AICoreActionResult AssaultMode() { }

	private AICoreActionResult CloseDist() { }

	private AICoreActionResult DefenceMode() { }

	public virtual void Dispose() { }

	protected virtual AICoreActionEnd EndAttackMoving() { }

	protected virtual AICoreActionEnd EndDogFight() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndRunToEnemy() { }

	private AICoreActionResult FarDist() { }

	private AICoreActionResult FarestDist() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	private bool HavePointCloseForSupress(ShootToPoint shootPos, float dist, out CustomNavigationPoint pos) { }

	protected bool IsContusion() { }

	private bool IsEnemiesSuppressed() { }

	private AICoreActionResult MidDist() { }

	public virtual string Name() { }

	protected virtual void OnActivate() { }

	private void OnGetHit(DamageInfo damageInfo, EBodyPart bodyPart, float damageReducedByArmor) { }

	private void OnGrenadeThrowStart() { }

	private void OnSuppressGrenadeComplete(BotSuppressGrenade obj) { }

	protected void RecheckCoverAtMiddle(CoverSearchData coverData, ShootToPoint posibleTarget) { }

	private BotLogicDecision RunIfCan() { }

	protected BotLogicDecision RunZigZag() { }

	public virtual bool ShallUseNow() { }

	protected CoverSearchData ShootData() { }

	private AICoreActionResult ShootFromPlaceOrGo() { }

	protected AICoreActionResult Suppress(bool grenadePriority, BotLogicDecision doThisIfCant) { }

	protected bool WantSuppressEnemy() { }

}

