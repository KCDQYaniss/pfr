//Type is in global namespace

public class WildSpawnTypeSettings
{
	public bool IsBoss; //Field offset: 0x10
	public bool IsFollower; //Field offset: 0x11
	public bool IsHostileToEverybody; //Field offset: 0x12
	public Nullable CountAsBossForStatistics; //Field offset: 0x13
	public string ScavRoleKey; //Field offset: 0x18
	public ETagStatus PhraseTag; //Field offset: 0x20

	public WildSpawnTypeSettings(bool isBoss, bool isFollower, bool isHostileToEverybody, string scavRoleKey, ETagStatus phraseTag = 0) { }

}

