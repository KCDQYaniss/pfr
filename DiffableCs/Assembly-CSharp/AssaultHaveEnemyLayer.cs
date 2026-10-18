//Type is in global namespace

public class AssaultHaveEnemyLayer : WithCutDistLayer
{
	private const float END_SHOOT_FLANK = 5; //Field offset: 0x0
	private Nullable _nextLogic; //Field offset: 0xA8
	private float _updatePointTimer; //Field offset: 0xB0
	private bool _canDoFlank; //Field offset: 0xB4
	private Nullable _doFlankNext; //Field offset: 0xB8
	private AICoreActionResult _medsCacheResult; //Field offset: 0xC8

	public AssaultHaveEnemyLayer(BotOwner bot, int priority) { }

	[CompilerGenerated]
	private void <GetDecision>b__10_0(CustomNavigationPoint point) { }

	[CompilerGenerated]
	private void <GetDecision>b__10_1(CustomNavigationPoint point) { }

	protected BotLogicDecision AttackOrHold() { }

	protected virtual AICoreActionEnd EndAttackMoving() { }

	protected virtual AICoreActionEnd EndAttackMovingFlank() { }

	protected virtual AICoreActionEnd EndHeal() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToStationary() { }

	protected virtual AICoreActionEnd EndSearch() { }

	protected virtual AICoreActionEnd EndShootFromCover() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

	private bool TryDoMeds(out AICoreActionResult aiCoreActionResult) { }

}

