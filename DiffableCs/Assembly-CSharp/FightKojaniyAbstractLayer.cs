//Type is in global namespace

public abstract class FightKojaniyAbstractLayer : BaseAbstractKojaniyLayer
{
	private const float HOLD_IN_COVER_TIME = 6; //Field offset: 0x0
	private const float IS_ENEMY_CLOSE_TO_LOOT_SQRT = 10000; //Field offset: 0x0
	private const float MAX_ATTACK_MOVING_TIME = 9; //Field offset: 0x0
	private const float RUN_TO_ENEMY_DELTA = 10; //Field offset: 0x0
	private const float RUN_TO_ENEMY_DELTA_MINOR = 2; //Field offset: 0x0
	private const float waitIfHaveNoCover = 2; //Field offset: 0x0
	public bool _haveGoodCover; //Field offset: 0xB8
	public bool IAmReady; //Field offset: 0xB9
	public bool IsCurPosGood; //Field offset: 0xBA
	protected float _firstApperaTime; //Field offset: 0xBC
	private Vector3 _corePosition; //Field offset: 0xC0
	private float _lastRecalcOnStrikeCovers; //Field offset: 0xCC
	private float _nextCheckPosIsOk; //Field offset: 0xD0
	private float _nextLayTimeCheck; //Field offset: 0xD4

	protected FightKojaniyAbstractLayer(BotOwner owner, int priority) { }

	[CompilerGenerated]
	private void <IsPositionOk>b__34_0(CustomNavigationPoint point) { }

	private AICoreActionResult AttackLogic() { }

	protected virtual bool CanSearchEnemy() { }

	private void CheckCurrentCover() { }

	protected virtual AICoreActionEnd EndAttackMoving() { }

	protected virtual AICoreActionEnd EndGoToCoverPoint() { }

	protected virtual AICoreActionEnd EndGoToEnemy() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndLayNode() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndRunToEnemy() { }

	protected virtual AICoreActionEnd EndShootFromCover() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	private AICoreActionResult FewEnemiesAttackLogic() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	protected abstract Vector3 GetTargetToLook() { }

	public bool IsCoverGoodForRun(CustomNavigationPoint targetCustomNavigPoint) { }

	private bool IsEnemyCloseToLoot() { }

	protected abstract bool IsEverybodyRun() { }

	private void IsPositionOk() { }

	private AICoreActionResult ManyEnemiesAttackLogic() { }

	protected virtual void OnActivate() { }

	private AICoreActionResult RunIfCantShoot() { }

	private AICoreActionResult RunOrStrike(string info) { }

	public void SetCorePosition(Vector3 corePos) { }

	private BotLogicDecision ShootFromPlaceOrLay() { }

	private ShootToPoint ShootToPoint() { }

	private bool WaitInCover() { }

}

