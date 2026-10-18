namespace EFT;

public static class AudioUtils
{
	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__LinearInterpolation; //Field offset: 0x0
		public static Func <1>__EaseInInterpolation; //Field offset: 0x8
		public static Func <2>__EaseOutInterpolation; //Field offset: 0x10
		public static Func <3>__EaseInOutInterpolation; //Field offset: 0x18
		public static Func <4>__ExponentialInterpolation; //Field offset: 0x20
		public static Func <5>__InverseExponentialInterpolation; //Field offset: 0x28
		public static Func <6>__LogarithmicInterpolation; //Field offset: 0x30
		public static Func <7>__SmoothStepInterpolation; //Field offset: 0x38
		public static Func <8>__LogisticInterpolation; //Field offset: 0x40

	}

	public const float SOUND_SPEED_MS = 343.2; //Field offset: 0x0
	public const float MIN_DB = -80; //Field offset: 0x0
	public const float MAX_DB = 0; //Field offset: 0x0
	public const float DECIBEL_SCALE_FACTOR = 20; //Field offset: 0x0
	public const float DEFAULT_LOW_PASS_FREQ = 22000; //Field offset: 0x0
	public const float DEFAULT_HIGH_PASS_FREQ = 20; //Field offset: 0x0
	public const float OUTDOOR_HIGH_PASS_FREQ = 320; //Field offset: 0x0
	public const float DEFAULT_Q = 1; //Field offset: 0x0
	private const double DSP_SCHEDULE_LOOKAHEAD_FALLBACK_SEC = 0.05; //Field offset: 0x0
	private static Nullable _cachedDspScheduleLookaheadSec; //Field offset: 0x0
	private const string PREWARM_SOUND_PATH = "Audio/prewarm_sound"; //Field offset: 0x0
	private static AudioClip _prewarmClip; //Field offset: 0x10

	public static double DspBufferDuration
	{
		 get { } //Length: 201
	}

	public static double DspScheduleLookaheadSec
	{
		 get { } //Length: 538
	}

	public static AudioClip PrewarmClip
	{
		 get { } //Length: 441
	}

	public static double SafeScheduleLookahead
	{
		 get { } //Length: 207
	}

	public static float CalculateHeightPercentageRelativeToBounds(Vector3 point, in Bounds bounds) { }

	public static float CalculatePhysicSoundDelay(Vector3 listenerPosition, Vector3 soundPosition) { }

	public static float CalculatePhysicSoundDelay(Vector3 soundPosition) { }

	public static float CalculateSoundDelay(float distance) { }

	public static float CalculateVolumeInDB(float baseDb, float multiplier) { }

	public static bool CheckClipping(float[] samples) { }

	public static float ClampDopplerLevel(float dopplerLevel) { }

	public static float ClampFreq(float f) { }

	public static float ClampQ(float q) { }

	public static float ClampSpread(float spread) { }

	public static float ClampTimeForClip(float time, AudioClip clip) { }

	public static float ConvertDBToNormalizedVolume(float volumeDB) { }

	public static float ConvertNormalizedValueToCutoffFrequency(float valueNormalized) { }

	public static float ConvertNormalizedVolumeToDB(float volumeNormalized) { }

	public static float ConvertPercentageToDB(int percentage, float maxVolumeDb = 0) { }

	public static float ConvertRmsToDecibels(float rms, float minDb, float refValue) { }

	public static AudioClip CreateEmptyMonoClip() { }

	public static float EaseInInterpolation(float t) { }

	public static float EaseInOutInterpolation(float t) { }

	public static float EaseOutInterpolation(float t) { }

	public static float EvaluateFade(EAudioFadeType fadeType, float t) { }

	public static float ExponentialInterpolation(float t) { }

	public static double get_DspBufferDuration() { }

	public static double get_DspScheduleLookaheadSec() { }

	public static AudioClip get_PrewarmClip() { }

	public static double get_SafeScheduleLookahead() { }

	public static Func GetEasingFunction(EAudioFadeType fadeType) { }

	public static float GetNormalizedImpact(Rigidbody rb, float startHeightY, float maxImpact = 10) { }

	public static float GetOutputVolume(float[] samples) { }

	public static EAudioQuality GetQualityByLogicCores() { }

	public static float GetSqrDistanceToListener(Vector3 position) { }

	public static float InverseExponentialInterpolation(float t) { }

	public static bool IsInRange(float sqrDistanceToListener, float maxDistance) { }

	public static bool IsInRange(Vector3 position, float maxDistance) { }

	public static float LinearInterpolation(float t) { }

	public static float LogarithmicInterpolation(float t) { }

	public static float LogisticInterpolation(float t) { }

	public static void ResetAudioBuffer() { }

	public static float SmoothStepInterpolation(float t) { }

}

