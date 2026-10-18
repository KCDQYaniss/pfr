//Type is in global namespace

public class UseSurgeKitReservWay : AReserveWayAction
{
	public Transform lookToPoint; //Field offset: 0x30
	public float ChaceToUse100; //Field offset: 0x38
	public float ChaceToSit100; //Field offset: 0x3C
	private bool _shallStartInteract; //Field offset: 0x40
	private EMedsType _curUseType; //Field offset: 0x44
	private bool _shallSit; //Field offset: 0x48
	private float _startTimeInteract; //Field offset: 0x4C
	private readonly List _posibleTypes; //Field offset: 0x50

	public virtual Vector3 GoTo
	{
		 get { } //Length: 204
	}

	public virtual Vector3 LookShootTo
	{
		 get { } //Length: 138
	}

	public UseSurgeKitReservWay() { }

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

