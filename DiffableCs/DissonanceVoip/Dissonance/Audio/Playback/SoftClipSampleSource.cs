namespace Dissonance.Audio.Playback;

internal class SoftClipSampleSource : ISampleSource
{
	private readonly ISampleSource _upstream; //Field offset: 0x10
	private readonly OpusSoftClip _clipper; //Field offset: 0x18

	public override WaveFormat WaveFormat
	{
		 get { } //Length: 75
	}

	public SoftClipSampleSource(ISampleSource upstream) { }

	public override WaveFormat get_WaveFormat() { }

	public override void Prepare(SessionContext context) { }

	public override bool Read(ArraySegment samples) { }

	public override void Reset() { }

}

