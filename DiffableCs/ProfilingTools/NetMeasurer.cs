//Type is in global namespace

public static class NetMeasurer
{
	private static AVGValueChangeMeasurer Instance; //Field offset: 0x0
	private static HashSet _beenWritten; //Field offset: 0x8

	private static NetMeasurer() { }

	public static string AVGStats() { }

	[Conditional("UNITY_EDITOR")]
	public static void FinishDiff(string name, double value) { }

	public static void Init(int avgCount) { }

	public static string LastValues() { }

	[Conditional("UNITY_EDITOR")]
	public static void OnFrameEnd() { }

	[Conditional("UNITY_EDITOR")]
	public static void StartDiff(string name, double value) { }

}

