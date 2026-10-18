namespace Dissonance;

public static class Metrics
{
	private struct MetricEvent
	{
		public readonly string Name; //Field offset: 0x0
		public readonly double Value; //Field offset: 0x8

		public MetricEvent(string name, double value) { }

	}

	private static readonly Log Log; //Field offset: 0x0
	private static Thread _main; //Field offset: 0x8

	private static Metrics() { }

	private static void InternalSampleMetric(string name, double value) { }

	[CanBeNull]
	public static string MetricName(string category, string id) { }

	[CanBeNull]
	public static string MetricName(string category) { }

	public static void Sample(string name, float value) { }

	internal static void WriteMultithreadedMetrics() { }

}

