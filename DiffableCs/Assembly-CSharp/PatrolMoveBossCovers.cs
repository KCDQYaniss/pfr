//Type is in global namespace

public class PatrolMoveBossCovers : PatrolMoveSimple
{
	protected readonly List backFollowers; //Field offset: 0x30
	protected readonly List frontFollowers; //Field offset: 0x38
	private bool _closeToPoint; //Field offset: 0x40
	private float _nextCheckTime; //Field offset: 0x44
	private float _periodLogic; //Field offset: 0x48

	public PatrolMoveBossCovers(BotOwner owner, PatrollingData data) { }

	private void AddBot(IBotOwner bot) { }

	protected bool CheckFront(List followers) { }

	public virtual void Dispose() { }

	private void OnFollowerStatusChange(IBotOwner bot, FollowerStatusChange status) { }

	public virtual void Update() { }

	protected void UpdateClose() { }

	protected void UpdateLogic(Action baseUpdate) { }

}

