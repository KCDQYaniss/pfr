namespace EFT;

public sealed class SteamStatusSettings
{
	[JsonProperty("Enabled")]
	public bool Enabled; //Field offset: 0x10
	[JsonProperty("IdleStatusChangeDelaySeconds")]
	public float IdleStatusChangeDelaySeconds; //Field offset: 0x14

	public SteamStatusSettings() { }

}

