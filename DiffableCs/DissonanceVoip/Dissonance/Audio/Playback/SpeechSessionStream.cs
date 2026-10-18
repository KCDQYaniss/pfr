namespace Dissonance.Audio.Playback;

internal class SpeechSessionStream : IJitterEstimator
{
	private static readonly Log Log; //Field offset: 0x0
	private string _metricArrivalDelay; //Field offset: 0x10
	private readonly Queue _awaitingActivation; //Field offset: 0x18
	private readonly IVolumeProvider _volumeProvider; //Field offset: 0x20
	private Nullable _queueHeadFirstDequeueAttempt; //Field offset: 0x28
	private DecoderPipeline _active; //Field offset: 0x38
	private uint _currentId; //Field offset: 0x40
	private string _playerName; //Field offset: 0x48
	private readonly WindowDeviationCalculator _arrivalJitterMeter; //Field offset: 0x50

	private override float Dissonance.Audio.Playback.IJitterEstimator.Confidence
	{
		private get { } //Length: 114
	}

	private override float Dissonance.Audio.Playback.IJitterEstimator.Jitter
	{
		private get { } //Length: 28
	}

	public string PlayerName
	{
		 get { } //Length: 5
		 set { } //Length: 373
	}

	private static SpeechSessionStream() { }

	public SpeechSessionStream(IVolumeProvider volumeProvider) { }

	private override float Dissonance.Audio.Playback.IJitterEstimator.get_Confidence() { }

	private override float Dissonance.Audio.Playback.IJitterEstimator.get_Jitter() { }

	public void ForceReset() { }

	public string get_PlayerName() { }

	public void ReceiveFrame(VoicePacket packet, Nullable now = null) { }

	public void set_PlayerName(string value) { }

	public void StartSession(FrameFormat format, Nullable now = null, IJitterEstimator jitter = null) { }

	public void StopSession(bool logNoSessionError = true) { }

	public Nullable TryDequeueSession(Nullable now = null) { }

}

