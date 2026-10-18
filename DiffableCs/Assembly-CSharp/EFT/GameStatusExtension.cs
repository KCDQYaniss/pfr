namespace EFT;

[Extension]
public static class GameStatusExtension
{

	[Extension]
	public static bool IsRunned(GameStatus status) { }

	[Extension]
	public static bool IsStarted(GameStatus status) { }

	[Extension]
	public static bool NotStopped(GameStatus status) { }

}

