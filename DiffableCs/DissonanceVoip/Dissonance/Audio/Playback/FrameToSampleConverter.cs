namespace Dissonance.Audio.Playback;

internal class FrameToSampleConverter : ISampleSource
{
	private static readonly Log Log; //Field offset: 0x0
	private readonly IFrameSource _source; //Field offset: 0x10
	private readonly float[] _temp; //Field offset: 0x18
	private bool _upstreamComplete; //Field offset: 0x20
	private int _firstSample; //Field offset: 0x24
	private int _lastSample; //Field offset: 0x28

	public override WaveFormat WaveFormat
	{
		 get { } //Length: 78
	}

	private static FrameToSampleConverter() { }

	public FrameToSampleConverter(IFrameSource source) { }

	public override WaveFormat get_WaveFormat() { }

	public override void Prepare(SessionContext context) { }

	public override bool Read(ArraySegment samples) { }

	public override void Reset() { }

}

