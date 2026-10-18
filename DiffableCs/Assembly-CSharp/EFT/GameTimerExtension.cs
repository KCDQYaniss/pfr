namespace EFT;

[Extension]
public static class GameTimerExtension
{

	[Extension]
	public static float EscapeTimeSeconds(GameTimer timer) { }

	[Extension]
	public static TimeSpan EscapeTimeTimeSpan(GameTimer timer) { }

	[Extension]
	public static float PastTimeSeconds(GameTimer timer) { }

	[Extension]
	public static int SessionSeconds(GameTimer timer) { }

	[Extension]
	public static void Start(GameTimer gameTimer, float pastTime, int sessionSeconds) { }

	[Extension]
	public static bool Started(GameTimer timer) { }

	[Extension]
	public static void TryStop(GameTimer timer) { }

}

