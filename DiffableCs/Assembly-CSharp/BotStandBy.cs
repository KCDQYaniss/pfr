//Type is in global namespace

public class BotStandBy : BotData
{
	private float DIST_TO_SLEEP; //Field offset: 0x18
	private float DIST_TO_ACTIVATE; //Field offset: 0x1C
	private readonly float MIN_TIME_AFTER_HIT; //Field offset: 0x20
	private float _nextCheckTime; //Field offset: 0x24
	private float _nextTimePosibleGoTo; //Field offset: 0x28
	private BotStandByType standByType; //Field offset: 0x2C
	private Nullable _curPoint; //Field offset: 0x30
	[CompilerGenerated]
	private bool <CanDoStandBy>k__BackingField; //Field offset: 0x40

	public bool CanDoStandBy
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public private BotStandByType StandByType
	{
		 get { } //Length: 4
		private set { } //Length: 66
	}

	public BotStandBy(BotOwner owner) { }

	public void Activate() { }

	public void DebugActivate(bool val) { }

	public string DistancesInfo() { }

	private void DoStay() { }

	[CompilerGenerated]
	public bool get_CanDoStandBy() { }

	public BotStandByType get_StandByType() { }

	public void GetHit() { }

	public void InitPoints(float distToActivate, float distToSleep) { }

	private void Pause() { }

	[CompilerGenerated]
	public void set_CanDoStandBy(bool value) { }

	private void set_StandByType(BotStandByType value) { }

	public void Update() { }

	public void UpdateNode() { }

}

