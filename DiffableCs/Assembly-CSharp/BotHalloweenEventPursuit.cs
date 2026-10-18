//Type is in global namespace

public class BotHalloweenEventPursuit
{
	private readonly IPlayer _curTarget; //Field offset: 0x10
	private IPlayer _zombieCaller; //Field offset: 0x18
	private List _connectedZombies; //Field offset: 0x20
	private AIPeriodAction _checkTargetOnVisual; //Field offset: 0x28
	private Action _onStop; //Field offset: 0x30
	private float callRadius; //Field offset: 0x38
	private BotHalloween2024 _halloweenParams; //Field offset: 0x40
	private bool _allowSpawnByTarget; //Field offset: 0x48
	[CompilerGenerated]
	private bool <Disposed>k__BackingField; //Field offset: 0x49

	private float callDr
	{
		private get { } //Length: 28
	}

	public Vector3 CallerPosition
	{
		 get { } //Length: 113
	}

	public Vector3 CurPosition
	{
		 get { } //Length: 113
	}

	public private bool Disposed
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private float MaxCallRadius
	{
		private get { } //Length: 28
	}

	public IPlayer Target
	{
		 get { } //Length: 5
	}

	public bool TargetAllowToSpawnCrowd
	{
		 get { } //Length: 5
	}

	public Vector3 TargetLastSeenPosition
	{
		 get { } //Length: 334
	}

	public BotHalloweenEventPursuit(IPlayer curTarget, BotOwner zombieCaller, Action OnStop, BotHalloween2024 halloweenParams) { }

	public void AddZombie(BotOwner bot) { }

	private bool AllowSpawnByTarget(IPlayer trg) { }

	private void CheckOnVisual() { }

	public bool Contains(IPlayer bot) { }

	private void Dispose() { }

	public void FindNextCallerOrDisposePursuit(IPlayer obj) { }

	private float get_callDr() { }

	public Vector3 get_CallerPosition() { }

	public Vector3 get_CurPosition() { }

	[CompilerGenerated]
	public bool get_Disposed() { }

	private float get_MaxCallRadius() { }

	public IPlayer get_Target() { }

	public bool get_TargetAllowToSpawnCrowd() { }

	public Vector3 get_TargetLastSeenPosition() { }

	public void ManualUpdate() { }

	private void OnBotPlayerDeadOrUnspawn(IPlayer obj) { }

	private void OnIPlayerDeadOrUnspawn(IPlayer obj) { }

	public bool ReadyToSpawn() { }

	[CompilerGenerated]
	private void set_Disposed(bool value) { }

	private bool TryFindNext() { }

}

