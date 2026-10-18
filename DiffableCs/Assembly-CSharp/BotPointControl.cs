//Type is in global namespace

public class BotPointControl : BotData
{
	public PatrolWay Way; //Field offset: 0x18
	public PatrolPointContainer _reservedPatrolPoint; //Field offset: 0x20
	private Action _onChangeWay; //Field offset: 0x28
	private Action _onPointSet; //Field offset: 0x30
	private PatrolPoint _lastSetOwner; //Field offset: 0x38
	[CompilerGenerated]
	private Action OnTargetPatrolPointSetted; //Field offset: 0x40
	[CompilerGenerated]
	private PatrolPointContainer <PatrolPoint>k__BackingField; //Field offset: 0x48

	public event Action OnTargetPatrolPointSetted
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public private PatrolPointContainer PatrolPoint
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public BotPointControl(BotOwner owner) { }

	[CompilerGenerated]
	public void add_OnTargetPatrolPointSetted(Action value) { }

	private void CheckOwnerId() { }

	public void Dispose() { }

	[CompilerGenerated]
	public PatrolPointContainer get_PatrolPoint() { }

	public PatrolPointContainer GetPreferableNext() { }

	[CompilerGenerated]
	public void remove_OnTargetPatrolPointSetted(Action value) { }

	[CompilerGenerated]
	private void set_PatrolPoint(PatrolPointContainer value) { }

	private void SetPatrolPoint(PatrolPointContainer p, int index = -1) { }

	private void SetPatrolPointOwner(PatrolPoint point) { }

	public void SetPointSetter(Action pointSetted) { }

	public void SetReservedPatrolPoint(PatrolPointContainer p, int index = -1) { }

	public void SetTarget(PatrolPointContainer point, int index = -1) { }

	public void SetWay(PatrolWay way, FindNextPointDelegate findPointAction, Action findPointForFollower = null) { }

	public void SetWayChanged(Action wayChanged) { }

}

