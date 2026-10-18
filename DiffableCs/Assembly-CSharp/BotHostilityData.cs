//Type is in global namespace

public class BotHostilityData
{
	private IAIData _aiData; //Field offset: 0x10
	private IBotOwner _owner; //Field offset: 0x18
	private WildSpawnType _role; //Field offset: 0x20
	private BotDifficulty _difficulty; //Field offset: 0x24
	private int _seed; //Field offset: 0x28
	[CompilerGenerated]
	private IPlayer <Player>k__BackingField; //Field offset: 0x30
	public bool IsBotMarkedByFriendlyExUsecOwner; //Field offset: 0x38
	public bool IsBotMarkedByFriendlyExUsecTeammate; //Field offset: 0x39
	public bool IsBotAggressorForFriendlyExUsecOwner; //Field offset: 0x3A
	public bool IsBotAggressorForFriendlyExUsecTeammate; //Field offset: 0x3B
	public bool IsBotMarkedByFriendlyZryachiyOwner; //Field offset: 0x3C
	public bool IsBotMarkedByFriendlyZryachiyTeammate; //Field offset: 0x3D
	public bool IsBotAggressorForFriendlyZryachiyOwner; //Field offset: 0x3E
	public bool IsBotAggressorForFriendlyZryachiyTeammate; //Field offset: 0x3F
	public bool FreeForAll; //Field offset: 0x40
	public HashSet botZoneRevengeZones; //Field offset: 0x48
	public bool KillaTagillaPairSyncedEnemy; //Field offset: 0x50
	public bool TagillaFoundEnemy; //Field offset: 0x51
	public bool IsBotAggressorForZryachiyOrFollowers; //Field offset: 0x52
	public bool IsBotExUsecAggressor; //Field offset: 0x53
	public bool IsBotExUsecFreeAggressor; //Field offset: 0x54
	public bool IsBotUsecPlayerAggressorInExUsecRadius; //Field offset: 0x55
	public bool RavangeZryachiyActivate; //Field offset: 0x56
	public bool GifterKill; //Field offset: 0x57
	public bool CalledForHelp; //Field offset: 0x58

	public BotDifficulty Difficulty
	{
		 get { } //Length: 143
	}

	public private IPlayer Player
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public WildSpawnType Role
	{
		 get { } //Length: 143
	}

	public int Seed
	{
		 get { } //Length: 4
	}

	public BotHostilityData(IAIData aiData) { }

	public BotHostilityData(IBotOwner owner, IPlayer player, WildSpawnType role, BotDifficulty difficulty, int seed) { }

	public BotDifficulty get_Difficulty() { }

	[CompilerGenerated]
	public IPlayer get_Player() { }

	public WildSpawnType get_Role() { }

	public int get_Seed() { }

	[CompilerGenerated]
	private void set_Player(IPlayer value) { }

}

