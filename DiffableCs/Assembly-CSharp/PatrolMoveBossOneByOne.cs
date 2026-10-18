//Type is in global namespace

public class PatrolMoveBossOneByOne : PatrolMoveSimple
{
	private bool _closeToPoint; //Field offset: 0x30
	private float _nextCheckTime; //Field offset: 0x34
	private float _periodLogic; //Field offset: 0x38
	public Dictionary _botOrders; //Field offset: 0x40
	private List _order; //Field offset: 0x48

	public PatrolMoveBossOneByOne(BotOwner owner, PatrollingData data) { }

	private void AddBot(IBotOwner bot) { }

	public virtual void Dispose() { }

	private void OnFollowerStatusChange(IBotOwner bot, FollowerStatusChange status) { }

	private void Refresh() { }

	protected override void RefreshFollower(IBotOwner owner) { }

	public virtual void Update() { }

	protected void UpdateClose() { }

	protected void UpdateLogic(Action baseUpdate) { }

}

