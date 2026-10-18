namespace EFT.ActiveHeadphones;

public class ActiveHeadphonesDefaultConfigurator : BaseActiveHeadphonesMixerDependentComponent
{
	private const float AMBIENT_VOLUME_OFFSET = 20; //Field offset: 0x0
	private const string OUT_ENVIRONMENT_VOLUME = "OutEnvironmentVolume"; //Field offset: 0x0
	private const string GUNS_MIXER_VOLUME = "GunsVolume"; //Field offset: 0x0
	private const string EFFECTS_RETURNS_GROUP_VOLUME = "EffectsReturnsGroupVolume"; //Field offset: 0x0
	private const string AMBIENT_MIXER_OCCLUSION_SEND_LEVEL = "AmbientOccluded"; //Field offset: 0x0
	private const string AMBIENT_MIXER_VOLUME = "AmbientVolume"; //Field offset: 0x0
	private const string ENVIRONMENT_MIXER_VOLUME = "EnvironmentVolume"; //Field offset: 0x0
	private const string OCCLUSION_MIXER_VOLUME = "OcclusionVolume"; //Field offset: 0x0
	private const string MAIN_MIXER_TINNITUS_SEND_LEVEL = "Tinnitus2"; //Field offset: 0x0
	private const string GUNS_MIXER_TINNITUS_SEND_LEVEL = "Tinnitus1"; //Field offset: 0x0
	private const string PRECIPITATION_IN_MIXER_VOLUME = "PrecipitationInVolume"; //Field offset: 0x0
	private const string HEADPHONES_MIXER_VOLUME = "HeadphonesMixerVolume"; //Field offset: 0x0
	private const string AMBIENT_COMPRESSOR_SEND_LEVEL = "AmbientCompressorSendLevel"; //Field offset: 0x0
	private const string ENV_COMMON_COMPRESSOR_SEND_LEVEL = "EnvCommonCompressorSendLevel"; //Field offset: 0x0
	private const string ENV_NATURE_COMPRESSOR_SEND_LEVEL = "EnvNatureCompressorSendLevel"; //Field offset: 0x0
	private const string ENV_TECHNICAL_COMPRESSOR_SEND_LEVEL = "EnvTechnicalCompressorSendLevel"; //Field offset: 0x0
	private const string NPC_COMPRESSOR_SEND_LEVEL = "NpcCompressorSendLevel"; //Field offset: 0x0
	private const string OBSERVED_PLAYER_COMPRESSOR_SEND_LEVEL = "ObservedPlayerCompressorSendLevel"; //Field offset: 0x0
	private const string CLIENT_PLAYER_COMPRESSOR_SEND_LEVEL = "ClientPlayerCompressorSendLevel"; //Field offset: 0x0
	private const string GUNS_COMPRESSOR_SEND_LEVEL = "GunsCompressorSendLevel"; //Field offset: 0x0
	private const float GUNS_VOLUME_OFFSET = 15; //Field offset: 0x0
	private const string EFFECTS_RETURNS_COMPRESSOR_SEND_LEVEL = "EffectsReturnsCompressorSendLevel"; //Field offset: 0x0
	private const string PRECIPITATION_OUT_MIXER_VOLUME = "PrecipitationOutVolume"; //Field offset: 0x0

	public ActiveHeadphonesDefaultConfigurator(AudioMixer masterMixer, IAudioMixerFader mixerFader, ActiveHeadphonesSettings headphonesSettings) { }

	public virtual void Configure(HeadphonesApplyContext context, bool doFade = true) { }

	protected virtual void ConfigureTemplate(HeadphonesTemplate template, bool doFade = true) { }

	private float GetGunsSendLevelOffset(HeadphonesApplyContext context) { }

	private float GetOcclusionSendLevelOffset(HeadphonesApplyContext context) { }

}

