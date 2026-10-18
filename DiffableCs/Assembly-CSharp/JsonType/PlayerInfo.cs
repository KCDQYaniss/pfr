namespace JsonType;

[GenerateBinarySerialization]
public sealed class PlayerInfo
{
	[JsonProperty("Nickname")]
	public string Nickname; //Field offset: 0x10
	[JsonProperty("Side")]
	public EPlayerSide Side; //Field offset: 0x18
	[JsonProperty("Level")]
	public int Level; //Field offset: 0x1C
	[JsonProperty("PrestigeLevel")]
	public int PrestigeLevel; //Field offset: 0x20
	[JsonProperty("PrestigeGameMode")]
	public EGameMode PrestigeGameMode; //Field offset: 0x24
	[JsonProperty("MemberCategory")]
	public EMemberCategory MemberCategory; //Field offset: 0x28
	[JsonProperty("SelectedMemberCategory")]
	public EMemberCategory SelectedMemberCategory; //Field offset: 0x2C
	[JsonProperty("SavageLockTime")]
	public double SavageLockTime; //Field offset: 0x30
	[JsonProperty("SavageNickname")]
	public string SavageNickname; //Field offset: 0x38
	[JsonProperty("GameVersion")]
	public string GameVersion; //Field offset: 0x40
	[JsonProperty("HasCoopExtension")]
	public bool HasCoopExtension; //Field offset: 0x48
	[JsonProperty("Health")]
	public HealthInfo Health; //Field offset: 0x50
	[JsonProperty("UnlockedLocations")]
	public HashSet UnlockedLocations; //Field offset: 0x58
	[JsonProperty("TeamGameEditionExpBonus")]
	public float TeamGameEditionExpBonus; //Field offset: 0x60

	public string CorrectedNickname
	{
		 get { } //Length: 111
	}

	public PlayerInfo() { }

	public string get_CorrectedNickname() { }

	public static PlayerInfo GetFromChatMemberInfo(UpdatableChatMemberInfo info) { }

	public static PlayerInfo GetFromProfileDescriptor(ProfileDescriptor profileDescriptor) { }

}

