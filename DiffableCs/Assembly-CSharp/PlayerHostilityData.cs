//Type is in global namespace

public class PlayerHostilityData
{
	private const float FRIENDLY_SECTANTS_AMULET_CHECK_PERIOD = 5; //Field offset: 0x0
	private float _nextFriendlySectantsCheckTime; //Field offset: 0x10
	[CompilerGenerated]
	private IPlayer <Player>k__BackingField; //Field offset: 0x18
	private readonly int _seed; //Field offset: 0x20
	public bool IsPlayerWithLighthouseKeeperServicesKillNeutralPlayerInLighthouseZoneWithGreenTransmitter; //Field offset: 0x24
	[CompilerGenerated]
	private IReadOnlyList <GroupMembers>k__BackingField; //Field offset: 0x28
	public bool IsFriendlyExUsecOwner; //Field offset: 0x30
	public bool IsFriendlyExUsecTeammate; //Field offset: 0x31
	public bool IsPlayerMarkedByFriendlyExUsecOwner; //Field offset: 0x32
	public bool IsPlayerMarkedByFriendlyExUsecTeammate; //Field offset: 0x33
	public bool IsPlayerAggressorForFriendlyExUsecOwner; //Field offset: 0x34
	public bool IsPlayerAggressorForFriendlyExUsecTeammate; //Field offset: 0x35
	public float LastTimePlayerAttackExUsecBot; //Field offset: 0x38
	public bool IsPlayerExUsecKiller; //Field offset: 0x3C
	public bool IsPlayerExUsecKillersTeammate; //Field offset: 0x3D
	public bool IsPlayerLighthouseKeeperBetrayerOrTeammate; //Field offset: 0x3E
	public bool IsFriendlyZryachiyOwner; //Field offset: 0x3F
	public bool IsFriendlyZryachiyTeammate; //Field offset: 0x40
	public float LastTimePlayerAttackZryachiy; //Field offset: 0x44
	public bool IsPlayerMarkedByFriendlyZryachiyOwner; //Field offset: 0x48
	public bool IsPlayerMarkedByFriendlyZryachiyTeammate; //Field offset: 0x49
	public bool IsPlayerAggressorForFriendlyZryachiyOwner; //Field offset: 0x4A
	public bool IsPlayerAggressorForFriendlyZryachiyTeammate; //Field offset: 0x4B
	public bool IsPlayerZryachiyKiller; //Field offset: 0x4C
	public bool IsPlayerZryachiyKillersTeammate; //Field offset: 0x4D
	public bool IsPlayerHitFriendlySectants; //Field offset: 0x4E
	public bool IsPlayerHaveSectantsAmulet; //Field offset: 0x4F
	public bool BtrBetrayer; //Field offset: 0x50
	public bool KillaTagillaPairSyncedEnemy; //Field offset: 0x51
	public bool TagillaFoundEnemy; //Field offset: 0x52
	public bool AggroTagillaAlarm; //Field offset: 0x53
	public bool PartisanBadKarma; //Field offset: 0x54
	public bool IsPlayerAggressorForZryachiyOrFollowers; //Field offset: 0x55
	public bool IsPlayerExUsecAggressor; //Field offset: 0x56
	public bool IsPlayerExUsecFreeAggressor; //Field offset: 0x57
	public bool IsPlayerUsecPlayerAggressorInExUsecRadius; //Field offset: 0x58
	public Dictionary GetOffGesturesCount; //Field offset: 0x60
	public HashSet botZoneRevengeZones; //Field offset: 0x68
	public bool RavangeZryachiyActivate; //Field offset: 0x70
	public bool GifterKill; //Field offset: 0x71
	public bool CallForHelpTarget; //Field offset: 0x72

	public private IReadOnlyList GroupMembers
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private IPlayer Player
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public int RolledEnemyChance
	{
		 get { } //Length: 125
	}

	public override int UsecRaidRemainKills
	{
		 get { } //Length: 294
	}

	public PlayerHostilityData(IPlayer player) { }

	public PlayerHostilityData(IPlayer player, int seed, List groupMembers) { }

	[CompilerGenerated]
	public IReadOnlyList get_GroupMembers() { }

	[CompilerGenerated]
	public IPlayer get_Player() { }

	public int get_RolledEnemyChance() { }

	public override int get_UsecRaidRemainKills() { }

	public void IncGetOffGesture(BotOwner owner) { }

	[CompilerGenerated]
	private void set_GroupMembers(IReadOnlyList value) { }

	[CompilerGenerated]
	private void set_Player(IPlayer value) { }

}

