namespace EFT.Game.Spawning;

[IsReadOnly]
public struct SpawnSystemSettings
{
	public const float DEFAULT_SPHERE_COLLIDER_RADIUS = 10; //Field offset: 0x0
	public const float MIN_MAX_DIST_TO_ENEMY_BY_GROUP_SQR = 2500; //Field offset: 0x0
	public const int SPAWN_SAFE_DISTANCE_METERS = 100; //Field offset: 0x0
	private const float MIN_POSSIBLE_DIST_FREE_POINTS = 50; //Field offset: 0x0
	private const float MAX_POSSIBLE_DIST_FREE_POINTS = 350; //Field offset: 0x0
	public const float DELAY_TO_CAN_SPAWN_SEC = 4; //Field offset: 0x0
	public const float DELAY_TO_PLAYER_CAN_SPAWN_SEC = 15; //Field offset: 0x0
	public const float DELAY_TO_NON_PLAYER_CAN_SPAWN_SEC = 10; //Field offset: 0x0
	[CompilerGenerated]
	private readonly float <MinPossibleDistFreePointsSqr>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly float <MaxPossibleDistFreePointsSqr>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	private readonly float <MaxBotPerZone>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private readonly int <SpawnSafeDistanceSqr>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private readonly bool <NoGroupSpawn>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly bool <OneTimeSpawn>k__BackingField; //Field offset: 0x11

	public float MaxBotPerZone
	{
		[CompilerGenerated]
		 get { } //Length: 6
	}

	public float MaxPossibleDistFreePointsSqr
	{
		[CompilerGenerated]
		 get { } //Length: 6
	}

	public float MinPossibleDistFreePointsSqr
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool NoGroupSpawn
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool OneTimeSpawn
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public int SpawnSafeDistanceSqr
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public SpawnSystemSettings(float minPossibleDistFreePoints, float maxPossibleDistFreePoints, int maxBotPerZone, int spawnSafeDistance, bool noGroupSpawn, bool oneTimeSpawn) { }

	public static SpawnSystemSettings CreateDefault() { }

	[CompilerGenerated]
	public float get_MaxBotPerZone() { }

	[CompilerGenerated]
	public float get_MaxPossibleDistFreePointsSqr() { }

	[CompilerGenerated]
	public float get_MinPossibleDistFreePointsSqr() { }

	[CompilerGenerated]
	public bool get_NoGroupSpawn() { }

	[CompilerGenerated]
	public bool get_OneTimeSpawn() { }

	[CompilerGenerated]
	public int get_SpawnSafeDistanceSqr() { }

}

