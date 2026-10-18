//Type is in global namespace

public class BotZone : MonoBehaviour, IBotZone
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__28_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal ISpawnPoint <get_SpawnPoints>b__28_0(SpawnPointMarker marker) { }

	}

	public const int NORMAL_BOT_COUNT = 10; //Field offset: 0x0
	private const int NORMAL_SNIPERS_COUNT_PER_ZONE = 2; //Field offset: 0x0
	[FormerlySerializedAs("DistanceCoef")]
	public float _distanceCoef; //Field offset: 0x20
	public int Id; //Field offset: 0x24
	[FormerlySerializedAs("MaxPersons")]
	[SerializeField]
	private int _maxPersons; //Field offset: 0x28
	public bool CanSpawnBoss; //Field offset: 0x2C
	public bool SnipeZone; //Field offset: 0x2D
	[CompilerGenerated]
	private Vector3 <CenterOfSpawnPoints>k__BackingField; //Field offset: 0x30
	[FormerlySerializedAs("PatrolWays")]
	[SerializeField]
	private PatrolWay[] _patrolWays; //Field offset: 0x40
	[FormerlySerializedAs("SpawnPointMarkers")]
	[SerializeField]
	private List _spawnPointMarkers; //Field offset: 0x48
	[FormerlySerializedAs("SpawnPointMarkers")]
	[SerializeField]
	private UnspawnPoint[] _unSpawnPoints; //Field offset: 0x50
	private ISpawnPoint[] _spawnPoints; //Field offset: 0x58
	[HideInInspector]
	public bool HasPmcBotSpawns; //Field offset: 0x60
	[HideInInspector]
	public bool HasSeason01BotSpawns; //Field offset: 0x61
	[CompilerGenerated]
	private BotLocationModifier <Modifier>k__BackingField; //Field offset: 0x68
	private BotsController _botsController; //Field offset: 0x70
	public BotZoneNavMeshCutter ZoneNavMeshCutters; //Field offset: 0x78
	[CompilerGenerated]
	private BotZoneDangerAreas <ZoneDangerAreas>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private string <ShortName>k__BackingField; //Field offset: 0x88
	[HideInInspector]
	public string CoverPointCreatorPresetName; //Field offset: 0x90

	public private Vector3 CenterOfSpawnPoints
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public override float DistanceCoef
	{
		 get { } //Length: 6
	}

	public override int MaxPersons
	{
		 get { } //Length: 4
	}

	public private override BotLocationModifier Modifier
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override string NameZone
	{
		 get { } //Length: 7
	}

	public override PatrolWay[] PatrolWays
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public private override string ShortName
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override List SpawnPointMarkers
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public override ISpawnPoint[] SpawnPoints
	{
		 get { } //Length: 586
	}

	public override UnspawnPoint[] UnSpawnPoints
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public private override BotZoneDangerAreas ZoneDangerAreas
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public BotZone() { }

	private void Awake() { }

	private void CheckColliderAndOff(GameObject obj) { }

	public void ClearPools() { }

	[CompilerGenerated]
	public Vector3 get_CenterOfSpawnPoints() { }

	public override float get_DistanceCoef() { }

	public override int get_MaxPersons() { }

	[CompilerGenerated]
	public override BotLocationModifier get_Modifier() { }

	public override string get_NameZone() { }

	public override PatrolWay[] get_PatrolWays() { }

	[CompilerGenerated]
	public override string get_ShortName() { }

	public override List get_SpawnPointMarkers() { }

	public override ISpawnPoint[] get_SpawnPoints() { }

	public override UnspawnPoint[] get_UnSpawnPoints() { }

	[CompilerGenerated]
	public override BotZoneDangerAreas get_ZoneDangerAreas() { }

	public bool HaveFreeSpace(int requestedCount) { }

	private override string IBotZone.get_name() { }

	public void Init(BotLocationModifier modifier, BotsController botsController) { }

	private static bool IsOnNavMesh(Vector3 position) { }

	public bool IsValid() { }

	private void OffAllColliders() { }

	public void OnDrawGizmosSelected() { }

	[CompilerGenerated]
	private void set_CenterOfSpawnPoints(Vector3 value) { }

	[CompilerGenerated]
	private void set_Modifier(BotLocationModifier value) { }

	public void set_PatrolWays(PatrolWay[] value) { }

	[CompilerGenerated]
	private void set_ShortName(string value) { }

	public void set_SpawnPointMarkers(List value) { }

	public void set_UnSpawnPoints(UnspawnPoint[] value) { }

	[CompilerGenerated]
	private void set_ZoneDangerAreas(BotZoneDangerAreas value) { }

}

