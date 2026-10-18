namespace Dissonance.Audio.Playback;

internal interface ISampleSource
{

	[NotNull]
	public WaveFormat WaveFormat
	{
		 get { } //Length: 0
	}

	public WaveFormat get_WaveFormat() { }

	public void Prepare(SessionContext context) { }

	public bool Read(ArraySegment samples) { }

	public void Reset() { }

}

