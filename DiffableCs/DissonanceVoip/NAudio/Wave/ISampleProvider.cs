namespace NAudio.Wave;

internal interface ISampleProvider
{

	[NotNull]
	public WaveFormat WaveFormat
	{
		 get { } //Length: 0
	}

	public WaveFormat get_WaveFormat() { }

	public int Read(float[] buffer, int offset, int count) { }

}

