namespace Dissonance.Audio.Playback;

internal class Resampler : ISampleSource
{
	private static readonly Log Log; //Field offset: 0x0
	private readonly ISampleSource _source; //Field offset: 0x10
	private readonly IRateProvider _rate; //Field offset: 0x18
	private WaveFormat _outputFormat; //Field offset: 0x20
	private readonly WdlResampler _resampler; //Field offset: 0x28

	public override WaveFormat WaveFormat
	{
		 get { } //Length: 10
	}

	private static Resampler() { }

	public Resampler(ISampleSource source, IRateProvider rate) { }

	public override WaveFormat get_WaveFormat() { }

	private void OnAudioConfigurationChanged(bool deviceWasChanged) { }

	public override void Prepare(SessionContext context) { }

	public override bool Read(ArraySegment samples) { }

	public override void Reset() { }

}

