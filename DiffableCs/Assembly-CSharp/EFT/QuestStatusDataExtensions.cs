namespace EFT;

[Extension]
public static class QuestStatusDataExtensions
{

	[Extension]
	public static QuestStatusData ReadQuestStatusData(NetworkReader reader) { }

	[Extension]
	public static void WriteQuestStatusData(NetworkWriter writer, QuestStatusData target) { }

}

