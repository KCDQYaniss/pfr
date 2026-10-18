//Type is in global namespace

public struct NonspatialAudioBuilder
{
	private readonly BetterAudio _audioSystem; //Field offset: 0x0
	private readonly AudioClip _clip; //Field offset: 0x8
	private AudioSourceGroupType _groupType; //Field offset: 0x10
	private float _volume; //Field offset: 0x14
	private float _panStereo; //Field offset: 0x18
	private bool _reverbEnabled; //Field offset: 0x1C
	private bool _isLooped; //Field offset: 0x1D
	private AudioMixerGroup _mixerGroup; //Field offset: 0x20

	internal NonspatialAudioBuilder(BetterAudio audioSystem, AudioClip clip) { }

	public NonspatialAudioBuilder AsLooped() { }

	public NonspatialAudioBuilder InGroup(AudioSourceGroupType groupType) { }

	public AudioHandle Start() { }

	public NonspatialAudioBuilder WithMixerGroup(AudioMixerGroup mixerGroup) { }

	public NonspatialAudioBuilder WithPan(float panStereo) { }

	public NonspatialAudioBuilder WithReverb(bool enable) { }

	public NonspatialAudioBuilder WithVolume(float volume) { }

}

