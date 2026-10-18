//Type is in global namespace

internal class WaitLayer : BaseLogicLayer
{
	private bool _isHit; //Field offset: 0x90

	public WaitLayer(BotOwner bot, int priority) { }

	public virtual void Dispose() { }

	protected virtual AICoreActionEnd EndAlternativePatrol() { }

	protected virtual AICoreActionEnd EndAttackMoving() { }

	protected virtual AICoreActionEnd EndAttackMovingFlank() { }

	protected virtual AICoreActionEnd EndAxeTarget() { }

	protected virtual AICoreActionEnd EndCulling() { }

	protected virtual AICoreActionEnd EndFollowerPatrolItem() { }

	protected virtual AICoreActionEnd EndGoToCoverPoint() { }

	protected virtual AICoreActionEnd EndGoToEnemy() { }

	protected virtual AICoreActionEnd EndGoToEnemyWithSuppress() { }

	protected virtual AICoreActionEnd EndGoToPoint() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndSearch() { }

	protected virtual AICoreActionEnd EndShootFromCover() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	protected virtual AICoreActionEnd EndSimplePatrol() { }

	protected virtual AICoreActionEnd EndStandBy() { }

	protected virtual AICoreActionEnd EndSuppressFire() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

