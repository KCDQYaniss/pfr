namespace EFT;

public struct QuestionsPageData
{
	public readonly List sortedQuestionsToShow; //Field offset: 0x0
	public readonly int allQuestionsCount; //Field offset: 0x8
	public readonly bool isLastPage; //Field offset: 0xC

	public QuestionsPageData(int allQuestionsCount, List sortedQuestionsToShow, bool isLastPage) { }

}

