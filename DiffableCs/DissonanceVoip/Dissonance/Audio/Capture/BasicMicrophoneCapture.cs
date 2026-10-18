namespace Dissonance.Audio.Capture;

public class BasicMicrophoneCapture : MonoBehaviour, IMicrophoneCapture, IMicrophoneDeviceList
{
	private static readonly Log Log; //Field offset: 0x0
	private byte _maxReadBufferPower; //Field offset: 0x20
	private readonly POTBuffer _readBuffer; //Field offset: 0x28
	private BufferedSampleProvider _rawMicSamples; //Field offset: 0x30
	private IFrameProvider _rawMicFrames; //Field offset: 0x38
	private float[] _frame; //Field offset: 0x40
	private WaveFormat _format; //Field offset: 0x48
	private AudioClip _clip; //Field offset: 0x50
	private int _readHead; //Field offset: 0x58
	private bool _started; //Field offset: 0x5C
	private string _micName; //Field offset: 0x60
	private bool _audioDeviceChanged; //Field offset: 0x68
	private AudioFileWriter _microphoneDiagnosticOutput; //Field offset: 0x70
	private readonly List _subscribers; //Field offset: 0x78
	[CompilerGenerated]
	private TimeSpan <Latency>k__BackingField; //Field offset: 0x80

	public override string Device
	{
		 get { } //Length: 5
	}

	public override bool IsRecording
	{
		 get { } //Length: 203
	}

	public private override TimeSpan Latency
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private static BasicMicrophoneCapture() { }

	public BasicMicrophoneCapture() { }

	[CanBeNull]
	private static string ChooseMicName(string micName) { }

	private void ConsumeSamples(ArraySegment samples) { }

	private void DrainMicSamples() { }

	public override string get_Device() { }

	public override bool get_IsRecording() { }

	[CompilerGenerated]
	public override TimeSpan get_Latency() { }

	public override void GetDevices(List output) { }

	private void OnAudioDeviceChanged(bool deviceWasChanged) { }

	private void OnDestroy() { }

	private void SendFrame() { }

	[CompilerGenerated]
	private void set_Latency(TimeSpan value) { }

	public override WaveFormat StartCapture(string inputMicName) { }

	public override void StopCapture() { }

	public override void Subscribe(IMicrophoneSubscriber listener) { }

	public override bool Unsubscribe(IMicrophoneSubscriber listener) { }

	public override bool UpdateSubscribers() { }

}

