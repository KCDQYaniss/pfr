//Type is in global namespace

public sealed class SpatialAudioSequencePlayer
{
	internal struct Config
	{
		public AudioSourceGroupType groupType; //Field offset: 0x0
		public EAudioCullingMode cullingMode; //Field offset: 0x4
		public EOcclusionTest occlusionTest; //Field offset: 0x8
		public AudioClip startClip; //Field offset: 0x10
		public AudioClip loopClip; //Field offset: 0x18
		public AudioClip endClip; //Field offset: 0x20
		public float volume; //Field offset: 0x28
		public float rolloff; //Field offset: 0x2C
		public AnimationCurve spreadCurve; //Field offset: 0x30
		public float startFadeOutSec; //Field offset: 0x38
		public float loopFadeOutSec; //Field offset: 0x3C
		public bool spatialize; //Field offset: 0x40
		public Vector3 occlusionOffset; //Field offset: 0x44

	}

	private readonly Transform _follow; //Field offset: 0x10
	private readonly Config _config; //Field offset: 0x18
	private BetterSource _startSource; //Field offset: 0x68
	private BetterSource _loopSource; //Field offset: 0x70
	private BetterSource _endSource; //Field offset: 0x78
	private double _loopScheduledStart; //Field offset: 0x80
	private bool _stopping; //Field offset: 0x88

	public SpatialAudioSequencePlayer(Transform follow, Config config) { }

	private BetterSource AcquireSource() { }

	public void Dispose() { }

	private void OnSourceReleased(BetterSource src) { }

	public void Play() { }

	private void ReleaseEndSource() { }

	private void ReleaseLoopSource() { }

	private static void ReleaseSource(BetterSource src) { }

	private void ReleaseStartSource() { }

	private void ScheduleEnd() { }

	private void ScheduleStartAndLoop() { }

	public void Stop() { }

}

