namespace EFT.UI.Matchmaker;

public static class MatchingStage
{
	private static readonly Dictionary _groupStages; //Field offset: 0x0
	private static readonly List _chaoticServerStages; //Field offset: 0x8
	private static readonly List _unskippableStageGroups; //Field offset: 0x10

	public static int GroupsCount
	{
		 get { } //Length: 382
	}

	private static MatchingStage() { }

	public static EMatchingStage ConvertInitLevelProgressToMatchingStage(InitLevelProgress pr, bool isLoot = false) { }

	public static int get_GroupsCount() { }

	public static Nullable GetGroup(EMatchingStage stage) { }

	public static EMatchingStageGroup[] GetGroupsBetween(EMatchingStageGroup startGroup, EMatchingStageGroup endGroup) { }

	public static string GetStageLocaleKey(EMatchingStage stage) { }

	public static bool IsLastStageInGroup(EMatchingStage stage) { }

	public static bool IsServerStage(EMatchingStage stage) { }

	public static bool IsUnskippableStageGroup(EMatchingStageGroup stageGroup) { }

}

