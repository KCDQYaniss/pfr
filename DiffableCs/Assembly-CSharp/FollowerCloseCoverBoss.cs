//Type is in global namespace

public class FollowerCloseCoverBoss : PatrolFollowerAIBase
{
	private float _nextLookTime; //Field offset: 0x80
	private float _nextTimeCanSprint; //Field offset: 0x84
	protected bool _haveEndPath; //Field offset: 0x88
	protected bool _lastNearPoint; //Field offset: 0x89

	public FollowerCloseCoverBoss(BotOwner owner) { }

	protected void GoTo(Vector3 v, bool withSprint) { }

	protected void LookUpdate(FollowerPatrolTargetStruct patrolTarget, bool isClose) { }

	public virtual bool SetTarget(FollowerPatrolTargetStruct trg, Nullable lookSide) { }

	public virtual void Update() { }

}

