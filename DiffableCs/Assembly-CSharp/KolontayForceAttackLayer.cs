//Type is in global namespace

public class KolontayForceAttackLayer : KolontayAbstractFightLayer
{
	private const bool _useSlowAttack = True; //Field offset: 0x0
	private bool _protectingNow; //Field offset: 0xA0
	private readonly BossFinder _bossLogic; //Field offset: 0xA8
	private float _lastUseAM; //Field offset: 0xB0
	protected CustomNavigationPoint _coverInMiddle; //Field offset: 0xB8
	private float _nextCheckCoverInMiddle; //Field offset: 0xC0

	public KolontayForceAttackLayer(BotOwner bot, int priority, float distToAttack) { }

	public virtual void Dispose() { }

	protected virtual AICoreActionEnd EndAttackMoving() { }

	protected virtual AICoreActionEnd EndAttackMovingWithSuppress() { }

	protected virtual AICoreActionEnd EndDogFight() { }

	protected virtual AICoreActionEnd EndGoToCoverPoint() { }

	protected virtual AICoreActionEnd EndGoToEnemy() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	protected virtual AICoreActionEnd EndSuppressFire() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	protected CoverSearchData RecheckCoverDataForAttack() { }

	protected void RecheckCoverForAttack() { }

	public void SetProtect(bool protectBoss) { }

	public virtual bool ShallUseNow() { }

}

