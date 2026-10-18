namespace Dissonance.Audio.Capture;

internal class Resampler : ISampleProvider
{
	private readonly WaveFormat _format; //Field offset: 0x10
	[CanBeNull]
	private readonly WdlResampler _resampler; //Field offset: 0x18
	private readonly ISampleProvider _source; //Field offset: 0x20

	public override WaveFormat WaveFormat
	{
		 get { } //Length: 5
	}

	public Resampler(ISampleProvider source, int newSampleRate) { }

	public override WaveFormat get_WaveFormat() { }

	public override int Read(float[] buffer, int offset, int count) { }

	public void Reset() { }

}

