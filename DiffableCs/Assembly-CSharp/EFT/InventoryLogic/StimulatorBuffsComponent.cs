namespace EFT.InventoryLogic;

public class StimulatorBuffsComponent : ItemComponent
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__6_2; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal EItemAttributeDisplayType <SetupStimulatorBuffsAttributes>b__6_2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public StimulatorBuffSettings buff; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal string <SetupStimulatorBuffsAttributes>b__0() { }

		internal string <SetupStimulatorBuffsAttributes>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_1
	{
		public string name; //Field offset: 0x10
		public <>c__DisplayClass6_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass6_1() { }

		internal string <SetupStimulatorBuffsAttributes>b__3() { }

	}

	private readonly IStimulatorBuffsComponentTemplate _template; //Field offset: 0x18

	protected StimulatorBuffSettings[] BuffSettings
	{
		 get { } //Length: 618
	}

	public string StimulatorBuffs
	{
		 get { } //Length: 75
	}

	protected StimulatorBuffsComponent(Item item, IStimulatorBuffsComponentTemplate template) { }

	protected StimulatorBuffSettings[] get_BuffSettings() { }

	public string get_StimulatorBuffs() { }

	protected void SetupStimulatorBuffsAttributes(Item item) { }

}

