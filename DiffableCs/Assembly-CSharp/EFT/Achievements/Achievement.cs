namespace EFT.Achievements;

public sealed class Achievement : Conditional
{
	[CompilerGenerated]
	private struct <LoadSprite>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Achievement <>4__this; //Field offset: 0x20
		public IImageLoader session; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static readonly IReadOnlyDictionary _statusTransition; //Field offset: 0x0
	private Dictionary _rewards; //Field offset: 0x58
	[CompilerGenerated]
	private readonly AchievementTemplate <Template>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private readonly AchievementStatusData <StatusData>k__BackingField; //Field offset: 0x68

	public virtual ConditionsDict Conditions
	{
		 get { } //Length: 27
	}

	public virtual string Description
	{
		 get { } //Length: 29
	}

	public virtual bool InstantComplete
	{
		 get { } //Length: 3
	}

	public virtual ETaskPlayerSide PlayerSide
	{
		 get { } //Length: 26
	}

	public virtual bool ReadyToFail
	{
		 get { } //Length: 3
	}

	public virtual Dictionary Rewards
	{
		 get { } //Length: 292
	}

	public virtual bool ServerOnly
	{
		 get { } //Length: 3
	}

	public virtual Sprite Sprite
	{
		 get { } //Length: 27
	}

	public AchievementStatusData StatusData
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual IReadOnlyDictionary StatusTransition
	{
		 get { } //Length: 83
	}

	public AchievementTemplate Template
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private static Achievement() { }

	public Achievement(AchievementTemplate template, AchievementStatusData statusData, Dictionary conditionCounters) { }

	public virtual void CheckForStatusChange(EQuestStatus status, bool notify, bool fromServer, bool canFail, bool recursive = false) { }

	public virtual ConditionsDict get_Conditions() { }

	public virtual string get_Description() { }

	public virtual bool get_InstantComplete() { }

	public virtual ETaskPlayerSide get_PlayerSide() { }

	public virtual bool get_ReadyToFail() { }

	public virtual Dictionary get_Rewards() { }

	public virtual bool get_ServerOnly() { }

	public virtual Sprite get_Sprite() { }

	[CompilerGenerated]
	public AchievementStatusData get_StatusData() { }

	public virtual IReadOnlyDictionary get_StatusTransition() { }

	[CompilerGenerated]
	public AchievementTemplate get_Template() { }

	[AsyncStateMachine(typeof(<LoadSprite>d__29))]
	public virtual Task LoadSprite(IImageLoader session) { }

	public void Reset() { }

	private void ResetConditions() { }

	public virtual void SetStatus(EQuestStatus status, bool notify, bool fromServer) { }

}

