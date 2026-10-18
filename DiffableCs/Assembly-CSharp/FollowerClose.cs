//Type is in global namespace

public class FollowerClose : PatrolFollowerAIBase
{
	private float _nextLookTime; //Field offset: 0x80

	public FollowerClose(BotOwner owner) { }

	public virtual void Activate() { }

	public virtual void Dispose() { }

	private void GoTo(Vector3 v) { }

	private void OnStatusChanged(PatrolStatus obj) { }

	public virtual bool SetTarget(FollowerPatrolTargetStruct trg, Nullable lookSide) { }

	public virtual void Update() { }

}

