namespace Dissonance.Config;

public sealed class VoiceSettings : ScriptableObject, INotifyPropertyChanged
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__20_0; //Field offset: 0x8
		public static Action <>9__24_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <set_FrameSize>b__24_0(string key, FrameSize f) { }

		internal void <set_Quality>b__20_0(string key, AudioQuality q) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Action <0>__SetInt; //Field offset: 0x0
		public static Action <1>__SetFloat; //Field offset: 0x8

	}

	private static readonly Log Log; //Field offset: 0x0
	private const string PersistName_Quality = "Dissonance_Audio_Quality"; //Field offset: 0x0
	private const string PersistName_FrameSize = "Dissonance_Audio_FrameSize"; //Field offset: 0x0
	private const string PersistName_Fec = "Dissonance_Audio_DisableFEC"; //Field offset: 0x0
	private const string PersistName_DenoiseAmount = "Dissonance_Audio_Denoise_Amount"; //Field offset: 0x0
	private const string PersistName_PttDuckAmount = "Dissonance_Audio_Duck_Amount"; //Field offset: 0x0
	private const string PersistName_VadSensitivity = "Dissonance_Audio_Vad_Sensitivity"; //Field offset: 0x0
	private const string PersistName_BgDenoiseEnabled = "Dissonance_Audio_BgDenoise_Enabled"; //Field offset: 0x0
	private const string PersistName_BgDenoiseWetmix = "Dissonance_Audio_BgDenoise_Amount"; //Field offset: 0x0
	private const string PersistName_AecSuppressionAmount = "Dissonance_Audio_Aec_Suppression_Amount"; //Field offset: 0x0
	private const string PersistName_AecDelayAgnostic = "Dissonance_Audio_Aec_Delay_Agnostic"; //Field offset: 0x0
	private const string PersistName_AecExtendedFilter = "Dissonance_Audio_Aec_Extended_Filter"; //Field offset: 0x0
	private const string PersistName_AecRefinedAdaptiveFilter = "Dissonance_Audio_Aec_Refined_Adaptive_Filter"; //Field offset: 0x0
	private const string PersistName_AecmRoutingMode = "Dissonance_Audio_Aecm_Routing_Mode"; //Field offset: 0x0
	private const string PersistName_AecmComfortNoise = "Dissonance_Audio_Aecm_Comfort_Noise"; //Field offset: 0x0
	private const string SettingsFileResourceName = "VoiceSettings"; //Field offset: 0x0
	public static readonly string SettingsFilePath; //Field offset: 0x8
	private static VoiceSettings _instance; //Field offset: 0x10
	[SerializeField]
	private AudioQuality _quality; //Field offset: 0x18
	[SerializeField]
	private FrameSize _frameSize; //Field offset: 0x1C
	[SerializeField]
	private int _forwardErrorCorrection; //Field offset: 0x20
	[SerializeField]
	private int _denoiseAmount; //Field offset: 0x24
	[SerializeField]
	private int _bgSoundRemovalEnabled; //Field offset: 0x28
	[SerializeField]
	private float _bgSoundRemovalAmount; //Field offset: 0x2C
	[SerializeField]
	private int _vadSensitivity; //Field offset: 0x30
	[SerializeField]
	private int _aecAmount; //Field offset: 0x34
	[SerializeField]
	private int _aecDelayAgnostic; //Field offset: 0x38
	[SerializeField]
	private int _aecExtendedFilter; //Field offset: 0x3C
	[SerializeField]
	private int _aecRefinedAdaptiveFilter; //Field offset: 0x40
	[SerializeField]
	private int _aecmRoutingMode; //Field offset: 0x44
	[SerializeField]
	private int _aecmComfortNoise; //Field offset: 0x48
	[SerializeField]
	private float _voiceDuckLevel; //Field offset: 0x4C
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x50

	public override event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public bool AecDelayAgnostic
	{
		 get { } //Length: 77
		 set { } //Length: 419
	}

	public bool AecExtendedFilter
	{
		 get { } //Length: 77
		 set { } //Length: 419
	}

	public bool AecmComfortNoise
	{
		 get { } //Length: 77
		 set { } //Length: 419
	}

	public AecmRoutingMode AecmRoutingMode
	{
		 get { } //Length: 4
		 set { } //Length: 387
	}

	public bool AecRefinedAdaptiveFilter
	{
		 get { } //Length: 77
		 set { } //Length: 419
	}

	public AecSuppressionLevels AecSuppressionAmount
	{
		 get { } //Length: 4
		 set { } //Length: 387
	}

	public float BackgroundSoundRemovalAmount
	{
		 get { } //Length: 6
		 set { } //Length: 409
	}

	public bool BackgroundSoundRemovalEnabled
	{
		 get { } //Length: 77
		 set { } //Length: 419
	}

	public NoiseSuppressionLevels DenoiseAmount
	{
		 get { } //Length: 4
		 set { } //Length: 387
	}

	public bool ForwardErrorCorrection
	{
		 get { } //Length: 77
		 set { } //Length: 419
	}

	public FrameSize FrameSize
	{
		 get { } //Length: 4
		 set { } //Length: 575
	}

	[NotNull]
	public static VoiceSettings Instance
	{
		 get { } //Length: 462
	}

	public AudioQuality Quality
	{
		 get { } //Length: 4
		 set { } //Length: 575
	}

	public VadSensitivityLevels VadSensitivity
	{
		 get { } //Length: 4
		 set { } //Length: 387
	}

	public float VoiceDuckLevel
	{
		 get { } //Length: 6
		 set { } //Length: 389
	}

	private static VoiceSettings() { }

	public VoiceSettings() { }

	[CompilerGenerated]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	public bool get_AecDelayAgnostic() { }

	public bool get_AecExtendedFilter() { }

	public bool get_AecmComfortNoise() { }

	public AecmRoutingMode get_AecmRoutingMode() { }

	public bool get_AecRefinedAdaptiveFilter() { }

	public AecSuppressionLevels get_AecSuppressionAmount() { }

	public float get_BackgroundSoundRemovalAmount() { }

	public bool get_BackgroundSoundRemovalEnabled() { }

	public NoiseSuppressionLevels get_DenoiseAmount() { }

	public bool get_ForwardErrorCorrection() { }

	public FrameSize get_FrameSize() { }

	public static VoiceSettings get_Instance() { }

	public AudioQuality get_Quality() { }

	public VadSensitivityLevels get_VadSensitivity() { }

	public float get_VoiceDuckLevel() { }

	[NotNull]
	private static VoiceSettings Load() { }

	private void LoadDefaults() { }

	[NotifyPropertyChangedInvocator]
	private void OnPropertyChanged(string propertyName) { }

	public static void Preload() { }

	[CompilerGenerated]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	public void Reset() { }

	public void set_AecDelayAgnostic(bool value) { }

	public void set_AecExtendedFilter(bool value) { }

	public void set_AecmComfortNoise(bool value) { }

	public void set_AecmRoutingMode(AecmRoutingMode value) { }

	public void set_AecRefinedAdaptiveFilter(bool value) { }

	public void set_AecSuppressionAmount(AecSuppressionLevels value) { }

	public void set_BackgroundSoundRemovalAmount(float value) { }

	public void set_BackgroundSoundRemovalEnabled(bool value) { }

	public void set_DenoiseAmount(NoiseSuppressionLevels value) { }

	public void set_ForwardErrorCorrection(bool value) { }

	public void set_FrameSize(FrameSize value) { }

	public void set_Quality(AudioQuality value) { }

	public void set_VadSensitivity(VadSensitivityLevels value) { }

	public void set_VoiceDuckLevel(float value) { }

	public virtual string ToString() { }

}

