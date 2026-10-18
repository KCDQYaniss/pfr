namespace JsonType;

public class LocationSettings
{
	internal class Location
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__22_0; //Field offset: 0x8

			private static <>c() { }

			public <>c() { }

			internal bool <get_NightTimeAllowedLocations>b__22_0(string x) { }

		}

		internal sealed class AccessRequirementsByUsage
		{
			[JsonConverter(typeof(AccessKeyCountDictionaryJsonConverter))]
			public Dictionary menu_PVP; //Field offset: 0x10
			[JsonConverter(typeof(AccessKeyCountDictionaryJsonConverter))]
			public Dictionary menu_PVE; //Field offset: 0x18
			[JsonConverter(typeof(AccessKeyCountDictionaryJsonConverter))]
			public Dictionary transit_PVP; //Field offset: 0x20
			[JsonConverter(typeof(AccessKeyCountDictionaryJsonConverter))]
			public Dictionary transit_PVE; //Field offset: 0x28

			public AccessRequirementsByUsage() { }

			public IReadOnlyDictionary Get(EGameMode gameMode, EAccessUsageType usageType) { }

		}

		internal class AirdropParameters
		{
			public int PlaneAirdropStartMin; //Field offset: 0x10
			public int PlaneAirdropStartMax; //Field offset: 0x14
			public int PlaneAirdropEnd; //Field offset: 0x18
			public float PlaneAirdropChance; //Field offset: 0x1C
			public int PlaneAirdropMax; //Field offset: 0x20
			public int PlaneAirdropCooldownMin; //Field offset: 0x24
			public int PlaneAirdropCooldownMax; //Field offset: 0x28
			public int AirdropPointDeactivateDistance; //Field offset: 0x2C
			public int MinPlayersCountToSpawnAirdrop; //Field offset: 0x30
			public int UnsuccessfulTryPenalty; //Field offset: 0x34

			public AirdropParameters() { }

		}

		internal class BotHalloween2024
		{
			public int InfectionPercentage; //Field offset: 0x10
			public int MinInfectionPercentage; //Field offset: 0x14
			public List CrowdAttackSpawnParams; //Field offset: 0x18
			public float ZombieMultiplier; //Field offset: 0x20
			public int MaxCrowdAttackSpawnLimit; //Field offset: 0x24
			public int CrowdsLimit; //Field offset: 0x28
			public float InfectedLookCoeff; //Field offset: 0x2C
			public float CrowdCooldownPerPlayerSec; //Field offset: 0x30
			public float ZombieCallPeriodSec; //Field offset: 0x34
			public float ZombieCallDeltaRadius; //Field offset: 0x38
			public float ZombieCallRadiusLimit; //Field offset: 0x3C
			public float CrowdAttackBlockRadius; //Field offset: 0x40
			public float MinSpawnDistToPlayer; //Field offset: 0x44
			public float TargetPointSearchRadiusLimit; //Field offset: 0x48

			public BotHalloween2024() { }

			public float CalcRealInfectionLevel() { }

		}

		internal class BotLocationEvents
		{
			public BotHalloween2024 Halloween2024; //Field offset: 0x10
			public Khorovod Khorovod; //Field offset: 0x18
			public VSRFDespawn VSRFDespawn; //Field offset: 0x20

			public BotLocationEvents() { }

			public IEnumerable GetEventsProfilesOnStart() { }

		}

		internal class CrowdAttackSpawnParam
		{
			public BotDifficulty Difficulty; //Field offset: 0x10
			public WildSpawnType Role; //Field offset: 0x14
			public int Weight; //Field offset: 0x18

			public CrowdAttackSpawnParam() { }

		}

		internal enum EAccessUsageType
		{
			Menu = 0,
			Transit = 1,
		}

		internal class Khorovod
		{
			public float Chance; //Field offset: 0x10

			public Khorovod() { }

		}

		internal class Limit
		{
			public object[] items; //Field offset: 0x10
			public int min; //Field offset: 0x18
			public int max; //Field offset: 0x1C

			public Limit() { }

		}

		internal class LocationBanner
		{
			[CompilerGenerated]
			private struct <LoadBannerSprite>d__8 : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public IImageLoader session; //Field offset: 0x20
				public LocationBanner <>4__this; //Field offset: 0x28
				private TaskAwaiter <>u__1; //Field offset: 0x30

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			public string id; //Field offset: 0x10
			public ResourceKey pic; //Field offset: 0x18

			[JsonIgnore]
			public string Description
			{
				 get { } //Length: 66
			}

			[JsonIgnore]
			private string ImageUrl
			{
				private get { } //Length: 80
			}

			[JsonIgnore]
			public string Name
			{
				 get { } //Length: 66
			}

			public LocationBanner() { }

			public string get_Description() { }

			private string get_ImageUrl() { }

			public string get_Name() { }

			public void GetAndAssignSprite(IImageLoader session, Image image, bool resetImage, CancellationToken cancellationToken) { }

			[AsyncStateMachine(typeof(<LoadBannerSprite>d__8))]
			public Task LoadBannerSprite(IImageLoader session) { }

		}

		internal class LocationBannerLocalization
		{
			public string name; //Field offset: 0x10
			public string description; //Field offset: 0x18

			public LocationBannerLocalization() { }

		}

		internal enum LocationRules
		{
			Normal = 0,
			AvoidOwnPmc = 1,
			AvoidAllPmc = 2,
		}

		internal class LootContainer
		{
			public bool enabled; //Field offset: 0x10
			public bool static; //Field offset: 0x11
			public ELootRarity rarity; //Field offset: 0x14
			public string[] filter; //Field offset: 0x18

			public LootContainer() { }

		}

		internal class TransitParameters
		{
			public int id; //Field offset: 0x10
			public bool active; //Field offset: 0x14
			public string name; //Field offset: 0x18
			public string description; //Field offset: 0x20
			public string conditions; //Field offset: 0x28
			public int activateAfterSec; //Field offset: 0x30
			public ushort time; //Field offset: 0x34
			public string target; //Field offset: 0x38
			public string location; //Field offset: 0x40
			public bool events; //Field offset: 0x48
			public bool hideIfNoKey; //Field offset: 0x49
			public string referenceConditions; //Field offset: 0x50
			public bool waitForAllParty; //Field offset: 0x58
			public byte maxGroupSize; //Field offset: 0x59
			public string completedQuestId; //Field offset: 0x60
			public bool eventsEnable; //Field offset: 0x68

			public TransitParameters() { }

		}

		internal class VSRFDespawn
		{
			public Dictionary EventsZones; //Field offset: 0x10

			public VSRFDespawn() { }

		}

		public const string TERMINAL_ID = "Terminal"; //Field offset: 0x0
		public static readonly string[] AvailableMaps; //Field offset: 0x0
		private const string DEVELOP_ID = "develop"; //Field offset: 0x0
		private const string HIDEOUT_ID = "hideout"; //Field offset: 0x0
		public const string ICEBREAKER_ID = "Icebreaker"; //Field offset: 0x0
		public const string TARKOVSTREETS_ID = "TarkovStreets"; //Field offset: 0x0
		public const string LIGHTHOUSE_ID = "Lighthouse"; //Field offset: 0x0
		public const string REZERVBASE_ID = "RezervBase"; //Field offset: 0x0
		public const string SHORELINE_ID = "Shoreline"; //Field offset: 0x0
		public const string BIGMAP_ID = "bigmap"; //Field offset: 0x0
		public const string WOODS_ID = "Woods"; //Field offset: 0x0
		public const string INTERCHANGE_ID = "Interchange"; //Field offset: 0x0
		public const string SANDBOX_TUTORIAL_ID = "Sandbox_start"; //Field offset: 0x0
		public const string FACTORY_DAY_ID = "factory4_day"; //Field offset: 0x0
		public const string TUTORIAL = "Sandbox_start"; //Field offset: 0x0
		public const string FACTORY_ID = "factory4"; //Field offset: 0x0
		public const string LABORATORY_ID = "laboratory"; //Field offset: 0x0
		public const string FACTORY_NIGHT_ID = "factory4_night"; //Field offset: 0x0
		public const string LABYRINTH = "labyrinth"; //Field offset: 0x0
		public const string SANDBOX_ID = "Sandbox"; //Field offset: 0x0
		public const string SANDBOX_HIGH_ID = "Sandbox_high"; //Field offset: 0x0
		public const string LABORATORY_DARK_ID = "laboratory_dark"; //Field offset: 0x0
		public bool IsSecret; //Field offset: 0x10
		public float IconX; //Field offset: 0x14
		public float IconY; //Field offset: 0x18
		public string _Id; //Field offset: 0x20
		public string Id; //Field offset: 0x28
		public bool Enabled; //Field offset: 0x30
		public bool EnableCoop; //Field offset: 0x31
		public bool ForceOnlineRaidInPVE; //Field offset: 0x32
		public bool ForceOfflineRaidInPVE; //Field offset: 0x33
		public bool SavageForceOnlineRaidInPVE; //Field offset: 0x34
		public bool SavageForceOfflineRaidInPVE; //Field offset: 0x35
		public bool Locked; //Field offset: 0x36
		public bool LockedByQuest; //Field offset: 0x37
		public bool HiddenWhenLockedByQuest; //Field offset: 0x38
		public string Name; //Field offset: 0x40
		public ResourceKey Scene; //Field offset: 0x48
		public string Description; //Field offset: 0x50
		public float Area; //Field offset: 0x58
		public int RequiredPlayerLevelMin; //Field offset: 0x5C
		public int RequiredPlayerLevelMax; //Field offset: 0x60
		public string HighLevelLocationId; //Field offset: 0x68
		public int matching_min_seconds; //Field offset: 0x70
		public int users_gather_seconds; //Field offset: 0x74
		public int users_spawn_seconds_n; //Field offset: 0x78
		public int users_spawn_seconds_n2; //Field offset: 0x7C
		public int users_summon_seconds; //Field offset: 0x80
		public int sav_summon_seconds; //Field offset: 0x84
		public int session_duration_minutes; //Field offset: 0x88
		public int exit_count; //Field offset: 0x8C
		public int exit_access_time; //Field offset: 0x90
		public int exit_time; //Field offset: 0x94
		public int EscapeTimeLimit; //Field offset: 0x98
		public int EscapeTimeLimitCoop; //Field offset: 0x9C
		public int MinDistToExitPoint; //Field offset: 0xA0
		public int MaxBotPerZone; //Field offset: 0xA4
		public int MaxDistToFreePoint; //Field offset: 0xA8
		public int MinDistToFreePoint; //Field offset: 0xAC
		public int SpawnSafeDistanceMeters; //Field offset: 0xB0
		public bool NoGroupSpawn; //Field offset: 0xB4
		public bool OneTimeSpawn; //Field offset: 0xB5
		public ResourceKey Preview; //Field offset: 0xB8
		public string[] filter_ex; //Field offset: 0xC0
		public WildSpawnWave[] waves; //Field offset: 0xC8
		public MinMaxBots[] MinMaxBots; //Field offset: 0xD0
		public BotLocationModifier BotLocationModifier; //Field offset: 0xD8
		public NonWaveGroupScenarioData NonWaveGroupScenario; //Field offset: 0xE0
		public BossLocationSpawn[] BossLocationSpawn; //Field offset: 0xE8
		public Limit[] limits; //Field offset: 0xF0
		public Dictionary containers; //Field offset: 0xF8
		public LocationBanner[] Banners; //Field offset: 0x100
		public BotLocationEvents Events; //Field offset: 0x108
		public LocationLabyrinthTrapsData EventTrapsData; //Field offset: 0x110
		[JsonProperty("transits")]
		public TransitParameters[] transitParameters; //Field offset: 0x118
		[JsonProperty("PasscodeLocationSettings")]
		public readonly PasscodeLocationSettings PasscodeLocationSettings; //Field offset: 0x120
		[JsonProperty("FixedLocationWeatherSettings")]
		public readonly FixedWeatherLocationConfig FixedWeatherLocationConfig; //Field offset: 0x128
		public AirdropParameters[] airdropParameters; //Field offset: 0x130
		public int PmcMaxPlayersInGroup; //Field offset: 0x138
		public int ScavMaxPlayersInGroup; //Field offset: 0x13C
		public int MinGroupSize; //Field offset: 0x140
		public int MinPlayers; //Field offset: 0x144
		public int MaxPlayers; //Field offset: 0x148
		public int PlayersRequestCount; //Field offset: 0x14C
		public int MaxCoopGroup; //Field offset: 0x150
		public int AveragePlayerLevel; //Field offset: 0x154
		public int AveragePlayTime; //Field offset: 0x158
		public LocationRules Rules; //Field offset: 0x15C
		public long UnixDateTime; //Field offset: 0x160
		public SpawnPointParams[] SpawnPointParams; //Field offset: 0x168
		public BackendExitTriggerSettings[] exits; //Field offset: 0x170
		[JsonProperty("secretExits")]
		public BackendSecretExitTriggerSettings[] SecretExits; //Field offset: 0x178
		public LootData Loot; //Field offset: 0x180
		public string OpenZones; //Field offset: 0x188
		public bool OcculsionCullingEnabled; //Field offset: 0x190
		public bool DisabledForScav; //Field offset: 0x191
		public bool OldSpawn; //Field offset: 0x192
		public bool OfflineOldSpawn; //Field offset: 0x193
		public bool NewSpawn; //Field offset: 0x194
		public bool OfflineNewSpawn; //Field offset: 0x195
		public bool NewSpawnForPlayers; //Field offset: 0x196
		public int BotMax; //Field offset: 0x198
		public int BotMaxPlayer; //Field offset: 0x19C
		public int BotMaxTimePlayer; //Field offset: 0x1A0
		public int BotStart; //Field offset: 0x1A4
		public int BotStartPlayer; //Field offset: 0x1A8
		public int BotStop; //Field offset: 0x1AC
		public int BotSpawnPeriodCheck; //Field offset: 0x1B0
		public int BotSpawnCountStep; //Field offset: 0x1B4
		public int BotSpawnTimeOnMin; //Field offset: 0x1B8
		public int BotSpawnTimeOnMax; //Field offset: 0x1BC
		public int BotSpawnTimeOffMin; //Field offset: 0x1C0
		public int BotSpawnTimeOffMax; //Field offset: 0x1C4
		public int BotEasy; //Field offset: 0x1C8
		public int BotNormal; //Field offset: 0x1CC
		public int BotHard; //Field offset: 0x1D0
		public int BotImpossible; //Field offset: 0x1D4
		public int BotAssault; //Field offset: 0x1D8
		public int BotMarksman; //Field offset: 0x1DC
		public string DisabledScavExits; //Field offset: 0x1E0
		public AccessRequirementsByUsage access; //Field offset: 0x1E8
		public int MinPlayerLvlAccessKeys; //Field offset: 0x1F0

		public bool IsHideout
		{
			 get { } //Length: 120
		}

		[JsonIgnore]
		public string LocalizedName
		{
			 get { } //Length: 171
		}

		public static IEnumerable NightTimeAllowedLocations
		{
			 get { } //Length: 413
		}

		public Vector2 RelativeMapPos
		{
			 get { } //Length: 35
		}

		private static Location() { }

		public Location() { }

		public bool get_IsHideout() { }

		public string get_LocalizedName() { }

		public static IEnumerable get_NightTimeAllowedLocations() { }

		public Vector2 get_RelativeMapPos() { }

		public IReadOnlyDictionary GetAccessRequirements(EGameMode gameMode, EAccessUsageType usageType) { }

	}

	internal class LocationInfo
	{
		public string BackendUrl; //Field offset: 0x10
		public UnparsedData Location; //Field offset: 0x18
		public uint crc; //Field offset: 0x20

		public LocationInfo() { }

	}

	internal class LocationPath
	{
		public string Source; //Field offset: 0x10
		public string Destination; //Field offset: 0x18
		public bool Event; //Field offset: 0x20

		public LocationPath() { }

	}

	private const float MAP_SIZE_COEFFICIENT = 1000; //Field offset: 0x0
	public Dictionary locations; //Field offset: 0x10
	public LocationPath[] paths; //Field offset: 0x18

	public LocationSettings() { }

}

