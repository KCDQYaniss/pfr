//Type is in global namespace

public struct SpatialAudioBuilder
{
	private readonly BetterAudio _audioSystem; //Field offset: 0x0
	private readonly AudioClip _clip; //Field offset: 0x8
	private readonly SoundBank _soundBank; //Field offset: 0x10
	private Vector3 _position; //Field offset: 0x18
	private float _distance; //Field offset: 0x24
	private AudioSourceGroupType _groupType; //Field offset: 0x28
	private float _rolloff; //Field offset: 0x2C
	private PlayOptions _options; //Field offset: 0x30
	private bool _useFixedDelay; //Field offset: 0x80
	private float _delayTime; //Field offset: 0x84
	private bool _usePhysicalDelay; //Field offset: 0x88
	private GameObject _trackingObject; //Field offset: 0x90
	private IPlayer _trackingPlayer; //Field offset: 0x98
	private bool _useLimiter; //Field offset: 0xA0
	private Vector2 _limitGagRadius; //Field offset: 0xA4
	private float _limitChokeTime; //Field offset: 0xAC
	private string _limitKey; //Field offset: 0xB0

	internal SpatialAudioBuilder(BetterAudio audioSystem, AudioClip clip, int rolloff) { }

	internal SpatialAudioBuilder(BetterAudio audioSystem, SoundBank soundBank) { }

	public SpatialAudioBuilder AsLooped() { }

	public SpatialAudioBuilder At(Vector3 position, float knownDistance = -1) { }

	public SpatialAudioBuilder AtListener(bool atListener = true) { }

	private float CalculateDistance() { }

	private void FireSimple(out BetterSource source) { }

	public SpatialAudioBuilder ForPlayer(IPlayer player) { }

	private void GetOptionsWithDistanceBlend(out PlayOptions opts) { }

	public SpatialAudioBuilder InGroup(AudioSourceGroupType groupType) { }

	private void InitDefaults() { }

	public SpatialAudioBuilder RequiresUpdate(bool needUpdate) { }

	public SpatialAudioBuilder Spatialize(bool spatialize = true, float spatialBlend = 1) { }

	public AudioHandle Start() { }

	public SpatialAudioBuilder TrackedBy(GameObject gameObject) { }

	private bool TryFireFixedDelay(out BetterSource source) { }

	private bool TryFireLimiter(out BetterSource source) { }

	private bool TryFirePhysicalDelay(out BetterSource source) { }

	private bool TryFireTracked(out BetterSource source) { }

	public SpatialAudioBuilder WithBankBlend(float bankBlendValue) { }

	public SpatialAudioBuilder WithClipStartOffset(float clipStartOffsetSeconds) { }

	public SpatialAudioBuilder WithCustomOutputGroup(AudioSourceGroupType customOutputGroup) { }

	public SpatialAudioBuilder WithDelay(float delayInSeconds) { }

	public SpatialAudioBuilder WithEnvironment(EnvironmentType environment) { }

	public SpatialAudioBuilder WithEQ(bool enable = true) { }

	public SpatialAudioBuilder WithLimiter(string gagKey, Vector2 gagRadius, float chokeTime = 0) { }

	public SpatialAudioBuilder WithMixerGroup(AudioMixerGroup mixerGroup) { }

	public SpatialAudioBuilder WithOcclusion(bool useOcclusion, EOcclusionTest testType = 0) { }

	public SpatialAudioBuilder WithOcclusionOffset(Vector3 offset, bool positionStatic = false) { }

	public SpatialAudioBuilder WithPhysicalDelay() { }

	public SpatialAudioBuilder WithPitch(float pitch) { }

	public SpatialAudioBuilder WithReverb(bool enable = true) { }

	public SpatialAudioBuilder WithRolloff(float rolloff) { }

	public SpatialAudioBuilder WithVolume(float volume) { }

}

