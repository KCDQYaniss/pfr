namespace EFT.UI;

[IsReadOnly]
public struct AcceptQuestChangeArgs
{
	public readonly DailyQuest QuestToChange; //Field offset: 0x0
	public readonly string TraderCancelText; //Field offset: 0x8
	public readonly MultiLineInfo Price; //Field offset: 0x10

	public AcceptQuestChangeArgs(DailyQuest questToChange, string traderCancelText, MultiLineInfo price) { }

}

