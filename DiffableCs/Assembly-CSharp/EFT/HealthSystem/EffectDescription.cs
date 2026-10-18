namespace EFT.HealthSystem;

public sealed class EffectDescription
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public IHealthEffect effect; //Field offset: 0x10

		public <>c__DisplayClass17_0() { }

		internal float <.ctor>b__0() { }

		internal EEffectState <.ctor>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public IStimulator stimulator; //Field offset: 0x10

		public <>c__DisplayClass18_0() { }

		internal float <.ctor>b__0() { }

		internal EEffectState <.ctor>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public BuffDescription description; //Field offset: 0x10

		public <>c__DisplayClass19_0() { }

		internal bool <Add>b__0(SimpleBuffDescription x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public string name; //Field offset: 0x10

		public <>c__DisplayClass21_0() { }

		internal bool <Remove>b__0(SimpleBuffDescription x) { }

	}

	internal enum EBuffType
	{
		Regular = 0,
		Stackable = 1,
		Stimulant = 2,
	}

	public Type Type; //Field offset: 0x10
	public List Buffs; //Field offset: 0x18
	public float OverallDuration; //Field offset: 0x20
	public Func WholeTime; //Field offset: 0x28
	public Func EffectState; //Field offset: 0x30
	public EBuffType BuffType; //Field offset: 0x38
	public bool ExactTime; //Field offset: 0x3C
	public Type[] HiddenByOtherEffectsAllOverBodyPart; //Field offset: 0x40
	[CompilerGenerated]
	private readonly bool <Critical>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private Action OnBuffsUpdated; //Field offset: 0x50

	public event Action OnBuffsUpdated
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public bool Critical
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public float TimeLeft
	{
		 get { } //Length: 59
	}

	public EffectDescription(IHealthEffect effect, bool exactTime, List buffs) { }

	public EffectDescription(IStimulator stimulator, Type buffType, List buffs) { }

	public void Add(BuffDescription description) { }

	[CompilerGenerated]
	public void add_OnBuffsUpdated(Action value) { }

	[CompilerGenerated]
	public bool get_Critical() { }

	public float get_TimeLeft() { }

	public void InvokeInternalBuffChange() { }

	public void Remove(string name) { }

	[CompilerGenerated]
	public void remove_OnBuffsUpdated(Action value) { }

	public void Replace(List newBuffs) { }

}

