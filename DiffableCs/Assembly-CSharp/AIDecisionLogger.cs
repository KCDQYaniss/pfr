//Type is in global namespace

public class AIDecisionLogger : AbstractLogger
{
	private static AIDecisionLogger _instance; //Field offset: 0x0

	public static AIDecisionLogger Instance
	{
		 get { } //Length: 311
	}

	private AIDecisionLogger() { }

	public static AIDecisionLogger get_Instance() { }

	public void LogRaycast(RaycastHit hit, string sourceFunction, BotOwner owner = null) { }

}

