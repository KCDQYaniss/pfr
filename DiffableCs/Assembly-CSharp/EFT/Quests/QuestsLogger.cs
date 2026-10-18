namespace EFT.Quests;

public sealed class QuestsLogger : AbstractLogger
{
	private static QuestsLogger _instance; //Field offset: 0x0

	public static QuestsLogger Instance
	{
		 get { } //Length: 311
	}

	private QuestsLogger() { }

	public static QuestsLogger get_Instance() { }

	public void LogCondition(Condition condition, string text) { }

}

