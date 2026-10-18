namespace Audio.SpatialSystem;

[RequireComponent(typeof(AudioLowPassFilter))]
[RequireComponent(typeof(AudioHighPassFilter))]
[RequireComponent(typeof(AudioSource))]
public class SimpleUnitySpatializer : BaseSpatialAudioSource
{
	private Transform _listenerTransform; //Field offset: 0x28
	[Header("Smoothing")]
	[Tooltip("Smoothing speed used for filter parameter interpolation (higher = faster)")]
	public float smoothSpeed; //Field offset: 0x30
	[Header("Low-pass (hz)")]
	[SerializeField]
	[Tooltip("Cutoff frequency when source is in front of listener")]
	private float _lpFront; //Field offset: 0x34
	[SerializeField]
	[Tooltip("Cutoff frequency when source is behind listener")]
	private float _lpBehind; //Field offset: 0x38
	[SerializeField]
	[Tooltip("Cutoff frequency when source is below listener")]
	private float _lpBelow; //Field offset: 0x3C
	[Header("High-pass (hz)")]
	[SerializeField]
	[Tooltip("Default high-pass cutoff frequency")]
	private float _hpDefault; //Field offset: 0x40
	[SerializeField]
	[Tooltip("High-pass cutoff frequency when source is above listener")]
	private float _hpAbove; //Field offset: 0x44
	[SerializeField]
	[Tooltip("High-pass cutoff frequency when source is behind listener")]
	private float _hpBehind; //Field offset: 0x48
	[Header("Q (resonance) Range")]
	[SerializeField]
	[Tooltip("Minimum Q value allowed for filters")]
	private float _minQ; //Field offset: 0x4C
	[SerializeField]
	[Tooltip("Maximum Q value allowed for filters")]
	private float _maxQ; //Field offset: 0x50
	[SerializeField]
	[Tooltip("Low-pass Q when source is in front")]
	private float _qFront; //Field offset: 0x54
	[SerializeField]
	[Tooltip("Low-pass Q when source is behind")]
	private float _qBehind; //Field offset: 0x58
	[SerializeField]
	[Tooltip("High-pass Q when source is above")]
	private float _qAbove; //Field offset: 0x5C
	[SerializeField]
	[Tooltip("Low-pass Q when source is below")]
	private float _qBelow; //Field offset: 0x60
	[Header("Blend Multipliers")]
	[SerializeField]
	[Tooltip("Multiplier applied when source is below listener for low-pass blending")]
	private float _belowLpBlendFactor; //Field offset: 0x64
	[SerializeField]
	[Tooltip("Multiplier applied for high-pass when source is behind the listener")]
	private float _behindHpBlendFactor; //Field offset: 0x68
	[SerializeField]
	[Tooltip("Multiplier applied for low-pass Q when source is below the listener")]
	private float _belowQBlendFactor; //Field offset: 0x6C
	[SerializeField]
	[Tooltip("Multiplier applied for high-pass Q when source is behind the listener")]
	private float _behindQBlendFactor; //Field offset: 0x70
	[Header("Thresholds / Helpers")]
	[SerializeField]
	[Tooltip("Minimum distance considered for direction calculations")]
	private float _minDistThreshold; //Field offset: 0x74
	[SerializeField]
	[Tooltip("Divisor (degrees) used to map elevation to above/below factors (default 90)")]
	private float _elevationDivisor; //Field offset: 0x78
	[Header("Behavior")]
	[SerializeField]
	private bool _enableSpatialization; //Field offset: 0x7C
	[SerializeField]
	private float _hrtfIntensity; //Field offset: 0x80
	[SerializeField]
	private float _directivityIntensity; //Field offset: 0x84
	private BetterSource _provider; //Field offset: 0x88
	private float _targetLp; //Field offset: 0x90
	private float _targetHp; //Field offset: 0x94
	private float _targetLpq; //Field offset: 0x98
	private float _targetHpq; //Field offset: 0x9C
	private float _elevationFactor; //Field offset: 0xA0
	[CompilerGenerated]
	private bool <EnableReverb>k__BackingField; //Field offset: 0xA4
	[CompilerGenerated]
	private bool <EnableDirectSound>k__BackingField; //Field offset: 0xA5
	[CompilerGenerated]
	private float <ReverbSendDB>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private float <EarlyReflectionsSendDB>k__BackingField; //Field offset: 0xAC
	[CompilerGenerated]
	private float <ReverbReach>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private float <VolumetricRadius>k__BackingField; //Field offset: 0xB4
	[CompilerGenerated]
	private bool <DirectSoundEnabled>k__BackingField; //Field offset: 0xB8

	public virtual float DirectivityIntensity
	{
		 get { } //Length: 9
		 set { } //Length: 18
	}

	public virtual bool DirectSoundEnabled
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public virtual float EarlyReflectionsSendDB
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public virtual bool EnableDirectSound
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public virtual bool EnableReverb
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public virtual bool EnableSpatialization
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public virtual float HrtfIntensity
	{
		 get { } //Length: 9
		 set { } //Length: 39
	}

	public virtual float ReverbReach
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public virtual float ReverbSendDB
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public virtual float VolumetricRadius
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public SimpleUnitySpatializer() { }

	public virtual void ApplyAcousticSettings(AcousticSettings settings) { }

	public virtual void ApplySpatializerSettings(SpatializerSettings settings) { }

	protected virtual void Awake() { }

	private void EvaluateSpatializationParameters() { }

	public virtual float get_DirectivityIntensity() { }

	[CompilerGenerated]
	public virtual bool get_DirectSoundEnabled() { }

	[CompilerGenerated]
	public virtual float get_EarlyReflectionsSendDB() { }

	[CompilerGenerated]
	public virtual bool get_EnableDirectSound() { }

	[CompilerGenerated]
	public virtual bool get_EnableReverb() { }

	public virtual bool get_EnableSpatialization() { }

	public virtual float get_HrtfIntensity() { }

	[CompilerGenerated]
	public virtual float get_ReverbReach() { }

	[CompilerGenerated]
	public virtual float get_ReverbSendDB() { }

	[CompilerGenerated]
	public virtual float get_VolumetricRadius() { }

	public virtual void ManualUpdate() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnValidate() { }

	public virtual void ResetToDefault() { }

	public virtual void set_DirectivityIntensity(float value) { }

	[CompilerGenerated]
	public virtual void set_DirectSoundEnabled(bool value) { }

	[CompilerGenerated]
	public virtual void set_EarlyReflectionsSendDB(float value) { }

	[CompilerGenerated]
	public virtual void set_EnableDirectSound(bool value) { }

	[CompilerGenerated]
	public virtual void set_EnableReverb(bool value) { }

	public virtual void set_EnableSpatialization(bool value) { }

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

