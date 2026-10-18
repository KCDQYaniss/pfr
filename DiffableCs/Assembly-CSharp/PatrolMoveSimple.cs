//Type is in global namespace

public class PatrolMoveSimple : BotData, IPatrolMove
{
	public const float BAD_DIST_TO_FOLLOWER = 3.2; //Field offset: 0x0
	public AllFollowersPatrolInfo AllFollowersPatrolInfo; //Field offset: 0x18
	protected PatrollingData _data; //Field offset: 0x20
	protected float _nextTimeCanRecalc; //Field offset: 0x28
	protected float _distToPoint; //Field offset: 0x2C

	public PatrolMoveSimple(BotOwner owner, PatrollingData data) { }

	public override void Dispose() { }

	public override void DrawGizmosSelected() { }

	public static Vector3 FrontPos(BotOwner boss, bool isFront, int totalCount, int index) { }

	public static bool IsCome(BotOwner bot, Nullable curTrg, bool extraTarget, out float dist) { }

	protected bool IsCome() { }

	public override void Update() { }

}

