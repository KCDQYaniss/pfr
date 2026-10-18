//Type is in global namespace

public class DebugLogicLayer : BaseLogicLayer
{
	public DebugBotDesition Desition; //Field offset: 0x90
	private AIPeriodAction _checkEnemies; //Field offset: 0x98

	public DebugLogicLayer(BotOwner bot, int priority) { }

	private void CheatGetAllEnemies() { }

	protected virtual AICoreActionEnd EndAttackMovingFlankToPoint() { }

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

	protected virtual AICoreActionEnd EndDebugRotateLay() { }

	protected virtual AICoreActionEnd EndDebugRun() { }

	protected virtual AICoreActionEnd EndDebugRunToCloseCover() { }

	protected virtual AICoreActionEnd EndDebugRunToPoint() { }

	protected virtual AICoreActionEnd EndDebugShoot() { }

	protected virtual AICoreActionEnd EndDebugShootFromCover() { }

	protected virtual AICoreActionEnd EndDebugShuttle() { }

	protected virtual AICoreActionEnd EndDebugStationary() { }

	protected virtual AICoreActionEnd EndDebugSuppressFromCover() { }

	protected virtual AICoreActionEnd EndDebugTacticalMove() { }

	protected virtual AICoreActionEnd EndDebugTake() { }

	protected virtual AICoreActionEnd EndDebugTaticalShuttle() { }

	protected virtual AICoreActionEnd EndDebugWeaponChange() { }

	protected virtual AICoreActionEnd EndDebugZigZagRunNode() { }

	protected virtual AICoreActionEnd EndGoToEnemy() { }

	protected virtual AICoreActionEnd EndMedsNode() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	private void PeriodFindAllEnemies() { }

	public virtual bool ShallUseNow() { }

}

