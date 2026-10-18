namespace Audio;

public class ClientAudioSettings
{
	internal sealed class ActiveHeadphonesSettings
	{
		public float FadeDuration; //Field offset: 0x10
		public EAudioFadeType FadeIn; //Field offset: 0x14
		public EAudioFadeType FadeOut; //Field offset: 0x18

		public ActiveHeadphonesSettings() { }

	}

	internal class AudioGroupAcousticBackendSettings
	{
		public AudioSourceGroupType groupType; //Field offset: 0x10
		public JToken acousticSettings; //Field offset: 0x18

		public AudioGroupAcousticBackendSettings() { }

	}

	internal sealed class ClientCustomHeadphonesTemplates
	{
		public CustomHeadphonesTemplateData DefaultHeadphonesTemplate; //Field offset: 0x10
		public CustomHeadphonesTemplateData HelmetLowMuteHeadphonesTemplate; //Field offset: 0x18
		public CustomHeadphonesTemplateData HelmetStrongMuteHeadphonesTemplate; //Field offset: 0x20
		public CustomHeadphonesTemplateData SpectatorHeadphonesTemplate; //Field offset: 0x28

		public ClientCustomHeadphonesTemplates() { }

	}

	internal sealed class CustomHeadphonesTemplateData
	{
		public float RolloffMultiplier; //Field offset: 0x10
		public float GunsCompressorSendLevel; //Field offset: 0x14
		public float ClientPlayerCompressorSendLevel; //Field offset: 0x18
		public float ObservedPlayerCompressorSendLevel; //Field offset: 0x1C
		public float NpcCompressorSendLevel; //Field offset: 0x20
		public float EnvTechnicalCompressorSendLevel; //Field offset: 0x24
		public float EnvNatureCompressorSendLevel; //Field offset: 0x28
		public float EnvCommonCompressorSendLevel; //Field offset: 0x2C
		public float AmbientCompressorSendLevel; //Field offset: 0x30
		public float EffectsReturnsCompressorSendLevel; //Field offset: 0x34
		public float HeadphonesMixerVolume; //Field offset: 0x38
		public float AmbientVolume; //Field offset: 0x3C
		public float PrecipitationVolume; //Field offset: 0x40
		public float DryVolume; //Field offset: 0x44
		public float EffectsReturnsGroupVolume; //Field offset: 0x48
		public float Distortion; //Field offset: 0x4C
		public float CompressorThreshold; //Field offset: 0x50
		public float CompressorAttack; //Field offset: 0x54
		public float CompressorRelease; //Field offset: 0x58
		public float CompressorGain; //Field offset: 0x5C
		public float GunsCompressorThreshold; //Field offset: 0x60
		public float GunsCompressorAttack; //Field offset: 0x64
		public float GunsCompressorRelease; //Field offset: 0x68
		public float GunsCompressorGain; //Field offset: 0x6C
		public int HighpassFreq; //Field offset: 0x70
		public float HighpassResonance; //Field offset: 0x74
		public int LowpassFreq; //Field offset: 0x78
		public float EQBand1Frequency; //Field offset: 0x7C
		public float EQBand1Gain; //Field offset: 0x80
		public float EQBand1Q; //Field offset: 0x84
		public float EQBand2Frequency; //Field offset: 0x88
		public float EQBand2Gain; //Field offset: 0x8C
		public float EQBand2Q; //Field offset: 0x90
		public float EQBand3Frequency; //Field offset: 0x94
		public float EQBand3Gain; //Field offset: 0x98
		public float EQBand3Q; //Field offset: 0x9C

		public CustomHeadphonesTemplateData() { }

	}

	internal sealed class EnvironmentAudioSettings
	{
		public List SurfaceMultipliers; //Field offset: 0x10
		public SeasonAmbientSettings SummerSettings; //Field offset: 0x18
		public SeasonAmbientSettings AutumnSettings; //Field offset: 0x20
		public SeasonAmbientSettings WinterSettings; //Field offset: 0x28
		public SeasonAmbientSettings SpringSettings; //Field offset: 0x30
		public SeasonAmbientSettings AutumnLateSettings; //Field offset: 0x38
		public SeasonAmbientSettings SpringEarlySettings; //Field offset: 0x40
		public SeasonAmbientSettings StormSettings; //Field offset: 0x48
		private Dictionary _seasonAmbientSettingsMap; //Field offset: 0x50
		private Dictionary _stepLayerVolumeMultBySurface; //Field offset: 0x58

		public EnvironmentAudioSettings() { }

		private void FillSeasonSettings() { }

		private void FillVolumeMultBySurface() { }

		public float GetMultBySurface(ESurfaceSound surfaceType) { }

		public SeasonAmbientSettings GetSeasonSettings(ESeasonStatus season) { }

	}

	internal sealed class GlobalAudioGroupPreset
	{
		public string Name; //Field offset: 0x10
		public int GroupType; //Field offset: 0x18
		public float OverallVolume; //Field offset: 0x1C
		public bool DisabledBinauralByDistance; //Field offset: 0x20
		public float DistanceToAllowBinaural; //Field offset: 0x24
		public float HeightToAllowBinaural; //Field offset: 0x28
		public float AngleToAllowBinaural; //Field offset: 0x2C

		public GlobalAudioGroupPreset() { }

	}

	internal class ItemInHandsSettings
	{
		public PointOfViewSoundValue ItemOperationsVolumeMult; //Field offset: 0x10
		public PointOfViewSoundValue WeaponOperationsVolumeMult; //Field offset: 0x18
		public PointOfViewSoundValue ItemOperationsSpatialBlend; //Field offset: 0x20
		public PointOfViewSoundValue WeaponOperationsSpatialBlend; //Field offset: 0x28

		public ItemInHandsSettings() { }

	}

	internal sealed class MetaXRAudioPluginSettings
	{
		public bool EnabledPluginErrorChecker; //Field offset: 0x10
		public float OutputVolumeCheckCooldown; //Field offset: 0x14
		public bool HardResetEnabled; //Field offset: 0x18
		public float ResetWaitTime; //Field offset: 0x1C
		public AudioGroupAcousticBackendSettings[] audioGroupAcousticSettings; //Field offset: 0x20
		private Dictionary _audioGroupAcousticSettingsMap; //Field offset: 0x28

		public MetaXRAudioPluginSettings() { }

		public bool TryGetSettingsForGroup(AudioSourceGroupType groupType, out string jsonSettings) { }

	}

	internal sealed class MixerExposedParameters
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__3_0; //Field offset: 0x8
			public static Func <>9__3_1; //Field offset: 0x10

			private static <>c() { }

			public <>c() { }

			internal string <GetValue>b__3_0(MixerExposedParameter x) { }

			internal float <GetValue>b__3_1(MixerExposedParameter x) { }

		}

		internal class MixerExposedParameter
		{
			public string ExposedParameter; //Field offset: 0x10
			public float Value; //Field offset: 0x18

			public MixerExposedParameter() { }

		}

		public List ExposedParameters; //Field offset: 0x10
		private Dictionary _cachedMultipliers; //Field offset: 0x18

		public MixerExposedParameters() { }

		public float GetValue(string exposedParameter) { }

	}

	internal sealed class MovementRolloffMultiplier
	{
		public EAudioMovementState MovementState; //Field offset: 0x10
		public float RolloffMultiplier; //Field offset: 0x14

		public MovementRolloffMultiplier() { }

	}

	internal sealed class PlayerAudioSettings
	{
		public float BaseMaxMovementRolloff; //Field offset: 0x10
		public List MovementRolloffMultipliers; //Field offset: 0x18
		public PointOfViewSoundValue MinStepSoundVolumeMultPoV; //Field offset: 0x20
		public PointOfViewSoundValue MinStepSoundVolumeSpeedMultPoV; //Field offset: 0x28
		public PointOfViewSoundValue MinStepSoundRolloffSpeedMultPoV; //Field offset: 0x30
		public float OutdoorRolloffMult; //Field offset: 0x38
		public float IndoorRolloffMult; //Field offset: 0x3C
		public PointOfViewSoundVolumeData SearchSoundVolume; //Field offset: 0x40
		public ItemInHandsSettings ItemInHandsSettings; //Field offset: 0x48
		public TinnitusEffectConfig TinnitusEffectConfig; //Field offset: 0x50
		private Dictionary _rolloffMultByMovement; //Field offset: 0x58

		public PlayerAudioSettings() { }

		private void FillRolloffMultByMovement() { }

		public float GetMultByMovement(EAudioMovementState movementState) { }

		public float GetRolloffMultByEnvironment(EnvironmentType environment) { }

	}

	internal sealed class PointOfViewSoundValue
	{
		public float FpValue; //Field offset: 0x10
		public float TpValue; //Field offset: 0x14

		public PointOfViewSoundValue() { }

		public float GetValue(EPointOfView pointOfView) { }

	}

	internal sealed class PointOfViewSoundVolumeData
	{
		public float FpVolume; //Field offset: 0x10
		public float TpVolume; //Field offset: 0x14

		public PointOfViewSoundVolumeData() { }

		public float GetVolume(EPointOfView pointOfView) { }

	}

	internal sealed class RainSettings
	{
		public ERainIntensity RainIntensity; //Field offset: 0x10
		public float IndoorVolumeMult; //Field offset: 0x14
		public float OutdoorVolumeMult; //Field offset: 0x18

		public RainSettings() { }

	}

	internal sealed class SeasonAmbientSettings
	{
		public float StepsVolumeMultiplier; //Field offset: 0x10
		public List WindMultipliers; //Field offset: 0x18
		public List RainSettings; //Field offset: 0x20
		private Dictionary _windMultipliersMap; //Field offset: 0x28
		private Dictionary _rainSettingsMap; //Field offset: 0x30

		public SeasonAmbientSettings() { }

		public float GetRainMult(EnvironmentType environment, ERainIntensity rainIntensity) { }

		public float GetWindMult(EWindSpeed windSpeed) { }

	}

	internal sealed class SurfaceMultiplier
	{
		public ESurfaceSound SurfaceType; //Field offset: 0x10
		public float VolumeMult; //Field offset: 0x14

		public SurfaceMultiplier() { }

	}

	internal class TinnitusEffectConfig
	{
		public float MaxEffectDuration; //Field offset: 0x10
		public float EffectBaseDurationMultiplier; //Field offset: 0x14

		public TinnitusEffectConfig() { }

	}

	internal sealed class WindMultiplier
	{
		public EWindSpeed WindSpeed; //Field offset: 0x10
		public float VolumeMult; //Field offset: 0x14

		public WindMultiplier() { }

	}

	[JsonProperty("MasterMixerSettings")]
	public MixerExposedParameters ExposedParameters; //Field offset: 0x10
	[JsonProperty("AudioGroupPresets")]
	public GlobalAudioGroupPreset[] Presets; //Field offset: 0x18
	[JsonProperty("EnvironmentSettings")]
	public EnvironmentAudioSettings EnvironmentSettings; //Field offset: 0x20
	[JsonProperty("PlayerSettings")]
	public PlayerAudioSettings PlayerSettings; //Field offset: 0x28
	[JsonProperty("MetaXRAudioPluginSettings")]
	public MetaXRAudioPluginSettings MetaXRPluginSettings; //Field offset: 0x30
	[JsonProperty("HeadphonesSettings")]
	public ActiveHeadphonesSettings HeadphonesSettings; //Field offset: 0x38
	[JsonProperty("OcclusionSettings")]
	public ClientAudioOcclusionSettings OcclusionSettings; //Field offset: 0x40
	[JsonProperty("WeaponSettings")]
	public ClientAudioWeaponSettings WeaponSettings; //Field offset: 0x48
	[JsonProperty("CustomHeadphonesTemplates")]
	public ClientCustomHeadphonesTemplates CustomHeadphonesTemplates; //Field offset: 0x50
	private Dictionary _presetsByType; //Field offset: 0x58

	public ClientAudioSettings() { }

	public bool TryGetPreset(int type, out GlobalAudioGroupPreset preset) { }

}

