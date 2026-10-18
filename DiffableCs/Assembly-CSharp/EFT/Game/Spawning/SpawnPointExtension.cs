namespace EFT.Game.Spawning;

[Extension]
public static class SpawnPointExtension
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__11_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Vector3 <CenterPosition>b__11_0(Vector3 position, IPlayer groupPlayer) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public Vector3 position; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal float <MinDistanceSqr>b__0(IPlayer player) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public Vector3 position; //Field offset: 0x10
		public float sqrDistance; //Field offset: 0x1C

		public <>c__DisplayClass21_0() { }

		internal bool <FindSpawnPointInPosition>b__0(ISpawnPoint spawnPoint) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public Vector3 groupCenter; //Field offset: 0x10
		public IReadOnlyCollection groupPlayers; //Field offset: 0x20
		public IReadOnlyCollection noneGroupPlayers; //Field offset: 0x28

		public <>c__DisplayClass22_0() { }

		internal float <FindGroupSpawnPoint>b__0(ISpawnPoint spawnPoint) { }

		internal bool <FindGroupSpawnPoint>b__1(ISpawnPoint spawnPoint) { }

		internal bool <FindGroupSpawnPoint>b__2(ISpawnPoint spawnPoint) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public ISpawnPoint spawnPoint; //Field offset: 0x10
		public List collidedList; //Field offset: 0x18

		public <>c__DisplayClass6_0() { }

		internal bool <Collided>b__0(IPlayer person) { }

	}


	[Extension]
	public static Vector3 CenterPosition(IReadOnlyCollection players) { }

	[CanBeNull]
	[Extension]
	public static IEnumerable Collided(ISpawnPoint spawnPoint, IReadOnlyCollection persons, out List collidedIds) { }

	[CanBeNull]
	[Extension]
	internal static ISpawnPoint FarthestFromPlayers(IReadOnlyList spawnPoints, IReadOnlyCollection players, SpawnSystemDebugCollector debugCollector, Logger logger = null) { }

	[CanBeNull]
	[Extension]
	internal static ISpawnPoint FarthestFromPlayersOnDistanceWithRandom(IReadOnlyList spawnPoints, IReadOnlyCollection players, int sqrSafeDistanceMeters, Logger logger = null) { }

	[CanBeNull]
	[Extension]
	internal static ISpawnPoint FindGroupSpawnPoint(IReadOnlyCollection spawnPoints, IReadOnlyCollection groupPlayers, IReadOnlyCollection noneGroupPlayers, Logger logger = null) { }

	[CanBeNull]
	[Extension]
	public static ISpawnPoint FindSpawnPointInPosition(IEnumerable spawnPoints, Vector3 position, float sqrDistance = 0.25) { }

	[Extension]
	public static bool IsCollided(ISpawnPoint spawnPoint, IReadOnlyCollection persons, out List collidedIds) { }

	[Extension]
	public static bool IsNotCollided(ISpawnPoint spawnPoint, IReadOnlyCollection persons, out List collidedIds) { }

	[Extension]
	public static bool IsOccupied(ISpawnPoint spawnPoint, IReadOnlyCollection persons, float sqrDistance = 1) { }

	[Extension]
	public static bool IsValid(ISpawnPoint spawnPoint, float time) { }

	[Extension]
	public static bool IsValid(ISpawnPoint spawnPoint, EPlayerSideMask sideMask) { }

	[Extension]
	public static bool IsValid(ISpawnPoint spawnPoint, ESpawnCategoryMask side) { }

	[Extension]
	public static bool IsValid(ISpawnPoint spawnPoint, EPlayerSide side) { }

	[Extension]
	public static bool IsValid(ISpawnPoint spawnPoint, Nullable side) { }

	[Extension]
	public static bool IsValid(ISpawnPoint spawnPoint, IReadOnlyCollection players, float distanceSqr, SpawnSystemDebugCollector debugCollector) { }

	[Extension]
	public static float MinDistanceSqr(Vector3 position, IReadOnlyCollection players) { }

	[Extension]
	public static float MinDistanceSqr(ISpawnPoint spawnPoint, IReadOnlyCollection players) { }

	[Extension]
	public static bool NotOccupied(ISpawnPoint spawnPoint, IReadOnlyCollection persons, float sqrDistance = 1) { }

	[Extension]
	public static void SetUse(ISpawnPoint spawnPoint, float time, bool isPlayer = false, BotCreationData creationData = null) { }

	[Extension]
	public static bool Сontains(ISpawnPoint spawnPoint, string[] spawnPointsFilter) { }

	[Extension]
	public static bool Сontains(ISpawnPoint spawnPoint, string infiltration = null) { }

	[Extension]
	public static bool Сontains(ISpawnPoint spawnPoint, EPlayerSide side) { }

	[Extension]
	public static bool Сontains(ISpawnPoint spawnPoint, ESpawnCategory category) { }

}

