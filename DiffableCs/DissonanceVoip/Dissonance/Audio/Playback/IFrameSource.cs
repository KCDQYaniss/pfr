namespace Dissonance.Audio.Playback;

internal interface IFrameSource
{

	public uint FrameSize
	{
		 get { } //Length: 0
	}

	[NotNull]
	public WaveFormat WaveFormat
	{
		 get { } //Length: 0
	}

	public uint get_FrameSize() { }

	public WaveFormat get_WaveFormat() { }

	public void Prepare(SessionContext context) { }

	public bool Read(ArraySegment frame) { }

	public void Reset() { }

}

