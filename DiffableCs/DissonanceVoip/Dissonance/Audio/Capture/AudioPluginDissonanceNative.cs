namespace Dissonance.Audio.Capture;

internal static class AudioPluginDissonanceNative
{
	internal enum FilterState
	{
		FilterNotRunning = 0,
		FilterNoInstance = 1,
		FilterNoSamplesSubmitted = 2,
		FilterOk = 3,
	}

	internal enum ProcessorErrors
	{
		Ok = 0,
		Unspecified = -1,
		CreationFailed = -2,
		UnsupportedComponent = -3,
		UnsupportedFunction = -4,
		NullPointer = -5,
		BadParameter = -6,
		BadSampleRate = -7,
		BadDataLength = -8,
		BadNumberChannels = -9,
		FileError = -10,
		StreamParameterNotSet = -11,
		NotEnabled = -12,
	}

	internal enum SampleRates
	{
		SampleRate8KHz = 8000,
		SampleRate16KHz = 16000,
		SampleRate32KHz = 32000,
		SampleRate48KHz = 48000,
	}

	private static readonly Log Log; //Field offset: 0x0
	private const string ImportString = "AudioPluginDissonance"; //Field offset: 0x0
	private const CallingConvention Convention = 2; //Field offset: 0x0

	private static AudioPluginDissonanceNative() { }

	public static void Dissonance_ConfigureAecSuppression(IntPtr handle, AecSuppressionLevels aecLevel, AecmRoutingMode aecmRouting) { }

	public static void Dissonance_ConfigureNoiseSuppression(IntPtr handle, NoiseSuppressionLevels nsLevel) { }

	public static void Dissonance_ConfigureVadSensitivity(IntPtr handle, VadSensitivityLevels nsLevel) { }

	public static IntPtr Dissonance_CreatePreprocessor(NoiseSuppressionLevels nsLevel, AecSuppressionLevels aecLevel, bool aecDelayAgnostic, bool aecExtended, bool aecRefined, AecmRoutingMode aecmRoutingMode, bool aecmComfortNoise) { }

	public static IntPtr Dissonance_CreateRnnoiseState() { }

	public static void Dissonance_DestroyPreprocessor(IntPtr handle) { }

	public static void Dissonance_DestroyRnnoiseState(IntPtr state) { }

	public static void Dissonance_GetAecMetrics(IntPtr floatBuffer, int bufferLength) { }

	public static int Dissonance_GetFilterState() { }

	public static bool Dissonance_GetVadSpeechState(IntPtr handle) { }

	public static ProcessorErrors Dissonance_PreprocessCaptureFrame(IntPtr handle, int sampleRate, float[] input, float[] output, int streamDelay) { }

	public static bool Dissonance_PreprocessorExchangeInstance(IntPtr previous, IntPtr replacement) { }

	public static int Dissonance_RnnoiseGetGains(IntPtr state, float[] output, int length) { }

	public static bool Dissonance_RnnoiseProcessFrame(IntPtr state, int count, int sampleRate, float[] input, float[] output) { }

	public static void Dissonance_SetAgcIsOutputMutedState(IntPtr handle, bool isMuted) { }

	internal static FilterState GetAecFilterState() { }

}

