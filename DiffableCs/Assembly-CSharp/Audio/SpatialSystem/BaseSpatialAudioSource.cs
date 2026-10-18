namespace Audio.SpatialSystem;

[RequireComponent(typeof(AudioSource))]
public abstract class BaseSpatialAudioSource : MonoBehaviour, ISpatialized, IReverberated, IManualUpdated
{
	[CompilerGenerated]
	private AudioSource <ParentSource>k__BackingField; //Field offset: 0x20

	public abstract float DirectivityIntensity
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public abstract bool DirectSoundEnabled
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public abstract float EarlyReflectionsSendDB
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public abstract bool EnableDirectSound
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public abstract bool EnableReverb
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public abstract bool EnableSpatialization
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public abstract float HrtfIntensity
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	protected private AudioSource ParentSource
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public abstract float ReverbReach
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public abstract float ReverbSendDB
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public abstract float VolumetricRadius
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	protected BaseSpatialAudioSource() { }

	public abstract void ApplyAcousticSettings(AcousticSettings settings) { }

	public abstract void ApplySpatializerSettings(SpatializerSettings settings) { }

	protected override void Awake() { }

	public abstract float get_DirectivityIntensity() { }

	public abstract bool get_DirectSoundEnabled() { }

	public abstract float get_EarlyReflectionsSendDB() { }

	public abstract bool get_EnableDirectSound() { }

	public abstract bool get_EnableReverb() { }

	public abstract bool get_EnableSpatialization() { }

	public abstract float get_HrtfIntensity() { }

	[CompilerGenerated]
	protected AudioSource get_ParentSource() { }

	public abstract float get_ReverbReach() { }

	public abstract float get_ReverbSendDB() { }

	public abstract float get_VolumetricRadius() { }

	public abstract void ManualUpdate() { }

	public abstract void ResetToDefault() { }

	public abstract void set_DirectivityIntensity(float value) { }

	public abstract void set_DirectSoundEnabled(bool value) { }

	public abstract void set_EarlyReflectionsSendDB(float value) { }

	public abstract void set_EnableDirectSound(bool value) { }

	public abstract void set_EnableReverb(bool value) { }

	public abstract void set_EnableSpatialization(bool value) { }

	public abstract void set_HrtfIntensity(float value) { }

	[CompilerGenerated]
	private void set_ParentSource(AudioSource value) { }

	public abstract void set_ReverbReach(float value) { }

	public abstract void set_ReverbSendDB(float value) { }

	public abstract void set_VolumetricRadius(float value) { }

	public abstract void SetActive(bool active) { }

	public abstract void SetParameters(AudioGroupPreset preset) { }

	public abstract void UpdateParameters() { }

}

