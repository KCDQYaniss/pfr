//Type is in global namespace

public class PartisanPersuitLayer : BaseLogicLayer
{
	private Action _subscribed; //Field offset: 0x90
	private bool _enemyAtTriggerZone; //Field offset: 0x98
	private int _idEnemyAtTrigger; //Field offset: 0x9C
	private float _lastTimeChoose; //Field offset: 0xA0
	private CustomNavigationPoint _lastChoose; //Field offset: 0xA8

	public PartisanPersuitLayer(BotOwner bot, int priority) { }

	[CompilerGenerated]
	private bool <RefreshNewPoint>b__14_0(GroupPoint x) { }

	public virtual void Dispose() { }

	protected virtual AICoreActionEnd EndGoToPoint() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndRunToCoverZigZag() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	private void OnExitTriggerVisited() { }

	private void OnGoalEnemyChanged(BotOwner obj) { }

	private void RefreshNewPoint() { }

	public virtual bool ShallUseNow() { }

	private bool TryRefreshPoint(out AICoreActionEnd aiCoreActionEnd) { }

	private void TryUnsubscribeEnemy() { }

}

