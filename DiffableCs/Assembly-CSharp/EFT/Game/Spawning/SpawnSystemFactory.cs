namespace EFT.Game.Spawning;

public static class SpawnSystemFactory
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__2_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal float <CreateSpawnSystem>b__2_0() { }

	}


	[NotNull]
	public static ISpawnSystem CreateSpawnSystem(SpawnSystemSettings settings, Func time, IPlayersCollection players, IBotZoneCollection zones, ISpawnPointsCollection spawnPoints) { }

	[NotNull]
	public static ISpawnSystem CreateSpawnSystem(Func time, IPlayersCollection players, IBotZoneCollection zones, ISpawnPointsCollection spawnPoints) { }

	[NotNull]
	public static ISpawnSystem CreateSpawnSystem(IPlayersCollection players, IBotZoneCollection zones, ISpawnPointsCollection spawnPoints) { }

}

