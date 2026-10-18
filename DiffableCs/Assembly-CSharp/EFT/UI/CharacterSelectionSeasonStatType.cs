namespace EFT.UI;

public static class CharacterSelectionSeasonStatType
{
	private const string SPECIAL_COLOR_HEX = "#CA8A00"; //Field offset: 0x0
	public static readonly ECharacterSelectionSeasonStat[] DisplayOrder; //Field offset: 0x0

	private static CharacterSelectionSeasonStatType() { }

	private static string FormatBattlePassRewards(CharacterSelectionSeasonInfo seasonInfo) { }

	private static string FormatKd(float kd) { }

	private static string FormatProgress(int current, int total, bool isSpecial = false) { }

	private static string FormatStoryChapters(CharacterSelectionStoryChaptersInfo storyChapters) { }

	public static string GetValue(ECharacterSelectionSeasonStat stat, CharacterSelectionSeasonInfo seasonInfo) { }

	private static string GetZeroValue(ECharacterSelectionSeasonStat stat) { }

}

