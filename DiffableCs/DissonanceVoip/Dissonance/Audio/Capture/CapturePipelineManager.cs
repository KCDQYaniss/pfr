namespace Dissonance.Audio.Capture;

internal class CapturePipelineManager : IAmplitudeProvider, ILossEstimator
{
	private static readonly Log Log; //Field offset: 0x0
	private bool _isMobilePlatform; //Field offset: 0x10
	private readonly CodecSettingsLoader _codecSettingsLoader; //Field offset: 0x18
	private readonly RoomChannels _roomChannels; //Field offset: 0x20
	private readonly PlayerChannels _playerChannels; //Field offset: 0x28
	private readonly PacketLossMonitor _receivingPacketLossMonitor; //Field offset: 0x30
	[CanBeNull]
	private ICommsNetwork _network; //Field offset: 0x38
	private IMicrophoneCapture _microphone; //Field offset: 0x40
	private IPreprocessingPipeline _preprocessor; //Field offset: 0x48
	private EncoderPipeline _encoder; //Field offset: 0x50
	private bool _encounteredFatalException; //Field offset: 0x58
	private bool _netModeRequiresPipeline; //Field offset: 0x59
	private bool _cannotStartMic; //Field offset: 0x5A
	private bool _encoderSubscribed; //Field offset: 0x5B
	private int _startupDelay; //Field offset: 0x5C
	private FrameSkipDetector _skipDetector; //Field offset: 0x60
	private readonly List _activationListeners; //Field offset: 0x80
	private readonly List _audioListeners; //Field offset: 0x88
	private string _micName; //Field offset: 0x90
	private bool _pendingResetRequest; //Field offset: 0x98

	public override float Amplitude
	{
		 get { } //Length: 84
	}

	[CanBeNull]
	public IMicrophoneCapture Microphone
	{
		 get { } //Length: 5
	}

	public string MicrophoneName
	{
		 get { } //Length: 8
		 set { } //Length: 509
	}

	public override float PacketLoss
	{
		 get { } //Length: 28
	}

	private static CapturePipelineManager() { }

	public CapturePipelineManager(CodecSettingsLoader codecSettingsLoader, RoomChannels roomChannels, PlayerChannels playerChannels, ReadOnlyCollection players, int startupDelay = 0) { }

	[NotNull]
	protected override IPreprocessingPipeline CreatePreprocessor(WaveFormat format) { }

	public void Destroy() { }

	public void ForceReset() { }

	public override float get_Amplitude() { }

	public IMicrophoneCapture get_Microphone() { }

	public string get_MicrophoneName() { }

	public override float get_PacketLoss() { }

	private static bool IsMobilePlatform() { }

	private void Net_ModeChanged(NetworkMode mode) { }

	private void OnAudioDeviceChanged(bool devicewaschanged) { }

	internal void Pause() { }

	private void RestartTransmissionPipeline(string reason) { }

	internal void Resume(string reason = null) { }

	public void set_MicrophoneName(string value) { }

	public void Start(ICommsNetwork network, IMicrophoneCapture microphone) { }

	private void StopTransmissionPipeline() { }

	public void Subscribe(IVoiceActivationListener listener) { }

	public void Subscribe(IMicrophoneSubscriber listener) { }

	public void Unsubscribe(IVoiceActivationListener listener) { }

	public void Unsubscribe(IMicrophoneSubscriber listener) { }

	public void Update(bool muted, float deltaTime) { }

}

