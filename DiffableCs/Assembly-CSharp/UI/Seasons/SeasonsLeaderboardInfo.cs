namespace UI.Seasons;

public sealed class SeasonsLeaderboardInfo
{
	internal class LeaderboardPlayerInfo
	{
		[JsonIgnore]
		public int Place; //Field offset: 0x10
		[JsonProperty("aid")]
		public string AccountId; //Field offset: 0x18
		[JsonProperty("nickname")]
		public string Nickname; //Field offset: 0x20
		[JsonProperty("selectedGameVersion")]
		public EMemberCategory MemberCategory; //Field offset: 0x28
		[JsonProperty("prestigeLevel")]
		public int PrestigeLevel; //Field offset: 0x2C
		[JsonProperty("prestigeGameMode")]
		public EGameMode PrestigeGameMode; //Field offset: 0x30
		[JsonProperty("score")]
		public int Score; //Field offset: 0x34

		[JsonConstructor]
		public LeaderboardPlayerInfo(string accountId, string nickname, EMemberCategory memberCategory, int prestigeLevel, int score) { }

		public virtual string ToString() { }

	}

	[JsonProperty("roundEndTime")]
	public int RoundEndTime; //Field offset: 0x10
	[JsonProperty("promoteCount")]
	public int PromoteCount; //Field offset: 0x14
	[JsonProperty("demoteCount")]
	public int DemoteCount; //Field offset: 0x18
	[JsonProperty("notChangedCount")]
	public int NotChangedCount; //Field offset: 0x1C
	[JsonProperty("cohortSize")]
	public int CohortSize; //Field offset: 0x20
	[JsonProperty("rating")]
	public LeaderboardPlayerInfo[] Players; //Field offset: 0x28

	public SeasonsLeaderboardInfo() { }

	public virtual string ToString() { }

}

