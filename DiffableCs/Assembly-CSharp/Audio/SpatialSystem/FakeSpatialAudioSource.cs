namespace Audio.SpatialSystem;

public class FakeSpatialAudioSource : BaseSpatialAudioSource
{
	[CompilerGenerated]
	private bool <EnableSpatialization>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private float <HrtfIntensity>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private float <DirectivityIntensity>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private bool <EnableReverb>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private bool <EnableDirectSound>k__BackingField; //Field offset: 0x35
	[CompilerGenerated]
	private float <ReverbSendDB>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private float <EarlyReflectionsSendDB>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private float <ReverbReach>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private float <VolumetricRadius>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private bool <DirectSoundEnabled>k__BackingField; //Field offset: 0x48

	public virtual float DirectivityIntensity
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public virtual bool DirectSoundEnabled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public virtual float EarlyReflectionsSendDB
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public virtual bool EnableDirectSound
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public virtual bool EnableReverb
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public virtual bool EnableSpatialization
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public virtual float HrtfIntensity
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public virtual float ReverbReach
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public virtual float ReverbSendDB
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public virtual float VolumetricRadius
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public FakeSpatialAudioSource() { }

	public virtual void ApplyAcousticSettings(AcousticSettings settings) { }

	public virtual void ApplySpatializerSettings(SpatializerSettings settings) { }

	[CompilerGenerated]
	public virtual float get_DirectivityIntensity() { }

	[CompilerGenerated]
	public virtual bool get_DirectSoundEnabled() { }

	[CompilerGenerated]
	public virtual float get_EarlyReflectionsSendDB() { }

	[CompilerGenerated]
	public virtual bool get_EnableDirectSound() { }

	[CompilerGenerated]
	public virtual bool get_EnableReverb() { }

	[CompilerGenerated]
	public virtual bool get_EnableSpatialization() { }

	[CompilerGenerated]
	public virtual float get_HrtfIntensity() { }

	[CompilerGenerated]
	public virtual float get_ReverbReach() { }

	[CompilerGenerated]
	public virtual float get_ReverbSendDB() { }

	[CompilerGenerated]
	public virtual float get_VolumetricRadius() { }

	public virtual void ManualUpdate() { }

	public virtual void ResetToDefault() { }

	[CompilerGenerated]
	public virtual void set_DirectivityIntensity(float value) { }

	[CompilerGenerated]
	public virtual void set_DirectSoundEnabled(bool value) { }

	[CompilerGenerated]
	public virtual void set_EarlyReflectionsSendDB(float value) { }

	[CompilerGenerated]
	public virtual void set_EnableDirectSound(bool value) { }

	[CompilerGenerated]
	public virtual void set_EnableReverb(bool value) { }

	[CompilerGenerated]
	public virtual void set_EnableSpatialization(bool value) { }

	[CompilerGenerated]
	public virtual void set_HrtfIntensity(float value) { }

	[CompilerGenerated]
	public virtual void set_ReverbReach(float value) { }

	[CompilerGenerated]
	public virtual void set_ReverbSendDB(float value) { }

	[CompilerGenerated]
	public virtual void set_VolumetricRadius(float value) { }

	public virtual void SetActive(bool active) { }

	public virtual void SetParameters(AudioGroupPreset preset) { }

	public virtual void UpdateParameters() { }

}

