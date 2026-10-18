//Type is in global namespace

public class AvoidDangerLayer : BaseLogicLayer
{
	private float _lastUseAvoidLayer; //Field offset: 0x90

	public float LastUseAvoidLayer
	{
		 get { } //Length: 9
	}

	public AvoidDangerLayer(BotOwner bot, int priority) { }

	[CompilerGenerated]
	private bool <DoExtraSearch>b__16_0(GroupPoint point) { }

	protected override bool CanFightUnderArtillery() { }

	protected CustomNavigationPoint DoExtraSearch() { }

	protected virtual AICoreActionEnd EndAlternativePatrol() { }

	protected virtual AICoreActionEnd EndAttackMoving() { }

	protected virtual AICoreActionEnd EndAxeTarget() { }

	protected virtual AICoreActionEnd EndDeadBody() { }

	protected virtual AICoreActionEnd EndDebugDrop() { }

	protected virtual AICoreActionEnd EndDebugGestus() { }

	protected virtual AICoreActionEnd EndDebugGrenade() { }

	protected virtual AICoreActionEnd EndDebugGrenadeHoldPlace() { }

	protected virtual AICoreActionEnd EndDebugLay() { }

	protected virtual AICoreActionEnd EndDebugMelee() { }

	protected virtual AICoreActionEnd EndDebugMeleeChange() { }

	protected virtual AICoreActionEnd EndDebugMove() { }

	protected virtual AICoreActionEnd EndDebugRotate() { }

	protected virtual AICoreActionEnd EndDebugRotateHead() { }

	protected virtual AICoreActionEnd EndDebugRun() { }

	protected virtual AICoreActionEnd EndDebugRunToCloseCover() { }

	protected virtual AICoreActionEnd EndDebugRunToPoint() { }

	protected virtual AICoreActionEnd EndDebugShoot() { }

	protected virtual AICoreActionEnd EndDebugStationary() { }

	protected virtual AICoreActionEnd EndDebugTake() { }

	protected virtual AICoreActionEnd EndDebugWeaponChange() { }

	protected virtual AICoreActionEnd EndDogFight() { }

	protected virtual AICoreActionEnd EndDoGiftChristmasEvent() { }

	protected virtual AICoreActionEnd EndDoorOpenRequest() { }

	protected virtual AICoreActionEnd EndDropItem() { }

	protected virtual AICoreActionEnd EndEatDrink() { }

	protected virtual AICoreActionEnd EndFlashed() { }

	protected virtual AICoreActionEnd EndFollowerPatrolItem() { }

	protected virtual AICoreActionEnd EndFollowMeRequest() { }

	protected virtual AICoreActionEnd EndFriendlyTilt() { }

	protected virtual AICoreActionEnd EndGestus() { }

	protected virtual AICoreActionEnd EndGoToCoverPoint() { }

	protected virtual AICoreActionEnd EndGoToEnemy() { }

	protected virtual AICoreActionEnd EndGoToPoint() { }

	protected virtual AICoreActionEnd EndGrenadeSuicide() { }

	protected virtual AICoreActionEnd EndHeal() { }

	protected virtual AICoreActionEnd EndHealAnotherTarget() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndKhorovodChristmasEvent() { }

	protected virtual AICoreActionEnd EndLayNode() { }

	protected virtual AICoreActionEnd EndLeaveMap() { }

	protected virtual AICoreActionEnd EndOneMeleeAttack() { }

	protected virtual AICoreActionEnd EndPanicSitting() { }

	protected virtual AICoreActionEnd EndPeaceful() { }

	protected virtual AICoreActionEnd EndPeaceHardAim() { }

	protected virtual AICoreActionEnd EndPeaceLook() { }

	protected virtual AICoreActionEnd EndRepairMalfunction() { }

	protected virtual AICoreActionEnd EndRunAndThrowGrenadeFromPlace() { }

	protected virtual AICoreActionEnd EndRunAwayArtillery() { }

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

	protected virtual AICoreActionEnd EndShootFromStationary() { }

	protected virtual AICoreActionEnd EndShootToSmoke() { }

	protected virtual AICoreActionEnd EndSimplePatrol() { }

	protected virtual AICoreActionEnd EndStandBy() { }

	protected virtual AICoreActionEnd EndStimulators() { }

	protected virtual AICoreActionEnd EndSuppressFire() { }

	protected virtual AICoreActionEnd EndSuppressGrenade() { }

	protected virtual AICoreActionEnd EndSuppressStationary() { }

	protected virtual AICoreActionEnd EndTakeItem() { }

	protected virtual AICoreActionEnd EndTurnAway() { }

	protected virtual AICoreActionEnd EndWarnPlayer() { }

	protected virtual AICoreActionEnd EndWatchSecondWeapon() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public float get_LastUseAvoidLayer() { }

	public virtual AICoreActionResult GetDecision() { }

	private bool HaveEnemyAndCanShoot() { }

	private bool IsInGoodCoverForArtillery() { }

	private bool IsInGoodCoverForBTR() { }

	protected bool IsInGoodCoverForGrenade() { }

	public virtual string Name() { }

	protected bool PeaceSmokeGrenadeNear() { }

	public virtual bool ShallUseNow() { }

	private bool WantKillEnemyNow() { }

}

