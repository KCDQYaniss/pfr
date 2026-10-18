//Type is in global namespace

public class FollowerStayAtPlace : PatrolFollowerAIBase
{
	private const float DIST_TO_SLOW = 4; //Field offset: 0x0
	private float _nextLookTime; //Field offset: 0x80
	private Vector3 _targetToLook; //Field offset: 0x84
	private Vector3 _corePlace; //Field offset: 0x90
	private CustomNavigationPoint _point; //Field offset: 0xA0
	private readonly PatrolMoveBossStayAtPlace _bossStayAtPlace; //Field offset: 0xA8
	private float _recheckCoverTime; //Field offset: 0xB0

	public FollowerStayAtPlace(BotOwner owner, PatrolMoveBossStayAtPlace bossStayAtPlace) { }

	private bool CheckCoverPoint(bool checkCur) { }

	public virtual void OnDrawSelectedGizmos() { }

	public virtual bool SetTarget(FollowerPatrolTargetStruct trg, Nullable lookSide) { }

	public virtual void Update() { }

}

