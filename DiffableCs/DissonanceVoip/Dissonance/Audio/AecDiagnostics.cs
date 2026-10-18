namespace Dissonance.Audio;

public static class AecDiagnostics
{
	internal enum AecState
	{
		FilterNotRunning = 0,
		FilterNoInstance = 1,
		FilterNoSamplesSubmitted = 2,
		FilterOk = 3,
	}

	internal struct AecStats
	{
		public float DelayMedian; //Field offset: 0x0
		public float DelayStdDev; //Field offset: 0x4
		public float FractionPoorDelays; //Field offset: 0x8
		public float EchoReturnLossAverage; //Field offset: 0xC
		public float EchoReturnLossMin; //Field offset: 0x10
		public float EchoReturnLossMax; //Field offset: 0x14
		public float EchoReturnLossEnhancementAverage; //Field offset: 0x18
		public float EchoReturnLossEnhancementMin; //Field offset: 0x1C
		public float EchoReturnLossEnhancementMax; //Field offset: 0x20
		public float ResidualEchoLikelihood; //Field offset: 0x24

	}

	private const string ImportString = "AudioPluginDissonance"; //Field offset: 0x0
	private const CallingConvention Convention = 2; //Field offset: 0x0

	private static void Dissonance_GetAecMetrics(IntPtr buffer, int length) { }

	public static AecState GetState() { }

	public static AecStats GetStats(ref float[] temp) { }

}

