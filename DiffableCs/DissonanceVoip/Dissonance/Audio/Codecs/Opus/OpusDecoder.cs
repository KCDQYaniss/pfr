namespace Dissonance.Audio.Codecs.Opus;

internal class OpusDecoder : IVoiceDecoder, IDisposable
{
	private readonly WaveFormat _format; //Field offset: 0x10
	private OpusDecoder _decoder; //Field offset: 0x18

	public override WaveFormat Format
	{
		 get { } //Length: 5
	}

	public OpusDecoder(WaveFormat format, bool fec = true) { }

	public override int Decode(EncodedBuffer input, ArraySegment output) { }

	public override void Dispose() { }

	public override WaveFormat get_Format() { }

	public override void Reset() { }

}

