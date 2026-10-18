//Type is in global namespace

public class DebugBotData : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__81_0; //Field offset: 0x8
		public static Func <>9__81_2; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <ChooseZonesToSpawn>b__81_0(ZoneCount x) { }

		internal int <ChooseZonesToSpawn>b__81_2(WildSpawnWave x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass81_0
	{
		public BotZone botZone; //Field offset: 0x10

		public <>c__DisplayClass81_0() { }

		internal bool <ChooseZonesToSpawn>b__1(ZoneCount x) { }

	}

	private class ZoneCount
	{
		public BotZone Zone; //Field offset: 0x10
		public int PosibleSlots; //Field offset: 0x18

		public ZoneCount() { }

	}

	private const string FILE_PATH = "DebugBotData.txt"; //Field offset: 0x0
	private const float SPAWN_DELAY = 1; //Field offset: 0x0
	private static DebugBotData _instance; //Field offset: 0x0
	private static bool _isCachedAndOff; //Field offset: 0x8
	[SerializeField]
	public List StartWaves; //Field offset: 0x18
	[SerializeField]
	public List BossStartWaves; //Field offset: 0x20
	public GizmosConfig Gizmos; //Field offset: 0x28
	public bool autoRespawn; //Field offset: 0x30
	public bool evenlyDistribute; //Field offset: 0x31
	public bool spawnInstantly; //Field offset: 0x32
	public bool localProfiles; //Field offset: 0x33
	public bool AnySideBornUse; //Field offset: 0x34
	public bool DebugBrain; //Field offset: 0x35
	public bool UseCustomHostilitySettings; //Field offset: 0x36
	public string CustomHostilitySettings; //Field offset: 0x38
	public DebugBotDesition DebugBotDesition; //Field offset: 0x40
	public DebugBotTactic DebugBotTactic; //Field offset: 0x44
	public bool BadShooting; //Field offset: 0x48
	public bool UseDebugWawes; //Field offset: 0x49
	public bool UseNewSpawn; //Field offset: 0x4A
	public int respawnCount; //Field offset: 0x4C
	public int MaxBotsCount; //Field offset: 0x50
	public int SummonSavages; //Field offset: 0x54
	public bool BadVision; //Field offset: 0x58
	public bool BadHearing; //Field offset: 0x59
	public bool NoShoot; //Field offset: 0x5A
	public bool BadShootingAsCount; //Field offset: 0x5B
	public bool MaxAgression; //Field offset: 0x5C
	public bool NoMinMax; //Field offset: 0x5D
	public bool DebugCoverLogs; //Field offset: 0x5E
	public bool NoReciol; //Field offset: 0x5F
	public bool FreeForAll; //Field offset: 0x60
	public bool FreeForAllOverride; //Field offset: 0x61
	public bool DrawColorCanShoot; //Field offset: 0x62
	public bool DrawColorLinesWeight; //Field offset: 0x63
	public bool NoArmorToPower; //Field offset: 0x64
	public bool GoodShooting; //Field offset: 0x65
	public bool NoSleepMode; //Field offset: 0x66
	public bool LoadSettingsFromCode; //Field offset: 0x67
	public bool DebugMalfunctions; //Field offset: 0x68
	public bool AlwaysSprint; //Field offset: 0x69
	public bool SprintOverride; //Field offset: 0x6A
	public bool CheckStuck; //Field offset: 0x6B
	public float SprintSpeed; //Field offset: 0x6C
	public float FogMaxDebuffDistanceK; //Field offset: 0x70
	public float RainMaxDebuffDistanceK; //Field offset: 0x74
	public bool useThisData; //Field offset: 0x78
	[HideInInspector]
	public List waves; //Field offset: 0x80
	[HideInInspector]
	public List bossWaves; //Field offset: 0x88
	public bool NoZoneBlocks; //Field offset: 0x90
	public bool NoRoleBlocks; //Field offset: 0x91
	public bool NoGrenadeOffset; //Field offset: 0x92
	public bool NoGrenadeThrow; //Field offset: 0x93
	public bool UseGrenadeThrowSpeed; //Field offset: 0x94
	public float GrenadeThrowSpeed; //Field offset: 0x98
	public bool TrueAim; //Field offset: 0x9C
	public DebugLook DebugRaysSystem; //Field offset: 0xA0
	public bool NoStopServer; //Field offset: 0xA4
	public bool AlwaysLayWhenDanger; //Field offset: 0xA5
	public bool IgnoreBotLimits; //Field offset: 0xA6
	public bool UseDebugMoverObject; //Field offset: 0xA7
	public bool ActivatedStatus; //Field offset: 0xA8
	public bool PhraseRequestAlwaysGood; //Field offset: 0xA9
	private BotSpawner _botSpawner; //Field offset: 0xB0
	private BotZoneGroupsDictionary _groups; //Field offset: 0xB8
	private float nextRespawnTime; //Field offset: 0xC0
	public bool StartWithNoPlayers; //Field offset: 0xC4

	public float BadShootOffset
	{
		 get { } //Length: 9
	}

	public static DebugBotData Instance
	{
		 get { } //Length: 168
	}

	public static bool UseDebugData
	{
		 get { } //Length: 284
	}

	public DebugBotData() { }

	private List ChooseZonesToSpawn(List zonesSpace, List wavesToCheck) { }

	public void DebugActivateAllBots(bool val = true) { }

	public float get_BadShootOffset() { }

	public static DebugBotData get_Instance() { }

	public static bool get_UseDebugData() { }

	public void Init(BotZone[] botZones = null) { }

	public void InitMessage() { }

	public static DebugBotData Load() { }

	private void OnUpdateManual() { }

	public void Serialize(string path = "DebugBotData.txt") { }

	public void SetData(DebugBotDataStore result) { }

	public void StartUseAutoRespawn(BotSpawner botSpawner, BotsList bots, BotZoneGroupsDictionary groups) { }

}

