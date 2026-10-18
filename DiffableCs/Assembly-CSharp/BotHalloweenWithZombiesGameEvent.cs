//Type is in global namespace

public class BotHalloweenWithZombiesGameEvent : BotData
{
	private float _holdPeriod; //Field offset: 0x18
	private float _nextChangePositionTime; //Field offset: 0x1C
	private Vector3 _findPointCenterPosition; //Field offset: 0x20
	private IBotOwner _cachedLeader; //Field offset: 0x30
	[CompilerGenerated]
	private Action OnCallAction; //Field offset: 0x38
	[CompilerGenerated]
	private Action OnReportSeenEnemy; //Field offset: 0x40

	public event Action OnCallAction
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnReportSeenEnemy
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public Vector3 FindPointCenterPosition
	{
		 get { } //Length: 289
	}

	public float HoldPeriod
	{
		 get { } //Length: 27
	}

	public BotHalloweenWithZombiesGameEvent(BotOwner owner) { }

	[CompilerGenerated]
	public void add_OnCallAction(Action value) { }

	[CompilerGenerated]
	public void add_OnReportSeenEnemy(Action value) { }

	public void Call(Vector3 positionToCheck, float callRadiusSqr, BotHalloweenEventPursuit pursuit) { }

	public Vector3 get_FindPointCenterPosition() { }

	public float get_HoldPeriod() { }

	private IBotOwner GetLeader() { }

	[CompilerGenerated]
	public void remove_OnCallAction(Action value) { }

	[CompilerGenerated]
	public void remove_OnReportSeenEnemy(Action value) { }

	public void ReportSeenEnemy(IPlayer target) { }

	public void TryRecalcPatrolParams() { }

}

