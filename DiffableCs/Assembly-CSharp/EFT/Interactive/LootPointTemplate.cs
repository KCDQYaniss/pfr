namespace EFT.Interactive;

public class LootPointTemplate
{
	[JsonProperty("id")]
	public string Id; //Field offset: 0x10
	[JsonProperty("systemName")]
	public string Name; //Field offset: 0x18
	[JsonProperty("filterInclusive")]
	public string[] FilterInclusive; //Field offset: 0x20
	[JsonProperty("filterExclusive")]
	public string[] FilterExclusive; //Field offset: 0x28

	public LootPointTemplate() { }

}

