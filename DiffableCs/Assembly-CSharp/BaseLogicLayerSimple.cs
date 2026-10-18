//Type is in global namespace

public abstract class BaseLogicLayerSimple : AICoreLayer
{
	protected BotOwner _owner; //Field offset: 0x28
	protected bool _nextFrameDropAction; //Field offset: 0x30
	protected AICoreActionEnd FinishNodeLogic; //Field offset: 0x38
	protected AICoreActionEnd ContinueNodeLogic; //Field offset: 0x48
	[CompilerGenerated]
	private readonly int <Priority>k__BackingField; //Field offset: 0x58

	public virtual int Priority
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	protected BaseLogicLayerSimple(BotOwner bot, int priority) { }

	private AICoreActionEnd BaseEndSummon() { }

	protected virtual void DecisionChanged(Nullable prevDecision, AICoreActionResult nextDecision) { }

	protected override AICoreActionEnd EndAlternativePatrol() { }

	protected override AICoreActionEnd EndAttackMoving() { }

	protected override AICoreActionEnd EndAttackMovingFlank() { }

	protected override AICoreActionEnd EndAttackMovingFlankToPoint() { }

	protected override AICoreActionEnd EndAttackMovingWithSuppress() { }

	protected override AICoreActionEnd EndAxeTarget() { }

	protected override AICoreActionEnd EndCrawlNode() { }

	protected override AICoreActionEnd EndCulling() { }

	private AICoreActionEnd EndCullingMain() { }

	protected override AICoreActionEnd EndDeactivateMine() { }

	protected override AICoreActionEnd EndDeadBody() { }

	protected override AICoreActionEnd EndDebugDrop() { }

	protected override AICoreActionEnd EndDebugGestus() { }

	protected override AICoreActionEnd EndDebugGrenade() { }

	protected override AICoreActionEnd EndDebugGrenadeHoldPlace() { }

	protected override AICoreActionEnd EndDebugLay() { }

	protected override AICoreActionEnd EndDebugLoot() { }

	protected override AICoreActionEnd EndDebugMelee() { }

	protected override AICoreActionEnd EndDebugMeleeChange() { }

	protected override AICoreActionEnd EndDebugMove() { }

	protected override AICoreActionEnd EndDebugRotate() { }

	protected override AICoreActionEnd EndDebugRotateHead() { }

	protected override AICoreActionEnd EndDebugRotateLay() { }

	protected override AICoreActionEnd EndDebugRun() { }

	protected override AICoreActionEnd EndDebugRunToCloseCover() { }

	protected override AICoreActionEnd EndDebugRunToPoint() { }

	protected override AICoreActionEnd EndDebugShoot() { }

	protected override AICoreActionEnd EndDebugShootFromCover() { }

	protected override AICoreActionEnd EndDebugShuttle() { }

	protected override AICoreActionEnd EndDebugStationary() { }

	protected override AICoreActionEnd EndDebugSuppressFromCover() { }

	protected override AICoreActionEnd EndDebugTacticalMove() { }

	protected override AICoreActionEnd EndDebugTake() { }

	protected override AICoreActionEnd EndDebugTaticalShuttle() { }

	private AICoreActionEnd EndDebugToggleLauncher() { }

	protected override AICoreActionEnd EndDebugWeaponChange() { }

	protected override AICoreActionEnd EndDebugZigZagRunNode() { }

	protected override AICoreActionEnd EndDogFight() { }

	protected override AICoreActionEnd EndDoGiftChristmasEvent() { }

	protected override AICoreActionEnd EndDoorOpenRequest() { }

	protected override AICoreActionEnd EndDropItem() { }

	protected override AICoreActionEnd EndEatDrink() { }

	protected override AICoreActionEnd EndFlashed() { }

	protected override AICoreActionEnd EndFollowerPatrolItem() { }

	protected override AICoreActionEnd EndFollowMeRequest() { }

	protected override AICoreActionEnd EndFriendlyTilt() { }

	protected override AICoreActionEnd EndGestus() { }

	protected override AICoreActionEnd EndGoSomePointTactical() { }

	protected override AICoreActionEnd EndGoToCoverPoint() { }

	protected override AICoreActionEnd EndGoToCoverPointTactical() { }

	protected override AICoreActionEnd EndGoToEnemy() { }

	protected override AICoreActionEnd EndGoToEnemyWithSuppress() { }

	protected override AICoreActionEnd EndGoToEnemyZigZag() { }

	protected override AICoreActionEnd EndGoToExfiltrationPointNode() { }

	protected override AICoreActionEnd EndGoToLootPointNode() { }

	protected override AICoreActionEnd EndGoToPoint() { }

	protected override AICoreActionEnd EndGrenadeSuicide() { }

	protected override AICoreActionEnd EndHeal() { }

	protected override AICoreActionEnd EndHealAnotherTarget() { }

	protected override AICoreActionEnd EndHoldPosition() { }

	protected override AICoreActionEnd EndKhorovodChristmasEvent() { }

	protected override AICoreActionEnd EndLayNode() { }

	protected override AICoreActionEnd EndLeaveMap() { }

	protected override AICoreActionEnd EndMedsNode() { }

	protected override AICoreActionEnd EndMoveStealthy() { }

	protected override AICoreActionEnd EndOneMeleeAttack() { }

	protected override AICoreActionEnd EndPanicSitting() { }

	protected override AICoreActionEnd EndPeaceful() { }

	protected override AICoreActionEnd EndPeaceHardAim() { }

	protected override AICoreActionEnd EndPeaceLook() { }

	protected override AICoreActionEnd EndPlantMine() { }

	protected override AICoreActionEnd EndPlayerFollow() { }

	protected override AICoreActionEnd EndRepairMalfunction() { }

	protected override AICoreActionEnd EndRunAndThrowGrenadeFromPlace() { }

	protected override AICoreActionEnd EndRunAwayArtillery() { }

	protected override AICoreActionEnd EndRunAwayBTR() { }

	protected override AICoreActionEnd EndRunAwayGrenade() { }

	protected override AICoreActionEnd EndRunGas() { }

	protected override AICoreActionEnd EndRunToCover() { }

	protected override AICoreActionEnd EndRunToCoverZigZag() { }

	protected override AICoreActionEnd EndRunToEnemy() { }

	protected override AICoreActionEnd EndRunToEnemyZigZag() { }

	protected override AICoreActionEnd EndRunToStationary() { }

	protected override AICoreActionEnd EndSearch() { }

	protected override AICoreActionEnd EndShootFromCover() { }

	protected override AICoreActionEnd EndShootFromPlace() { }

	protected override AICoreActionEnd EndShootFromStationary() { }

	protected override AICoreActionEnd EndShootToSmoke() { }

	protected override AICoreActionEnd EndSimplePatrol() { }

	protected override AICoreActionEnd EndStandBy() { }

	protected override AICoreActionEnd EndStimulators() { }

	protected override AICoreActionEnd EndSummon() { }

	protected override AICoreActionEnd EndSuppressFire() { }

	protected override AICoreActionEnd EndSuppressFromCover() { }

	protected override AICoreActionEnd EndSuppressGrenade() { }

	protected override AICoreActionEnd EndSuppressStationary() { }

	protected override AICoreActionEnd EndTakeItem() { }

	private AICoreActionEnd EndTeleportlNode() { }

	protected override AICoreActionEnd EndThrowGrenadeFromPlace() { }

	protected override AICoreActionEnd EndTurnAway() { }

	protected override AICoreActionEnd EndWarnPlayer() { }

	protected override AICoreActionEnd EndWatchSecondWeapon() { }

	[CompilerGenerated]
	public virtual int get_Priority() { }

	public static BotLogicDecision HoldOrCover(BotOwner owner) { }

	public static BotLogicDecision HoldOrCoverRun(BotOwner owner) { }

	public virtual AICoreActionEnd ShallEndCurrentDecision(AICoreActionResult curDecision) { }

}

