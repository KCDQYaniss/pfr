namespace DG.Tweening.Core;

public static class Debugger
{
	public static int logPriority; //Field offset: 0x0
	private const string _LogPrefix = "<color=#0099bc><b>DOTWEEN ► </b></color>"; //Field offset: 0x0

	public static void Log(object message) { }

	public static void LogAddActiveTweenError(string errorInfo) { }

	public static void LogError(object message) { }

	public static void LogInvalidTween(Tween t) { }

	public static void LogMissingMaterialProperty(string propertyName) { }

	public static void LogMissingMaterialProperty(int propertyId) { }

	public static void LogNestedTween(Tween t) { }

	public static void LogNonPathTween(Tween t) { }

	public static void LogNullTween(Tween t) { }

	public static void LogRemoveActiveTweenError(string errorInfo) { }

	public static void LogReport(object message) { }

	public static void LogWarning(object message) { }

	public static void SetLogPriority(LogBehaviour logBehaviour) { }

}

