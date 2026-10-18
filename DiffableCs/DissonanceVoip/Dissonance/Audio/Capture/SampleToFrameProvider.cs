namespace Dissonance.Audio.Capture;

internal class SampleToFrameProvider : IFrameProvider
{
	private readonly ISampleProvider _source; //Field offset: 0x10
	private readonly uint _frameSize; //Field offset: 0x18
	private int _samplesInFrame; //Field offset: 0x1C
	private readonly float[] _frame; //Field offset: 0x20

	public override uint FrameSize
	{
		 get { } //Length: 4
	}

	public override WaveFormat WaveFormat
	{
		 get { } //Length: 75
	}

	public SampleToFrameProvider(ISampleProvider source, uint frameSize) { }

	public override uint get_FrameSize() { }

	public override WaveFormat get_WaveFormat() { }

	public override bool Read(ArraySegment outBuffer) { }

	public override void Reset() { }

}

