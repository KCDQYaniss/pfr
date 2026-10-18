namespace Dissonance.Audio.Capture;

internal abstract class BasePreprocessingPipeline : IPreprocessingPipeline, IDisposable, IMicrophoneSubscriber
{
	private static readonly Log Log; //Field offset: 0x0
	private ArvCalculator _arv; //Field offset: 0x10
	private int _droppedSamples; //Field offset: 0x14
	private readonly object _inputWriteLock; //Field offset: 0x18
	private readonly BufferedSampleProvider _resamplerInput; //Field offset: 0x20
	private readonly Resampler _resampler; //Field offset: 0x28
	private readonly SampleToFrameProvider _resampledOutput; //Field offset: 0x30
	private readonly float[] _intermediateFrame; //Field offset: 0x38
	private AudioFileWriter _diagnosticOutputRecorder; //Field offset: 0x40
	private readonly int _outputFrameSize; //Field offset: 0x48
	private readonly WaveFormat _outputFormat; //Field offset: 0x50
	private bool _resetApplied; //Field offset: 0x58
	private int _resetRequested; //Field offset: 0x5C
	private bool _runThread; //Field offset: 0x60
	private readonly DThread _thread; //Field offset: 0x68
	private readonly AutoResetEvent _threadEvent; //Field offset: 0x70
	private readonly ReadonlyLockedValue _micSubscriptions; //Field offset: 0x78
	private int _micSubscriptionCount; //Field offset: 0x80
	private readonly ReadonlyLockedValue _vadSubscriptions; //Field offset: 0x88
	private int _vadSubscriptionCount; //Field offset: 0x90
	private int _upstreamLatencyMs; //Field offset: 0x94
	private readonly int _estimatedPreprocessorLatencyMs; //Field offset: 0x98

	public override float Amplitude
	{
		 get { } //Length: 6
	}

	public abstract bool IsOutputMuted
	{
		 set { } //Length: 0
	}

	[NotNull]
	public override WaveFormat OutputFormat
	{
		 get { } //Length: 5
	}

	public override int OutputFrameSize
	{
		 get { } //Length: 4
	}

	protected int PreprocessorLatencyMs
	{
		 get { } //Length: 13
	}

	public override TimeSpan UpstreamLatency
	{
		 get { } //Length: 162
		 set { } //Length: 139
	}

	protected abstract bool VadIsSpeechDetected
	{
		 get { } //Length: 0
	}

	private static BasePreprocessingPipeline() { }

	protected BasePreprocessingPipeline(WaveFormat inputFormat, int intermediateFrameSize, int intermediateSampleRate, int outputFrameSize, int outputSampleRate) { }

	protected override void ApplyReset() { }

	public override void Dispose() { }

	private override void Dissonance.Audio.Capture.IMicrophoneSubscriber.ReceiveMicrophoneData(ArraySegment data, WaveFormat format) { }

	public override float get_Amplitude() { }

	public override WaveFormat get_OutputFormat() { }

	public override int get_OutputFrameSize() { }

	protected int get_PreprocessorLatencyMs() { }

	public TimeSpan get_UpstreamLatency() { }

	protected abstract bool get_VadIsSpeechDetected() { }

	protected abstract void PreprocessAudioFrame(float[] frame) { }

	public override void Reset() { }

	private void SendResetToSubscribers() { }

	protected void SendSamplesToSubscribers(float[] buffer) { }

	private static void SendStartedTalking(IVoiceActivationListener listener) { }

	private void SendStartedTalking() { }

	private static void SendStoppedTalking(IVoiceActivationListener listener) { }

	private void SendStoppedTalking() { }

	public abstract void set_IsOutputMuted(bool value) { }

	public override void set_UpstreamLatency(TimeSpan value) { }

	public override void Start() { }

	public override void Subscribe(IMicrophoneSubscriber listener) { }

	public override void Subscribe(IVoiceActivationListener listener) { }

	private void ThreadEntry() { }

	protected override void ThreadStart() { }

	public override bool Unsubscribe(IVoiceActivationListener listener) { }

	public override bool Unsubscribe(IMicrophoneSubscriber listener) { }

}

