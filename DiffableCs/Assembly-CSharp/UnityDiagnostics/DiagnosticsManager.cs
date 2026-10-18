namespace UnityDiagnostics;

public static class DiagnosticsManager
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public string groupName; //Field offset: 0x10

		public <>c__DisplayClass8_0() { }

		internal bool <GetTimeMeasurer>b__0(TimeMeasurer x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public string groupName; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal bool <GetIncrementalMeasurer>b__0(IncrementalMeasurer x) { }

	}

	public static readonly List TIME_MEASURERS; //Field offset: 0x0
	public static readonly List COUNTERS; //Field offset: 0x8
	public static readonly List VALUE_CHANGES; //Field offset: 0x10
	public static readonly List AVGS; //Field offset: 0x18
	public static readonly List MAXS; //Field offset: 0x20

	private static DiagnosticsManager() { }

	public static AvgMeasurer CreateAvgMeasurer(string groupName, int valuesForAverageCalculation = 60) { }

	public static IncrementalMeasurer CreateDiagnosticsCounter(string groupName, int valuesForAverageCalculation = 60) { }

	public static MaxMeasurer CreateMaxMeasurer(string groupName, int valuesForAverageCalculation = 60) { }

	public static TimeMeasurer CreateMeasureTimer(string groupName, int valuesForAverageCalculation = 60) { }

	public static ValueDiffStatisticsMeasurer CreateValueChangeMeasurer(string groupName, int valuesForAverageCalculation = 60) { }

	public static IncrementalMeasurer GetIncrementalMeasurer(string groupName) { }

	public static TimeMeasurer GetTimeMeasurer(string groupName) { }

}

