namespace EFT;

public sealed class CharacterSelectionAchievementsInfo
{
	[JsonProperty("completedAchievementIds")]
	public string[] CompletedAchievementIds; //Field offset: 0x10

	public CharacterSelectionAchievementsInfo() { }

}

