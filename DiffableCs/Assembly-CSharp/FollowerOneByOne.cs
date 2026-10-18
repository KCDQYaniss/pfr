//Type is in global namespace

public class FollowerOneByOne : PatrolFollowerAIBase
{
	private float _nextLookTime; //Field offset: 0x80
	private float _lastMyRemain; //Field offset: 0x84
	private float _lastMyRemainTime; //Field offset: 0x88
	private float _rnd; //Field offset: 0x8C
	private float nextCheckSpeedPeriod; //Field offset: 0x90
	private Color _lastColor; //Field offset: 0x94

	public FollowerOneByOne(BotOwner owner) { }

	public virtual void Activate() { }

	public virtual void Dispose() { }

	private void GoTo(Vector3 v) { }

	protected override void LookDirectionUpdate() { }

	private void LookDiriction() { }

	private void LookFront() { }

	private void LookLeft() { }

	private void LookRight() { }

	protected override void ObserveUpdate() { }

	private void OnStatusChanged(PatrolStatus obj) { }

	private void PeriodRdnAng() { }

	public virtual bool SetTarget(FollowerPatrolTargetStruct trg, Nullable lookSide) { }

	public virtual void Update() { }

}

