namespace Dissonance.Audio.Codecs.Opus;

internal class OpusEncoder : IVoiceEncoder, IDisposable
{
	private static readonly Log Log; //Field offset: 0x0
	public const int FixedSampleRate = 48000; //Field offset: 0x0
	private static readonly int[] PermittedFrameSizesSamples; //Field offset: 0x8
	private readonly OpusEncoder _encoder; //Field offset: 0x10
	private readonly int _frameSize; //Field offset: 0x18

	public override int FrameSize
	{
		 get { } //Length: 4
	}

	public override float PacketLoss
	{
		 set { } //Length: 331
	}

	public override int SampleRate
	{
		 get { } //Length: 6
	}

	private static OpusEncoder() { }

	public OpusEncoder(AudioQuality quality, FrameSize frameSize, bool fec = true) { }

	public override void Dispose() { }

	public override ArraySegment Encode(ArraySegment samples, ArraySegment encodedBuffer) { }

	public override int get_FrameSize() { }

	public override int get_SampleRate() { }

	public static int GetFrameSize(FrameSize size) { }

	private static int GetTargetBitrate(AudioQuality quality) { }

	public override void Reset() { }

	public override void set_PacketLoss(float value) { }

}

