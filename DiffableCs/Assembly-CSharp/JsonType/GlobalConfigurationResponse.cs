namespace JsonType;

public class GlobalConfigurationResponse
{
	[JsonProperty("config")]
	public GlobalConfiguration Config; //Field offset: 0x10
	public Dictionary ItemPresets; //Field offset: 0x18
	public Dictionary LocationInfection; //Field offset: 0x20
	[JsonProperty("bot_presets")]
	public BotPreset[] BotPresets; //Field offset: 0x28
	[JsonProperty("BotWeaponScatterings")]
	public BotWeaponScattering[] BotWeaponScatterings; //Field offset: 0x30

	public GlobalConfigurationResponse() { }

}

