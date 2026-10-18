namespace Dissonance.Audio.Codecs.Identity;

internal class IdentityEncoder : IVoiceEncoder, IDisposable
{
	private readonly int _sampleRate; //Field offset: 0x10
	private readonly int _frameSize; //Field offset: 0x14

	public override int FrameSize
	{
		 get { } //Length: 4
	}

	public override float PacketLoss
	{
		 set { } //Length: 3
	}

	public override int SampleRate
	{
		 get { } //Length: 164
	}

	public IdentityEncoder(int sampleRate, int frameSize) { }

	public override void Dispose() { }

	public override ArraySegment Encode(ArraySegment samples, ArraySegment array) { }

	public override int get_FrameSize() { }

	public override int get_SampleRate() { }

	public override void Reset() { }

	public override void set_PacketLoss(float value) { }

}

