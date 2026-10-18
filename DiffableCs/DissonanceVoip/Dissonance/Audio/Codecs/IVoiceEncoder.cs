namespace Dissonance.Audio.Codecs;

internal interface IVoiceEncoder : IDisposable
{

	public int FrameSize
	{
		 get { } //Length: 0
	}

	public float PacketLoss
	{
		 set { } //Length: 0
	}

	public int SampleRate
	{
		 get { } //Length: 0
	}

	public ArraySegment Encode(ArraySegment samples, ArraySegment array) { }

	public int get_FrameSize() { }

	public int get_SampleRate() { }

	public void Reset() { }

	public void set_PacketLoss(float value) { }

}

