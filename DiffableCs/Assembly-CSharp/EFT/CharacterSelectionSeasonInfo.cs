namespace EFT;

public sealed class CharacterSelectionSeasonInfo
{
	[JsonProperty("leagueRank")]
	public Nullable Rank; //Field offset: 0x10
	[JsonProperty("seasonNameLocalizationKey")]
	public string SeasonName; //Field offset: 0x18
	[JsonProperty("seasonEndAt")]
	public Nullable EndsAt; //Field offset: 0x20
	[JsonProperty("selectedSeasonalPerkIds")]
	public MongoID[] SelectedSeasonalPerkIds; //Field offset: 0x30
	[JsonProperty("battlePassRewards")]
	public CharacterSelectionBattlePassRewardsInfo[] BattlePassRewards; //Field offset: 0x38
	[JsonProperty("storyChapters")]
	public CharacterSelectionStoryChaptersInfo StoryChapters; //Field offset: 0x40
	[JsonProperty("kdPmc")]
	public float KdPmc; //Field offset: 0x48
	[JsonProperty("raidsSurvivedPmc")]
	public int RaidsSurvivedPmc; //Field offset: 0x4C
	[JsonProperty("achievements")]
	public CharacterSelectionAchievementsInfo Achievements; //Field offset: 0x50

	public CharacterSelectionSeasonInfo() { }

}

