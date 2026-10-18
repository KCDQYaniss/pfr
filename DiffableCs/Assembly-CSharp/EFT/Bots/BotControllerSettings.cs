namespace EFT.Bots;

public struct BotControllerSettings
{
	[JsonProperty("isScavWars")]
	public bool IsScavWars; //Field offset: 0x0
	[JsonProperty("botAmount")]
	public EBotAmount BotAmount; //Field offset: 0x4
	[JsonIgnore]
	public EBossType BossType; //Field offset: 0x8
	[JsonIgnore]
	public string[] ExcludedBosses; //Field offset: 0x10

	[JsonIgnore]
	public bool IsEnabled
	{
		 get { } //Length: 8
	}

	public BotControllerSettings(bool isScavWars, EBotAmount botAmount = 0, EBossType bossType = 0, string[] excludedBosses = null) { }

	public bool get_IsEnabled() { }

}

