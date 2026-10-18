namespace Dissonance;

public struct CodecSettings
{
	private readonly Codec _codec; //Field offset: 0x0
	private readonly uint _frameSize; //Field offset: 0x4
	private readonly int _sampleRate; //Field offset: 0x8

	public Codec Codec
	{
		 get { } //Length: 4
	}

	public uint FrameSize
	{
		 get { } //Length: 4
	}

	public int SampleRate
	{
		 get { } //Length: 4
	}

	public CodecSettings(Codec codec, uint frameSize, int sampleRate) { }

	public Codec get_Codec() { }

	public uint get_FrameSize() { }

	public int get_SampleRate() { }

	public virtual string ToString() { }

}

