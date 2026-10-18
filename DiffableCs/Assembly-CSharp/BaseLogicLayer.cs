//Type is in global namespace

public abstract class BaseLogicLayer : BaseLogicLayerSimple
{
	private const float SHOOT_IMMEDIATELY_PERIOD_SEC = 5; //Field offset: 0x0
	private const float MAX_PERIOD_SUPPRES_GRENADE = 6; //Field offset: 0x0
	protected AICoreActionResult _stubLogic; //Field offset: 0x60
	protected bool _endHoldEnable; //Field offset: 0x78
	protected float _endHoldTime; //Field offset: 0x7C
	protected Nullable _nextLogic; //Field offset: 0x80
	private bool _lastCanRunToEnemy; //Field offset: 0x88

	protected BaseLogicLayer(BotOwner bot, int priority) { }

	protected AICoreActionResult AttackOrHoldOrShoot(float holdperiod = 0, string pref = null) { }

	public void CalcActionNextFrame(Nullable nextLogic = null) { }

	protected override bool CanSearchEnemy() { }

	protected bool CanShootLastPos(EnemyInfo info) { }

	public static bool CheckMedsToStop(BotOwner bot) { }

	protected virtual AICoreActionEnd EndAlternativePatrol() { }

	protected virtual AICoreActionEnd EndAttackMoving() { }

	protected virtual AICoreActionEnd EndAxeTarget() { }

	protected virtual AICoreActionEnd EndDeadBody() { }

	protected virtual AICoreActionEnd EndDogFight() { }

	protected virtual AICoreActionEnd EndDropItem() { }

	protected virtual AICoreActionEnd EndEatDrink() { }

	protected virtual AICoreActionEnd EndFollowerPatrolItem() { }

	protected virtual AICoreActionEnd EndFriendlyTilt() { }

	protected virtual AICoreActionEnd EndGestus() { }

	protected virtual AICoreActionEnd EndGoToCoverPoint() { }

	protected virtual AICoreActionEnd EndGoToEnemy() { }

	protected virtual AICoreActionEnd EndGoToPoint() { }

	protected virtual AICoreActionEnd EndGrenadeSuicide() { }

	protected virtual AICoreActionEnd EndHeal() { }

	protected virtual AICoreActionEnd EndHealAnotherTarget() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndLayNode() { }

	protected virtual AICoreActionEnd EndLeaveMap() { }

	protected virtual AICoreActionEnd EndOneMeleeAttack() { }

	protected virtual AICoreActionEnd EndPanicSitting() { }

	protected virtual AICoreActionEnd EndPeaceHardAim() { }

	protected virtual AICoreActionEnd EndPeaceLook() { }

	protected virtual AICoreActionEnd EndRunAwayGrenade() { }

	protected virtual AICoreActionEnd EndRunGas() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndRunToCoverZigZag() { }

	protected virtual AICoreActionEnd EndRunToEnemy() { }

	protected virtual AICoreActionEnd EndRunToEnemyZigZag() { }

	protected virtual AICoreActionEnd EndRunToStationary() { }

	protected virtual AICoreActionEnd EndSearch() { }

	protected virtual AICoreActionEnd EndShootFromCover() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	protected virtual AICoreActionEnd EndSimplePatrol() { }

	protected virtual AICoreActionEnd EndStandBy() { }

	protected virtual AICoreActionEnd EndStimulators() { }

	protected virtual AICoreActionEnd EndSuppressFire() { }

	protected virtual AICoreActionEnd EndSuppressGrenade() { }

	protected virtual AICoreActionEnd EndSuppressStationary() { }

	protected virtual AICoreActionEnd EndTakeItem() { }

	protected virtual AICoreActionEnd EndTurnAway() { }

	public override CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	protected bool HaveDoorBetweenBotAndEnemy(EnemyInfo enemy) { }

	protected bool HaveEnoughtBullets() { }

	protected override BotLogicDecision HoldFor(float sec) { }

	public Nullable InFightLogic() { }

	protected bool IsHit(float period) { }

	public static bool IsPointInsideDangerZone(BotOwner bot, Vector3 point) { }

	protected bool ShallEndHoldPositionCauseTime() { }

	protected bool ShallShootFromCover(out string cause) { }

	protected bool ShallStartDogFight() { }

	protected bool ShouldShootImmediately() { }

	protected CustomNavigationPoint StandartFindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public static BotLogicDecision TryMoveToEnemy(BotOwner bot, BotLogicDecision runDecision = 27) { }

}

