//Type is in global namespace

public class BotsPairData
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		public IPlayer person; //Field offset: 0x10
		public BotsGroup botGroup; //Field offset: 0x18

		public <>c__DisplayClass44_0() { }

		internal void <AddBotToEnemies>b__0() { }

	}

	public float _nextUpdateTime; //Field offset: 0x10
	private readonly bool _canBecomeEnemy; //Field offset: 0x14
	[CompilerGenerated]
	private Action OnPairDataStops; //Field offset: 0x18
	[CompilerGenerated]
	private float <EndTime>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly IPlayer <Person1>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly IPlayer <Person2>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private float <Dist>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private Vector3 <Dir>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private EBotPairActionType <ActionType>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private bool <CanInteract>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private bool <ShallStop>k__BackingField; //Field offset: 0x4D

	public event Action OnPairDataStops
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public private EBotPairActionType ActionType
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool CanInteract
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private Vector3 Dir
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public private float Dist
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private float EndTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public IPlayer Person1
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public IPlayer Person2
	{
		[CompilerGenerated]
		 get { } //Length: 76
	}

	public private bool ShallStop
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public BotsPairData(IPlayer person1, IPlayer person2) { }

	[CompilerGenerated]
	public void add_OnPairDataStops(Action value) { }

	private void AddBotToEnemies(BotOwner bot, IPlayer person) { }

	public bool AllAlive() { }

	public bool CanDoSign() { }

	private void CheckIsBossAndFollower(BotOwner bot1, BotOwner bot2) { }

	private void DoEnemy() { }

	[CompilerGenerated]
	public EBotPairActionType get_ActionType() { }

	[CompilerGenerated]
	public bool get_CanInteract() { }

	[CompilerGenerated]
	public Vector3 get_Dir() { }

	[CompilerGenerated]
	public float get_Dist() { }

	[CompilerGenerated]
	public float get_EndTime() { }

	[CompilerGenerated]
	public IPlayer get_Person1() { }

	[CompilerGenerated]
	public IPlayer get_Person2() { }

	[CompilerGenerated]
	public bool get_ShallStop() { }

	public IPlayer GetAnother(IPlayer gamePerson) { }

	public void ManualUpdate() { }

	[CompilerGenerated]
	public void remove_OnPairDataStops(Action value) { }

	[CompilerGenerated]
	private void set_ActionType(EBotPairActionType value) { }

	[CompilerGenerated]
	private void set_CanInteract(bool value) { }

	[CompilerGenerated]
	private void set_Dir(Vector3 value) { }

	[CompilerGenerated]
	private void set_Dist(float value) { }

	[CompilerGenerated]
	private void set_EndTime(float value) { }

	[CompilerGenerated]
	private void set_ShallStop(bool value) { }

	public void SetAction(EBotPairActionType clap, float length, bool shallStop) { }

	public void StopPosibleInteractions() { }

	private void UpdateDist() { }

}

