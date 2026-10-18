namespace EFT.Quests;

public abstract class ConditionalBook`1 : BindableList, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public string id; //Field offset: 0x0

		public <>c__DisplayClass6_0() { }

		internal bool <GetConditional>b__0(TConditional conditional) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public int id; //Field offset: 0x0

		public <>c__DisplayClass7_0() { }

		internal bool <GetConditional>b__0(TConditional conditional) { }

	}

	protected readonly string ProfileId; //Field offset: 0x0
	protected readonly EPlayerSide ProfileSide; //Field offset: 0x0
	protected readonly Dictionary ConditionCounters; //Field offset: 0x0

	protected ConditionalBook`1(string profileId, EPlayerSide profileSide, Dictionary conditionCounters) { }

	public abstract void Dispose() { }

	[CanBeNull]
	public TConditional GetConditional(string id) { }

	[CanBeNull]
	public TConditional GetConditional(int id) { }

	public abstract void LoadAll() { }

	public abstract void RemoveConditionalsWithoutTemplate() { }

	public void ResetNullableConditions() { }

	public void TestConditions(int valueToAdd, ConditionCheck[] checks) { }

	public void TestGroupProgressConditions(int valueToAdd, ConditionCheck[] checks) { }

}

