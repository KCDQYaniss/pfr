namespace Dissonance.Audio.Capture;

internal interface IFrameProvider
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

	public bool Read(ArraySegment outBuffer) { }

	public void Reset() { }

}

