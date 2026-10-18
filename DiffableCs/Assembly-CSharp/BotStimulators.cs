//Type is in global namespace

public class BotStimulators : BotAbstractMeds
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public BotStimulators <>4__this; //Field offset: 0x10
		public Action callback; //Field offset: 0x18
		public Callback <>9__1; //Field offset: 0x20

		public <>c__DisplayClass18_0() { }

		internal void <TryApply>b__0(Result hands) { }

		internal void <TryApply>b__1(Result applyResult) { }

	}

	private Stimulator _stimulator; //Field offset: 0x30
	private bool _shallUseInSafe; //Field offset: 0x38
	[CompilerGenerated]
	private bool <HaveSmt>k__BackingField; //Field offset: 0x39
	[CompilerGenerated]
	private float <LastUseTime>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private float <LastEndUseTime>k__BackingField; //Field offset: 0x40

	public private bool HaveSmt
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private float LastEndUseTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private float LastUseTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public BotStimulators(BotOwner owner, Action callback) { }

	public virtual void Activate() { }

	public bool CanUseNow() { }

	private void FindMeds() { }

	[CompilerGenerated]
	public bool get_HaveSmt() { }

	[CompilerGenerated]
	public float get_LastEndUseTime() { }

	[CompilerGenerated]
	public float get_LastUseTime() { }

	public void Refresh() { }

	[CompilerGenerated]
	private void set_HaveSmt(bool value) { }

	[CompilerGenerated]
	private void set_LastEndUseTime(float value) { }

	[CompilerGenerated]
	private void set_LastUseTime(float value) { }

	public void StartApplyToTarget(Action callback = null) { }

	public void TryApply(bool noCheckDelay = false, Nullable animVarian = null, Action callback = null) { }

}

