namespace UnityEngine;

[RequireComponent(typeof(Transform))]
[StaticAccessor("AudioSourceBindings", StaticAccessorType::DoubleColon (2))]
public sealed class AudioSource : AudioBehaviour
{

	public bool bypassReverbZones
	{
		 set { } //Length: 93
	}

	[NativeProperty("AudioClip")]
	public AudioClip clip
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public float dopplerLevel
	{
		 set { } //Length: 94
	}

	public bool ignoreListenerPause
	{
		 set { } //Length: 93
	}

	public bool isPlaying
	{
		[NativeName("IsPlayingScripting")]
		 get { } //Length: 78
	}

	public bool loop
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public float maxDistance
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public float minDistance
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public bool mute
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public AudioMixerGroup outputAudioMixerGroup
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	[NativeProperty("StereoPan")]
	public float panStereo
	{
		 set { } //Length: 94
	}

	public float pitch
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public bool playOnAwake
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public int priority
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public float reverbZoneMix
	{
		 set { } //Length: 94
	}

	public AudioRolloffMode rolloffMode
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	[NativeProperty("SpatialBlendMix")]
	public float spatialBlend
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public bool spatialize
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public bool spatializePostEffects
	{
		 set { } //Length: 93
	}

	public float spread
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	[NativeProperty("SecPosition")]
	public float time
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public float volume
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public AudioClip get_clip() { }

	[NativeName("IsPlayingScripting")]
	public bool get_isPlaying() { }

	public bool get_loop() { }

	public float get_maxDistance() { }

	public float get_minDistance() { }

	public bool get_mute() { }

	public AudioMixerGroup get_outputAudioMixerGroup() { }

	public float get_pitch() { }

	public bool get_playOnAwake() { }

	public int get_priority() { }

	public AudioRolloffMode get_rolloffMode() { }

	public float get_spatialBlend() { }

	public bool get_spatialize() { }

	public float get_spread() { }

	public float get_time() { }

	public float get_volume() { }

	public AnimationCurve GetCustomCurve(AudioSourceCurveType type) { }

	private static AnimationCurve GetCustomCurveHelper(AudioSource source, AudioSourceCurveType type) { }

	public void GetOutputData(float[] samples, int channel) { }

	private static void GetOutputDataHelper(AudioSource source, out float[] samples, int channel) { }

	private static float GetPitch(AudioSource source) { }

	public void Pause() { }

	[ExcludeFromDocs]
	public void Play() { }

	private void Play(double delay) { }

	public void PlayDelayed(float delay) { }

	private static void PlayHelper(AudioSource source, ulong delay) { }

	[ExcludeFromDocs]
	public void PlayOneShot(AudioClip clip) { }

	public void PlayOneShot(AudioClip clip, float volumeScale) { }

	private static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale) { }

	public void PlayScheduled(double time) { }

	public void set_bypassReverbZones(bool value) { }

	public void set_clip(AudioClip value) { }

	public void set_dopplerLevel(float value) { }

	public void set_ignoreListenerPause(bool value) { }

	public void set_loop(bool value) { }

	public void set_maxDistance(float value) { }

	public void set_minDistance(float value) { }

	public void set_mute(bool value) { }

	public void set_outputAudioMixerGroup(AudioMixerGroup value) { }

	public void set_panStereo(float value) { }

	public void set_pitch(float value) { }

	public void set_playOnAwake(bool value) { }

	public void set_priority(int value) { }

	public void set_reverbZoneMix(float value) { }

	public void set_rolloffMode(AudioRolloffMode value) { }

	public void set_spatialBlend(float value) { }

	public void set_spatialize(bool value) { }

	public void set_spatializePostEffects(bool value) { }

	public void set_spread(float value) { }

	public void set_time(float value) { }

	public void set_volume(float value) { }

	public void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve) { }

	[NativeThrows]
	private static void SetCustomCurveHelper(AudioSource source, AudioSourceCurveType type, AnimationCurve curve) { }

	private static void SetPitch(AudioSource source, float pitch) { }

	public void SetScheduledEndTime(double time) { }

	public bool SetSpatializerFloat(int index, float value) { }

	public void Stop() { }

	private void Stop(bool stopOneShots) { }

	public void UnPause() { }

}

