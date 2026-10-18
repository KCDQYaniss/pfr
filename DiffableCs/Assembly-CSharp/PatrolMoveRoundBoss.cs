//Type is in global namespace

public class PatrolMoveRoundBoss : PatrolMoveSimple
{
	private const float BASE_RND_FOLLOWER_START_DELAY = 8.6; //Field offset: 0x0
	private Nullable _getOnlyType; //Field offset: 0x30
	private readonly List backFollowers; //Field offset: 0x38
	private bool _closeToPoint; //Field offset: 0x40
	private readonly PatrolFollowerType _patrolFollowerType; //Field offset: 0x44
	private float _nextCheckTime; //Field offset: 0x48
	private float _nextUpdateClose; //Field offset: 0x4C

	public PatrolMoveRoundBoss(BotOwner owner, PatrollingData data, PatrolFollowerType patrolFollowerType) { }

	private void AddBot(IBotOwner bot) { }

	private bool CheckFront(List followers) { }

	public virtual void Dispose() { }

	public virtual void DrawGizmosSelected() { }

	private void OnFollowerStatusChange(IBotOwner bot, FollowerStatusChange val) { }

	public virtual void Update() { }

	private void UpdateClose() { }

}

