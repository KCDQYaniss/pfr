namespace Mirror;

public static class SnapshotInterpolation
{

	public static double DynamicAdjustment(double sendInterval, double jitterStandardDeviation, double dynamicAdjustmentTolerance) { }

	public static void InsertAndAdjust(SortedList buffer, T snapshot, ref double localTimeline, ref double localTimescale, float sendInterval, double bufferTime, double catchupSpeed, double slowdownSpeed, ref ExponentialMovingAverage driftEma, float catchupNegativeThreshold, float catchupPositiveThreshold, ref ExponentialMovingAverage deliveryTimeEma) { }

	public static bool InsertIfNotExists(SortedList buffer, T snapshot) { }

	public static void Sample(SortedList buffer, double localTimeline, out int from, out int to, out double t) { }

	public static void Step(SortedList buffer, double deltaTime, ref double localTimeline, double localTimescale, out T fromSnapshot, out T toSnapshot, out double t) { }

	public static void StepInterpolation(SortedList buffer, double localTimeline, out T fromSnapshot, out T toSnapshot, out double t) { }

	public static void StepTime(double deltaTime, ref double localTimeline, double localTimescale) { }

	public static double Timescale(double drift, double catchupSpeed, double slowdownSpeed, double catchupNegativeThreshold, double catchupPositiveThreshold) { }

}

