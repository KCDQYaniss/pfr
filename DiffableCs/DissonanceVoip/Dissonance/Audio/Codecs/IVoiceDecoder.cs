namespace Dissonance.Audio.Codecs;

internal interface IVoiceDecoder : IDisposable
{

	[NotNull]
	public WaveFormat Format
	{
		 get { } //Length: 0
	}

	public int Decode(EncodedBuffer input, ArraySegment output) { }

	public WaveFormat get_Format() { }

	public void Reset() { }

}

