namespace EFT;

public sealed class ExtensionsSettings
{
	[JsonProperty("Enabled")]
	public readonly bool Enabled; //Field offset: 0x10
	[JsonProperty("Maintenance")]
	public readonly bool Maintenance; //Field offset: 0x11
	[JsonProperty("ApparelUrl")]
	public readonly string ApparelUrl; //Field offset: 0x18
	[JsonProperty("PveUrl")]
	public readonly string PveUrl; //Field offset: 0x20
	[JsonProperty("BattlePassUrl")]
	public readonly string BattlePassUrl; //Field offset: 0x28
	[JsonProperty("StashRowsUrl")]
	public readonly string StashRowsUrl; //Field offset: 0x30
	[JsonProperty("MaxStashRows")]
	public readonly int MaxStashRows; //Field offset: 0x38
	[JsonProperty("steamGameStoreUrl")]
	public readonly string SteamGameStoreUrl; //Field offset: 0x40

	public bool IsShopAvailable
	{
		 get { } //Length: 17
	}

	public bool IsShopEnabled
	{
		 get { } //Length: 5
	}

	public ExtensionsSettings() { }

	public bool get_IsShopAvailable() { }

	public bool get_IsShopEnabled() { }

}

