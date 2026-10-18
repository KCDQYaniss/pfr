//Type is in global namespace

public class GrenadeDangerPoint
{
	public Grenade Grenade; //Field offset: 0x10
	public float StartTime; //Field offset: 0x18
	public float EndTime; //Field offset: 0x1C
	private float _nextCheck; //Field offset: 0x20
	public bool SafePlaceFound; //Field offset: 0x24
	private readonly Vector3 _rndPoint; //Field offset: 0x28
	private readonly BotOwner _owner; //Field offset: 0x38
	private bool _destroyNextFrame; //Field offset: 0x40
	private bool _lastSafeResult; //Field offset: 0x41

	public Vector3 DangerPoint
	{
		 get { } //Length: 898
	}

	public GrenadeDangerPoint(Vector3 point, Grenade grenade, BotOwner owner, float startDelay) { }

	private void Destroy() { }

	public Vector3 get_DangerPoint() { }

	public bool IsActive() { }

	public bool IsCoverSafe(Vector3 posOnFloor) { }

	private void OnBlowUp(Throwable arg3) { }

	public bool ShallDestroy() { }

	public bool ShallRunAway() { }

}

