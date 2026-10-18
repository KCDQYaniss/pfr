//Type is in global namespace

public class AIPlaceTerminalWavesController : AIPlaceInfo
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__12_0; //Field offset: 0x8
		public static Func <>9__13_0; //Field offset: 0x10
		public static Func <>9__13_1; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <AutoFillBlockOnFirstStage>b__13_0(BotZone z) { }

		internal int <AutoFillBlockOnFirstStage>b__13_1(KeyValuePair k) { }

		internal bool <AutoFillMigrateData>b__12_0(BotZone z) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Action <0>__OnBotActivated; //Field offset: 0x0

	}

	private static readonly Regex ZoneIndexRegex; //Field offset: 0x0
	public List BlockOnFirstStage; //Field offset: 0x88
	public List MigrateData; //Field offset: 0x90
	public List StagesData; //Field offset: 0x98
	public bool DoAssaultForceAttack; //Field offset: 0xA0
	public List UnblocksKeys; //Field offset: 0xA8

	private static AIPlaceTerminalWavesController() { }

	public AIPlaceTerminalWavesController() { }

	public int AutoFillBlockOnFirstStage() { }

	public int AutoFillMigrateData() { }

	private static string DetectFaction(string zoneName) { }

	public virtual void EditorCheck() { }

	private static string GetTargetFactionForMigration(string sourceFaction) { }

	protected virtual void InnerInit() { }

	private static void OnBotActivated(BotOwner owner) { }

	protected virtual void OnDestroyInner() { }

	private static bool TryGetZoneIndex(string zoneName, out int index) { }

}

