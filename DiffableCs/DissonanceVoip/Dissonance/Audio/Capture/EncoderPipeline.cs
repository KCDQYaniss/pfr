namespace Dissonance.Audio.Capture;

internal class EncoderPipeline : IMicrophoneSubscriber, IDisposable
{
	private static readonly Log Log; //Field offset: 0x0
	private readonly byte[] _encodedBytes; //Field offset: 0x10
	private readonly float[] _plainSamples; //Field offset: 0x18
	private readonly ReadonlyLockedValue _encoder; //Field offset: 0x20
	private readonly ICommsNetwork _net; //Field offset: 0x28
	private readonly BufferedSampleProvider _input; //Field offset: 0x30
	private readonly Resampler _resampler; //Field offset: 0x38
	private readonly IFrameProvider _output; //Field offset: 0x40
	private readonly WaveFormat _inputFormat; //Field offset: 0x48
	private bool _stopped; //Field offset: 0x50
	private bool _stopping; //Field offset: 0x51
	private bool _disposed; //Field offset: 0x52
	[CompilerGenerated]
	private float <TransmissionPacketLoss>k__BackingField; //Field offset: 0x54

	public bool Stopped
	{
		 get { } //Length: 10
	}

	public bool Stopping
	{
		 get { } //Length: 10
	}

	public float TransmissionPacketLoss
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	private static EncoderPipeline() { }

	public EncoderPipeline(WaveFormat inputFormat, IVoiceEncoder encoder, ICommsNetwork net) { }

	public override void Dispose() { }

	private int EncodeFrames(IVoiceEncoder encoder, int maxCount) { }

	public bool get_Stopped() { }

	public bool get_Stopping() { }

	[CompilerGenerated]
	public float get_TransmissionPacketLoss() { }

	public override void ReceiveMicrophoneData(ArraySegment inputSamples, WaveFormat format) { }

	public override void Reset() { }

	[CompilerGenerated]
	public void set_TransmissionPacketLoss(float value) { }

	public void Stop() { }

}

