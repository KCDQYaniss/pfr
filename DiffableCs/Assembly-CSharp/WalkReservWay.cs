//Type is in global namespace

public class WalkReservWay : AReserveWayAction
{
	public List PositionsToWalk; //Field offset: 0x30
	private float _nextChangeTime; //Field offset: 0x38
	private float _nextCheckTime; //Field offset: 0x3C
	private Vector3 _targetToGo; //Field offset: 0x40

	public virtual Vector3 GoTo
	{
		 get { } //Length: 19
	}

	public virtual Vector3 LookShootTo
	{
		 get { } //Length: 160
	}

	public WalkReservWay() { }

	public virtual void AutoFix() { }

	public virtual void ComeTo(BotOwner bot) { }

	public virtual void DrawGizmos() { }

	public virtual Vector3 get_GoTo() { }

	public virtual Vector3 get_LookShootTo() { }

	public virtual EReserveWayResult ManualUpdate(BotOwner bot) { }

	public virtual void RefreshBot() { }

	public virtual void RefreshData() { }

	private void StartStay() { }

}

