namespace Dissonance.Audio.Playback;

internal class VolumeRampedFrameSource : IFrameSource
{
	private readonly IFrameSource _source; //Field offset: 0x10
	private readonly IVolumeProvider _volumeProvider; //Field offset: 0x18
	private float _targetVolume; //Field offset: 0x20
	private float _currentVolume; //Field offset: 0x24

	public override uint FrameSize
	{
		 get { } //Length: 75
	}

	public override WaveFormat WaveFormat
	{
		 get { } //Length: 78
	}

	public VolumeRampedFrameSource(IFrameSource source, IVolumeProvider volumeProvider) { }

	private static void ApplyFlatAttenuation(ArraySegment frame, float volume) { }

	private static void ApplyRampedAttenuation(ArraySegment frame, float start, float end) { }

	public override uint get_FrameSize() { }

	public override WaveFormat get_WaveFormat() { }

	public override void Prepare(SessionContext context) { }

	public override bool Read(ArraySegment frame) { }

	public override void Reset() { }

}

