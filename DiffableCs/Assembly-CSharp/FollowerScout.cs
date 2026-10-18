//Type is in global namespace

public class FollowerScout : PatrolFollowerAIBase
{
	private float _nextLookTime; //Field offset: 0x80

	public FollowerScout(BotOwner owner) { }

	[CanBeNull]
	protected virtual PatrolPoint BossPatrolPoint() { }

	public virtual bool SetTarget(FollowerPatrolTargetStruct trg, Nullable lookSide) { }

	public virtual void Update() { }

}

