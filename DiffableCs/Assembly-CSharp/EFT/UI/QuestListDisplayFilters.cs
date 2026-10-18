namespace EFT.UI;

internal static class QuestListDisplayFilters
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public IReadOnlyList excludeFilter; //Field offset: 0x10

		public <>c__DisplayClass2_0() { }

		internal bool <GetChainDisplayQuest>b__0(Quest q) { }

		internal bool <GetChainDisplayQuest>b__1(Quest q) { }

	}


	public static Quest GetChainDisplayQuest(IReadOnlyList chain, IReadOnlyList excludeFilter) { }

	public static bool HasChainDisplayContent(IReadOnlyList chain, IReadOnlyList excludeFilter) { }

	public static bool IsActiveQuest(Quest quest) { }

	public static bool IsQuestShownInChainHistory(Quest quest, IReadOnlyList excludeFilter) { }

	public static bool IsQuestShownInList(Quest quest, IReadOnlyList excludeFilter) { }

}

