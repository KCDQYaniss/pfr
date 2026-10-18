namespace NAudio.Wave;

public sealed class WaveFormat
{
	private readonly int _channels; //Field offset: 0x10
	private readonly int _sampleRate; //Field offset: 0x14

	public int Channels
	{
		 get { } //Length: 164
	}

	public int SampleRate
	{
		 get { } //Length: 4
	}

	public WaveFormat(int sampleRate, int channels) { }

	public bool Equals(WaveFormat other) { }

	public int get_Channels() { }

	public int get_SampleRate() { }

	public virtual int GetHashCode() { }

	public virtual string ToString() { }

}

