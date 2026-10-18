namespace Dissonance.Audio.Codecs.Silence;

internal class SilenceDecoder : IVoiceDecoder, IDisposable
{
	private readonly int _frameSize; //Field offset: 0x10
	private readonly WaveFormat _format; //Field offset: 0x18

	public override WaveFormat Format
	{
		 get { } //Length: 5
	}

	public SilenceDecoder(FrameFormat frameFormat) { }

	public override int Decode(EncodedBuffer input, ArraySegment output) { }

	public override void Dispose() { }

	public override WaveFormat get_Format() { }

	public override void Reset() { }

}

