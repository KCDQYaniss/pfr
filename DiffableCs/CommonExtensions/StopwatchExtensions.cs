//Type is in global namespace

[Extension]
public static class StopwatchExtensions
{

	[Extension]
	public static double ElapsedMillisecondsAsDouble(Stopwatch stopwatch) { }

	[Extension]
	public static float ElapsedSeconds(Stopwatch stopwatch) { }

}

