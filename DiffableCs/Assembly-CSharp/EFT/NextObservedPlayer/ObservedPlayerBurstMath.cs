namespace EFT.NextObservedPlayer;

public static class ObservedPlayerBurstMath
{

	public static double DynamicAdjustment(double sendInterval, double jitterStandardDeviation, double dynamicAdjustmentTolerance, double maxMultiplier) { }

	public static void EmaAdd(ref ObservedPlayerBurstEma ema, double newValue, double alpha) { }

	public static void EmaReset(ref ObservedPlayerBurstEma ema) { }

	public static double Timescale(double drift, double catchupSpeed, double slowdownSpeed, double catchupNegativeThreshold, double catchupPositiveThreshold, double maxCatchupSpeed) { }

}

