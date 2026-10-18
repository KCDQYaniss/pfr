//Type is in global namespace

public class BotMoverImpostor : BotMover
{
	private readonly BotFrameMoveContext _lastContext; //Field offset: 0x1B8
	private bool _isWorks; //Field offset: 0x1C0
	private CollisionFlags _lastFlags; //Field offset: 0x1C4
	private readonly BotMoverInertion _inertion; //Field offset: 0x1C8
	private float _maxStepPerFrame; //Field offset: 0x1D0

	public virtual bool Blocked
	{
		 get { } //Length: 11
	}

	public virtual bool IsImpostorWorks
	{
		 get { } //Length: 8
	}

	public BotMoverImpostor(BotOwner owner, Player player, AICoversData covers) { }

	[CompilerGenerated]
	private void <.ctor>b__9_0(BotMoverState x) { }

	public virtual void Activate() { }

	protected virtual bool CheckCornerIndexByReachDist(float distCur, Vector3 position) { }

	protected virtual bool CheckIsOnPoint(Vector3 position) { }

	public virtual void Dispose() { }

	public virtual bool get_Blocked() { }

	public virtual bool get_IsImpostorWorks() { }

	protected virtual Vector3 InertionOffset() { }

	protected virtual void InertionUpdateOnCoef(float coef) { }

	public virtual void OnDrawGizmosPrevWay() { }

	private void OnMotionApplied(CollisionFlags flags, Vector3 deltaMove) { }

	private void OnWayChangedAction(bool havePrevWay) { }

	protected virtual void SetLastContex(float remainDist, Vector3 directionMove, Vector3 targetPos) { }

}

