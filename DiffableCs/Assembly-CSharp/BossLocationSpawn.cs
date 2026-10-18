//Type is in global namespace

public class BossLocationSpawn
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass80_0
	{
		public Vector3 closestsPos; //Field offset: 0x10

		public <>c__DisplayClass80_0() { }

		internal int <GetPossibleZones>g__DistToPoint|0(BotZone x, BotZone y) { }

	}

	private const string OriginSplnr = "SPLNR"; //Field offset: 0x0
	private const string OriginPpdst = "PPDST"; //Field offset: 0x0
	private const string OriginPpfnr = "PPFNR"; //Field offset: 0x0
	private const string OriginPpfnm = "PPFNM"; //Field offset: 0x0
	private const float MIN_KARMA_TO_RECALC = 0.5; //Field offset: 0x0
	private const string OriginSplsh = "SPLSH"; //Field offset: 0x0
	private const string OriginSpldb = "SPLDB"; //Field offset: 0x0
	private const string OriginSplnm = "SPLNM"; //Field offset: 0x0
	public string BossName; //Field offset: 0x10
	public float BossChance; //Field offset: 0x18
	public string BossZone; //Field offset: 0x20
	public bool BossPlayer; //Field offset: 0x28
	public string BossDifficult; //Field offset: 0x30
	public string BossEscortDifficult; //Field offset: 0x38
	public string BossEscortType; //Field offset: 0x40
	public string BossEscortAmount; //Field offset: 0x48
	public float Time; //Field offset: 0x50
	public float Delay; //Field offset: 0x54
	public string TriggerId; //Field offset: 0x58
	public string TriggerName; //Field offset: 0x60
	public bool IgnoreMaxBots; //Field offset: 0x68
	public bool ForceSpawn; //Field offset: 0x69
	public bool DependKarma; //Field offset: 0x6A
	public Nullable PerfectPos; //Field offset: 0x6C
	public WildSpawnSupports[] Supports; //Field offset: 0x80
	public bool ShowOnTarkovMap; //Field offset: 0x88
	public bool ShowOnTarkovMapPvE; //Field offset: 0x89
	private List _subDatas; //Field offset: 0x90
	private List _possibleShuffledZones; //Field offset: 0x98
	[CompilerGenerated]
	private WildSpawnType <BossType>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private WildSpawnType <EscortType>k__BackingField; //Field offset: 0xA4
	[CompilerGenerated]
	private int <EscortCount>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private string <BornZone>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private bool <ShallSpawn>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private BotDifficulty <BossDif>k__BackingField; //Field offset: 0xBC
	[CompilerGenerated]
	private BotDifficulty <EscortDif>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private SpawnTriggerType <TriggerType>k__BackingField; //Field offset: 0xC4
	[CompilerGenerated]
	private bool <Activated>k__BackingField; //Field offset: 0xC8

	public bool Activated
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public string BornZone
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private BotDifficulty BossDif
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private WildSpawnType BossType
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private int EscortCount
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private BotDifficulty EscortDif
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private WildSpawnType EscortType
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public IReadOnlyList PossibleShuffledZones
	{
		 get { } //Length: 8
	}

	public private bool ShallSpawn
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private SpawnTriggerType TriggerType
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public BossLocationSpawn() { }

	public void CalculateChance() { }

	public void ClearPossibleZones() { }

	public BossLocationSpawn Copy() { }

	public string DebugInfo() { }

	private void FindZoneWithCorrectName(BotZone[] allZones, List markedBossZone, string fillOriginMatch, string fillOriginMissRandom) { }

	[CompilerGenerated]
	public bool get_Activated() { }

	[CompilerGenerated]
	public string get_BornZone() { }

	[CompilerGenerated]
	public BotDifficulty get_BossDif() { }

	[CompilerGenerated]
	public WildSpawnType get_BossType() { }

	[CompilerGenerated]
	public int get_EscortCount() { }

	[CompilerGenerated]
	public BotDifficulty get_EscortDif() { }

	[CompilerGenerated]
	public WildSpawnType get_EscortType() { }

	public IReadOnlyList get_PossibleShuffledZones() { }

	[CompilerGenerated]
	public bool get_ShallSpawn() { }

	[CompilerGenerated]
	public SpawnTriggerType get_TriggerType() { }

	public List GetEscors() { }

	public List GetPossibleZones(BotZone[] allZones, List markedBossZone) { }

	public List GetPossibleZones(BotZone[] allZones, List markedBossZone, Vector3 closestsPos) { }

	public List GetUsingTypes() { }

	public void Init() { }

	public bool IsStartWave() { }

	private void LogPossibleShuffledZonesFilled(string fillOrigin, int candidateZonesCount, Nullable distanceSortPos = null) { }

	private void ParseBossName() { }

	private void ParseDifficulty() { }

	private void ParseEscortDif() { }

	private void ParseExcortType() { }

	public void ParseMainTypesTypes() { }

	private void ParseTriggerName() { }

	[CompilerGenerated]
	public void set_Activated(bool value) { }

	[CompilerGenerated]
	public void set_BornZone(string value) { }

	[CompilerGenerated]
	private void set_BossDif(BotDifficulty value) { }

	[CompilerGenerated]
	private void set_BossType(WildSpawnType value) { }

	[CompilerGenerated]
	private void set_EscortCount(int value) { }

	[CompilerGenerated]
	private void set_EscortDif(BotDifficulty value) { }

	[CompilerGenerated]
	private void set_EscortType(WildSpawnType value) { }

	[CompilerGenerated]
	private void set_ShallSpawn(bool value) { }

	[CompilerGenerated]
	private void set_TriggerType(SpawnTriggerType value) { }

	public bool ShouldSpawnByKarma() { }

}

