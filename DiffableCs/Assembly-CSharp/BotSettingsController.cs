//Type is in global namespace

public class BotSettingsController : Singleton
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public WildSpawnType role; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_1
	{
		public BotDifficulty difficulty; //Field offset: 0x10
		public <>c__DisplayClass3_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass3_1() { }

		internal bool <SetSettings>b__0(BotPreset x) { }

	}

	public BotLocationModifier BotLocationModifier; //Field offset: 0x10
	public BotCurvSettings _CurvSettings; //Field offset: 0x18
	private readonly TwoDimensionalDictionary SettingsExample; //Field offset: 0x20

	public BotSettingsController() { }

	public BotSettings GetSettings(BotDifficulty difficulty, WildSpawnType role, bool isPve) { }

	public void SetSettings(BotPreset[] botPresets, BotWeaponScattering[] botScatterings, BotLocationModifier botLocationModifier, bool isPve) { }

}

