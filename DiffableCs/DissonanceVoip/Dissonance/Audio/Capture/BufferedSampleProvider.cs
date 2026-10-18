namespace Dissonance.Audio.Capture;

internal class BufferedSampleProvider : ISampleProvider
{
	private readonly WaveFormat _format; //Field offset: 0x10
	private readonly TransferBuffer _samples; //Field offset: 0x18

	public int Capacity
	{
		 get { } //Length: 74
	}

	public int Count
	{
		 get { } //Length: 70
	}

	public override WaveFormat WaveFormat
	{
		 get { } //Length: 5
	}

	public BufferedSampleProvider(WaveFormat format, int bufferSize) { }

	public int get_Capacity() { }

	public int get_Count() { }

	public override WaveFormat get_WaveFormat() { }

	public override int Read(float[] buffer, int offset, int count) { }

	public void Reset() { }

	public int Write(ArraySegment data) { }

}

