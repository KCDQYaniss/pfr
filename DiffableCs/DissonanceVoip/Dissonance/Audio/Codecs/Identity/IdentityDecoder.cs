namespace Dissonance.Audio.Codecs.Identity;

internal class IdentityDecoder : IVoiceDecoder, IDisposable
{
	private readonly WaveFormat _format; //Field offset: 0x10

	public override WaveFormat Format
	{
		 get { } //Length: 5
	}

	public IdentityDecoder(WaveFormat format) { }

	public override int Decode(EncodedBuffer input, ArraySegment output) { }

	public override void Dispose() { }

	public override WaveFormat get_Format() { }

	public override void Reset() { }

}

