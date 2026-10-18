//Type is in global namespace

[Extension]
public static class WildSpawnTypeExtension
{
	private const string SCAV_ROLE_BOSS = "ScavRole/Boss"; //Field offset: 0x0
	private const string SCAV_ROLE_FOLLOWER = "ScavRole/Follower"; //Field offset: 0x0
	private const string SCAV_ROLE_SECTANT = "ScavRole/Sectant"; //Field offset: 0x0
	private const string SCAV_ROLE_CIVILIAN = "ScavRole/Civilian"; //Field offset: 0x0
	private static bool _isInited; //Field offset: 0x0
	private static Dictionary _spawnTypeSettings; //Field offset: 0x8
	private static readonly Dictionary ComparableCache; //Field offset: 0x10
	private static readonly List comparableTypesKolontay; //Field offset: 0x18
	private static readonly List comparableTypesBoar; //Field offset: 0x20
	private static readonly List comparableTypesGluhar; //Field offset: 0x28
	private static readonly List comparableTypesBullyBD; //Field offset: 0x30
	private static readonly List comparableTypesBully; //Field offset: 0x38
	private static readonly List comparableTypesZryachiy; //Field offset: 0x40
	private static readonly List comparableTypesKojaniy; //Field offset: 0x48
	private static readonly List comparableTypesKnight; //Field offset: 0x50
	private static readonly List comparableTypesWedgeLab; //Field offset: 0x58
	private static readonly List comparableTypesScourgeEventLab; //Field offset: 0x60
	private static readonly List comparableTypesInfected; //Field offset: 0x68
	private static readonly List comparableTypesSanitar; //Field offset: 0x70
	private static readonly List comparableTypesSectants; //Field offset: 0x78
	private static readonly List comparableTypesEventSectants; //Field offset: 0x80
	private static readonly List comparableTypesEventSentry; //Field offset: 0x88
	private static readonly List comparableTypesTest; //Field offset: 0x90

	private static string SCAV_ROLE_DEFAULT
	{
		private get { } //Length: 126
	}

	private static WildSpawnTypeExtension() { }

	[Extension]
	public static bool CountAsBossForStatistics(WildSpawnType role) { }

	private static string get_SCAV_ROLE_DEFAULT() { }

	public static ETagStatus GetPhraseTagFromRole(WildSpawnType role) { }

	[Extension]
	public static string GetScavRoleKey(WildSpawnType role) { }

	public static void Init() { }

	[Extension]
	public static bool IsBoss(WildSpawnType role) { }

	[Extension]
	public static bool IsBossOrFollower(WildSpawnType role) { }

	[Extension]
	public static bool IsExUsec(WildSpawnType role) { }

	[Extension]
	public static bool IsExUsecForKeeperService(WildSpawnType role) { }

	[Extension]
	public static bool IsFollower(WildSpawnType role) { }

	[Extension]
	public static bool IsHostileToEverybody(WildSpawnType role) { }

	[Extension]
	public static bool IsInfected(WildSpawnType role) { }

	[Extension]
	public static bool IsMidPriorityBossOrFollower(WildSpawnType role) { }

	[Extension]
	public static bool IsPmcBot(WildSpawnType role) { }

	[Extension]
	public static bool IsPureBoss(WildSpawnType role) { }

	[Extension]
	public static bool IsSectant(WildSpawnType role) { }

	public static bool IsSuitable(WildSpawnType test1, WildSpawnType test2) { }

	[Extension]
	public static bool IsVSRF(WildSpawnType role) { }

	[Extension]
	public static bool ShallUseFastAnimator(WildSpawnType role) { }

	private static void SubInitList(List p0) { }

}

