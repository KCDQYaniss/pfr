//Type is in global namespace

public class PatrolAssaultLayer : BaseLogicLayer
{
	private float _nextCheckReload; //Field offset: 0x90

	public PatrolAssaultLayer(BotOwner bot, int priority) { }

	[CompilerGenerated]
	private void <ManualUpdate>b__4_0(IResult _) { }

	protected bool CheckNotMovingActions(out AICoreActionResult aiCoreActionResult) { }

	protected virtual AICoreActionEnd EndAlternativePatrol() { }

	protected virtual AICoreActionEnd EndEatDrink() { }

	protected virtual AICoreActionEnd EndFollowerPatrolItem() { }

	protected virtual AICoreActionEnd EndGoToLootPointNode() { }

	protected virtual AICoreActionEnd EndHeal() { }

	protected virtual AICoreActionEnd EndLayNode() { }

	protected virtual AICoreActionEnd EndPeaceful() { }

	protected virtual AICoreActionEnd EndSearch() { }

	protected virtual AICoreActionEnd EndSimplePatrol() { }

	protected virtual AICoreActionEnd EndWatchSecondWeapon() { }

	public virtual AICoreActionResult GetDecision() { }

	protected bool HaveSomeToDo(out string reason) { }

	private bool IsBossOrFollower() { }

	protected virtual void ManualUpdate() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

	private void TryReloadMainWeapon() { }

}

