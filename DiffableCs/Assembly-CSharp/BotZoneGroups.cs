//Type is in global namespace

public class BotZoneGroups
{
	private static WildSpawnType[] roles; //Field offset: 0x0
	private readonly List _noConnectionGroups; //Field offset: 0x10
	private readonly Dictionary data; //Field offset: 0x18
	private readonly EPlayerSide[] sides; //Field offset: 0x20
	private readonly HashSet _bossGroup; //Field offset: 0x28

	private static BotZoneGroups() { }

	public BotZoneGroups() { }

	public void AddBot(BotOwner bot, bool freeForAll) { }

	public void AddNoKey(BotsGroup gr) { }

	public void Dispose() { }

	[CanBeNull]
	public List GetAllGroupsDebug() { }

	public HashSet GetGroups(bool notNull) { }

	[CanBeNull]
	public BotsGroup Group(bool isBossOrFollower, WildSpawnType spawnType) { }

	private bool IsSuitable(BotsGroup group, WildSpawnType spawnType) { }

	public List MessageInfo() { }

	public string MessageInfoWide() { }

	public void Set(EPlayerSide side, BotsGroup gr, bool bossOrFollower) { }

}

