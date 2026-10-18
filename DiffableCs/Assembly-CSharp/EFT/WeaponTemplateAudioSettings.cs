namespace EFT;

public class WeaponTemplateAudioSettings
{
	public WeaponEmitterConfig IndoorConfig; //Field offset: 0x10
	public WeaponEmitterConfig OutdoorConfig; //Field offset: 0x18
	public WeaponEmitterConfig IndoorSilencedConfig; //Field offset: 0x20
	public WeaponEmitterConfig OutdoorSilencedConfig; //Field offset: 0x28

	public WeaponTemplateAudioSettings() { }

	public WeaponTemplateAudioSettings Copy() { }

	public WeaponEmitterConfig GetConfig(EnvironmentType environmentType, bool isSilenced) { }

}

