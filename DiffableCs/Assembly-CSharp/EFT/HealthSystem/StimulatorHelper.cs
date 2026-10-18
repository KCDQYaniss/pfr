namespace EFT.HealthSystem;

[Extension]
public static class StimulatorHelper
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__0_0; //Field offset: 0x8
		public static Func <>9__0_1; //Field offset: 0x10
		public static Func <>9__0_2; //Field offset: 0x18
		public static Func <>9__0_3; //Field offset: 0x20
		public static Func <>9__8_0; //Field offset: 0x28
		public static Func <>9__9_0; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal bool <ActiveBuffs>b__8_0(IStimulatorBuff b) { }

		internal bool <ActiveDebuffs>b__9_0(IStimulatorBuff b) { }

		internal bool <GetDisplayableVariations>b__0_0(IStimulatorBuff x) { }

		internal BuffDescription <GetDisplayableVariations>b__0_1(IStimulatorBuff x) { }

		internal bool <GetDisplayableVariations>b__0_2(IStimulatorBuff x) { }

		internal BuffDescription <GetDisplayableVariations>b__0_3(IStimulatorBuff x) { }

	}


	public static IStimulatorBuff[] ActiveBuffs(IStimulatorBuff[] effects) { }

	public static IStimulatorBuff[] ActiveDebuffs(IStimulatorBuff[] effects) { }

	[Extension]
	public static string BuffAbsoluteStringValue(StimulatorBuffSettings buffSettings) { }

	[Extension]
	public static string BuffColoredStringValue(StimulatorBuffSettings buffSettings) { }

	[Extension]
	public static string BuffName(StimulatorBuffSettings buffSettings) { }

	[Extension]
	public static Type BuffType(StimulatorBuffSettings buffSettings) { }

	public static EffectDescription[] GetDisplayableVariations(IStimulator stimulator) { }

	private static float GetVisualBuffValue(StimulatorBuffSettings buffSettings) { }

	[Extension]
	public static bool IsBuff(EStimulatorBuffType type, float value) { }

	[Extension]
	public static string UnitsName(StimulatorBuffSettings buffSettings) { }

}

