namespace Audio.SpatialSystem;

[RequireComponent(typeof(MetaXRAudioSource), typeof(MetaXRAudioSourceExperimentalFeatures))]
public sealed class MetaSpatialAudioSource : BaseSpatialAudioSource
{
	[SerializeField]
	private MetaXRAudioSource _metaXRAudioSource; //Field offset: 0x28
	[SerializeField]
	private MetaXRAudioSourceExperimentalFeatures _metaXRAudioSourceExperimental; //Field offset: 0x30
	private bool _isActive; //Field offset: 0x38
	private AudioGroupPreset _preset; //Field offset: 0x40
	private AcousticSettings _acousticSettings; //Field offset: 0x48

	public virtual float DirectivityIntensity
	{
		 get { } //Length: 28
		 set { } //Length: 65
	}

	public virtual bool DirectSoundEnabled
	{
		 get { } //Length: 27
		 set { } //Length: 26
	}

	public virtual float EarlyReflectionsSendDB
	{
		 get { } //Length: 28
		 set { } //Length: 57
	}

	public virtual bool EnableDirectSound
	{
		 get { } //Length: 27
		 set { } //Length: 26
	}

	public virtual bool EnableReverb
	{
		 get { } //Length: 27
		 set { } //Length: 26
	}

	public virtual bool EnableSpatialization
	{
		 get { } //Length: 27
		 set { } //Length: 122
	}

	public virtual float HrtfIntensity
	{
		 get { } //Length: 28
		 set { } //Length: 65
	}

	public virtual float ReverbReach
	{
		 get { } //Length: 28
		 set { } //Length: 65
	}

	public virtual float ReverbSendDB
	{
		 get { } //Length: 28
		 set { } //Length: 57
	}

	public virtual float VolumetricRadius
	{
		 get { } //Length: 28
		 set { } //Length: 35
	}

	public MetaSpatialAudioSource() { }

	public virtual void ApplyAcousticSettings(AcousticSettings settings) { }

	public virtual void ApplySpatializerSettings(SpatializerSettings settings) { }

	protected virtual void Awake() { }

	public virtual float get_DirectivityIntensity() { }

	public virtual bool get_DirectSoundEnabled() { }

	public virtual float get_EarlyReflectionsSendDB() { }

	public virtual bool get_EnableDirectSound() { }

	public virtual bool get_EnableReverb() { }

	public virtual bool get_EnableSpatialization() { }

	public virtual float get_HrtfIntensity() { }

	public virtual float get_ReverbReach() { }

	public virtual float get_ReverbSendDB() { }

	public virtual float get_VolumetricRadius() { }

	public virtual void ManualUpdate() { }

	public virtual void ResetToDefault() { }

	public virtual void set_DirectivityIntensity(float value) { }

	public virtual void set_DirectSoundEnabled(bool value) { }

	public virtual void set_EarlyReflectionsSendDB(float value) { }

	public virtual void set_EnableDirectSound(bool value) { }

	public virtual void set_EnableReverb(bool value) { }

	public virtual void set_EnableSpatialization(bool value) { }

	public virtual void set_HrtfIntensity(float value) { }

	public virtual void set_ReverbReach(float value) { }

	public virtual void set_ReverbSendDB(float value) { }

	public virtual void set_VolumetricRadius(float value) { }

	public virtual void SetActive(bool active) { }

	public virtual void SetParameters(AudioGroupPreset preset) { }

	public virtual void UpdateParameters() { }

}

