//Type is in global namespace

public class DropItemReservWay : AReserveWayAction
{
	public Transform lookToPoint; //Field offset: 0x30
	private readonly bool ShallLoot; //Field offset: 0x38
	private bool _shallStartInteract; //Field offset: 0x39
	private float _startTimeInteract; //Field offset: 0x3C

	public virtual Vector3 GoTo
	{
		 get { } //Length: 204
	}

	public virtual Vector3 LookShootTo
	{
		 get { } //Length: 138
	}

	public DropItemReservWay() { }

	public virtual void AutoFix() { }

	public virtual void ComeTo(BotOwner bot) { }

	public virtual void DrawGizmos() { }

	public virtual Vector3 get_GoTo() { }

	public virtual Vector3 get_LookShootTo() { }

	public virtual EReserveWayResult ManualUpdate(BotOwner bot) { }

	public virtual void RefreshBot() { }

	public virtual void RefreshData() { }

	public virtual float TimeToUse(BotOwner owner) { }

}

