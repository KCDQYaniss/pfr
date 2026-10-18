//Type is in global namespace

public class PatrolPathControl : BotData
{
	private PatrolPointContainer FromPoint; //Field offset: 0x18
	private PatrolPointContainer ToPoint; //Field offset: 0x20
	private Vector3[] _totalWay; //Field offset: 0x28
	private bool _shallRun; //Field offset: 0x30

	public PatrolPathControl(BotOwner owner) { }

	public void Activate() { }

	public void ComeToPoint(PatrolPointContainer point) { }

	public void Dispose() { }

	public NavMeshPathStatus GoToPoint(PatrolPointContainer point) { }

	public void ManualUpdate() { }

	public void RefreshGoToPoint() { }

}

