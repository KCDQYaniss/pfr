namespace EFT.Game.Spawning;

public sealed class SpawnPointsCollection : ISpawnPointsCollection, IReadOnlyCollection, IEnumerable, IEnumerable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__12_0; //Field offset: 0x8
		public static Func <>9__12_1; //Field offset: 0x10
		public static Func <>9__14_0; //Field offset: 0x18
		public static Func <>9__14_2; //Field offset: 0x20
		public static Predicate <>9__15_0; //Field offset: 0x28
		public static Func <>9__16_0; //Field offset: 0x30
		public static Func <>9__16_1; //Field offset: 0x38

		private static <>c() { }

		public <>c() { }

		internal bool <CalculateCanSpawnPmcBots>b__16_0(SpawnPointMarker marker) { }

		internal bool <CalculateCanSpawnPmcBots>b__16_1(SpawnPointMarker marker) { }

		internal bool <ClearBotZonesSpawnMakers>b__15_0(SpawnPointMarker marker) { }

		internal ISpawnPoint <CreateFromScene>b__12_0(SpawnPointMarker marker) { }

		internal SpawnPointMarker <CreateFromScene>b__12_1(SpawnPointMarker marker) { }

		internal string <FixSpawns>b__14_0(SpawnPointParams prm) { }

		internal string <FixSpawns>b__14_2(SpawnPointMarker marker) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public string[] ids; //Field offset: 0x10

		public <>c__DisplayClass14_0() { }

		internal bool <FixSpawns>b__1(SpawnPointMarker marker) { }

		internal bool <FixSpawns>b__3(SpawnPointParams prm) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_1
	{
		public string markerId; //Field offset: 0x10

		public <>c__DisplayClass14_1() { }

		internal bool <FixSpawns>b__4(SpawnPointParams p) { }

	}

	private sealed class Logger : AbstractLogger
	{

		internal Logger() { }

	}

	private readonly Dictionary _dictionary; //Field offset: 0x10
	private readonly Logger _logger; //Field offset: 0x18

	public override int Count
	{
		 get { } //Length: 68
	}

	private SpawnPointsCollection(Dictionary dictionary, Logger logger) { }

	private static void CalculateCanSpawnPmcBots(BotZone[] zones) { }

	private static void ClearBotZonesSpawnMakers(BotZone[] zones) { }

	[NotNull]
	public static SpawnPointsCollection CreateFromScene(Nullable locationExportDateTime = null, SpawnPointParams[] parameters = null) { }

	private override ISpawnPoint EFT.Game.Spawning.ISpawnPointsCollection.CreateSpawnPoint(SpawnPointParams params) { }

	private override void EFT.Game.Spawning.ISpawnPointsCollection.DestroySpawnPoint(ISpawnPoint spawnPoint) { }

	private override bool EFT.Game.Spawning.ISpawnPointsCollection.TryGetSpawnPointById(string id, out ISpawnPoint spawnPoint) { }

	[NotNull]
	private static SpawnPointMarker[] FixSpawns(AbstractLogger logger, SpawnPointMarker[] markers, BotZone[] zones, SpawnPointParams[] parameters) { }

	public override int get_Count() { }

	public override IEnumerator GetEnumerator() { }

	private static bool IsValid(AbstractLogger logger, Nullable locationDateTime) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public override void Validate() { }

}

