namespace Dissonance.Audio.Capture;

internal class WebRtcPreprocessingPipeline : BasePreprocessingPipeline
{
	public sealed class RnnoisePreprocessor : IDisposable
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__8_0; //Field offset: 0x8
			public static Func <>9__8_2; //Field offset: 0x10

			private static <>c() { }

			public <>c() { }

			internal bool <.ctor>b__8_0(VoiceSettings v) { }

			internal float <.ctor>b__8_2(VoiceSettings v) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0`1
		{
			public string propertyName; //Field offset: 0x0
			public Action setValue; //Field offset: 0x0
			public Func getValue; //Field offset: 0x0
			public VoiceSettings settings; //Field offset: 0x0

			public <>c__DisplayClass9_0`1() { }

			internal void <Bind>b__0(object sender, PropertyChangedEventArgs args) { }

		}

		private bool _enabled; //Field offset: 0x10
		private float _wetMix; //Field offset: 0x14
		private readonly LockedValue _handle; //Field offset: 0x18
		private readonly List _subscribed; //Field offset: 0x20
		private float[] _temp; //Field offset: 0x28

		private bool Enabled
		{
			private get { } //Length: 5
			private set { } //Length: 545
		}

		public RnnoisePreprocessor() { }

		[CompilerGenerated]
		private void <.ctor>b__8_1(bool a) { }

		[CompilerGenerated]
		private void <.ctor>b__8_3(float a) { }

		private void Bind(Func getValue, string propertyName, Action setValue) { }

		public override void Dispose() { }

		protected virtual void Finalize() { }

		private bool get_Enabled() { }

		public int GetGains(float[] output) { }

		public void Process(SampleRates inputSampleRate, float[] input, float[] output) { }

		private void ReleaseUnmanagedResources() { }

		public void Reset() { }

		private void set_Enabled(bool value) { }

	}

	public sealed class WebRtcPreprocessor : IDisposable
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__23_0; //Field offset: 0x8
			public static Func <>9__23_2; //Field offset: 0x10
			public static Func <>9__23_4; //Field offset: 0x18
			public static Func <>9__23_6; //Field offset: 0x20

			private static <>c() { }

			public <>c() { }

			internal NoiseSuppressionLevels <SetFilterPreprocessor>b__23_0(VoiceSettings s) { }

			internal AecSuppressionLevels <SetFilterPreprocessor>b__23_2(VoiceSettings s) { }

			internal AecmRoutingMode <SetFilterPreprocessor>b__23_4(VoiceSettings s) { }

			internal VadSensitivityLevels <SetFilterPreprocessor>b__23_6(VoiceSettings s) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass24_0`1
		{
			public string propertyName; //Field offset: 0x0
			public Action setValue; //Field offset: 0x0
			public Func getValue; //Field offset: 0x0
			public VoiceSettings settings; //Field offset: 0x0

			public <>c__DisplayClass24_0`1() { }

			internal void <Bind>b__0(object sender, PropertyChangedEventArgs args) { }

		}

		private readonly LockedValue _handle; //Field offset: 0x10
		private readonly List _subscribed; //Field offset: 0x18
		private readonly bool _useMobileAec; //Field offset: 0x20
		private NoiseSuppressionLevels _nsLevel; //Field offset: 0x24
		private VadSensitivityLevels _vadlevel; //Field offset: 0x28
		private AecSuppressionLevels _aecLevel; //Field offset: 0x2C
		private AecmRoutingMode _aecmLevel; //Field offset: 0x30

		private AecmRoutingMode AecmSuppressionLevel
		{
			private get { } //Length: 4
			private set { } //Length: 377
		}

		private AecSuppressionLevels AecSuppressionLevel
		{
			private get { } //Length: 4
			private set { } //Length: 377
		}

		private NoiseSuppressionLevels NoiseSuppressionLevel
		{
			private get { } //Length: 4
			private set { } //Length: 480
		}

		private VadSensitivityLevels VadSensitivityLevel
		{
			private get { } //Length: 4
			private set { } //Length: 365
		}

		public WebRtcPreprocessor(bool useMobileAec) { }

		[CompilerGenerated]
		private void <SetFilterPreprocessor>b__23_1(NoiseSuppressionLevels v) { }

		[CompilerGenerated]
		private void <SetFilterPreprocessor>b__23_3(AecSuppressionLevels v) { }

		[CompilerGenerated]
		private void <SetFilterPreprocessor>b__23_5(AecmRoutingMode v) { }

		[CompilerGenerated]
		private void <SetFilterPreprocessor>b__23_7(VadSensitivityLevels v) { }

		private void Bind(Func getValue, string propertyName, Action setValue) { }

		private bool ClearFilterPreprocessor(bool throwOnError = true) { }

		private IntPtr CreatePreprocessor() { }

		public override void Dispose() { }

		protected virtual void Finalize() { }

		private AecmRoutingMode get_AecmSuppressionLevel() { }

		private AecSuppressionLevels get_AecSuppressionLevel() { }

		private NoiseSuppressionLevels get_NoiseSuppressionLevel() { }

		private VadSensitivityLevels get_VadSensitivityLevel() { }

		public bool Process(SampleRates inputSampleRate, float[] input, float[] output, int estimatedStreamDelay, bool isOutputMuted) { }

		private void ReleaseUnmanagedResources() { }

		public void Reset() { }

		private void set_AecmSuppressionLevel(AecmRoutingMode value) { }

		private void set_AecSuppressionLevel(AecSuppressionLevels value) { }

		private void set_NoiseSuppressionLevel(NoiseSuppressionLevels value) { }

		private void set_VadSensitivityLevel(VadSensitivityLevels value) { }

		private void SetFilterPreprocessor(IntPtr preprocessor) { }

	}

	private static readonly Log Log; //Field offset: 0x0
	private bool _isVadDetectingSpeech; //Field offset: 0xA0
	private readonly bool _isMobilePlatform; //Field offset: 0xA1
	private WebRtcPreprocessor _preprocessor; //Field offset: 0xA8
	private RnnoisePreprocessor _rnnoise; //Field offset: 0xB0
	private bool _isOutputMuted; //Field offset: 0xB8

	public virtual bool IsOutputMuted
	{
		 set { } //Length: 7
	}

	protected virtual bool VadIsSpeechDetected
	{
		 get { } //Length: 8
	}

	private static WebRtcPreprocessingPipeline() { }

	public WebRtcPreprocessingPipeline(WaveFormat inputFormat, bool mobilePlatform) { }

	protected virtual void ApplyReset() { }

	public virtual void Dispose() { }

	protected virtual bool get_VadIsSpeechDetected() { }

	internal static FilterState GetAecFilterState() { }

	internal int GetBackgroundNoiseRemovalGains(float[] output) { }

	protected virtual void PreprocessAudioFrame(float[] frame) { }

	public virtual void set_IsOutputMuted(bool value) { }

	protected virtual void ThreadStart() { }

}

