//Type is in global namespace

public class ShootReservWay : AReserveWayAction
{
	public List TargetToShoot; //Field offset: 0x30
	public float StayPeriod; //Field offset: 0x38
	public float ShootPeriod; //Field offset: 0x3C
	private float _nextChangeTime; //Field offset: 0x40
	private bool _atPlace; //Field offset: 0x44
	private bool _isShootingSNow; //Field offset: 0x45
	private Vector3 _curSelectedTarget; //Field offset: 0x48

	public virtual Vector3 GoTo
	{
		 get { } //Length: 204
	}

	public virtual Vector3 LookShootTo
	{
		 get { } //Length: 19
	}

	public ShootReservWay() { }

	public virtual void AutoFix() { }

	public virtual void ComeTo(BotOwner bot) { }

	public virtual void DrawGizmos() { }

	public virtual Vector3 get_GoTo() { }

	public virtual Vector3 get_LookShootTo() { }

	public virtual EReserveWayResult ManualUpdate(BotOwner bot) { }

	public virtual void RefreshBot() { }

	public virtual void RefreshData() { }

}

