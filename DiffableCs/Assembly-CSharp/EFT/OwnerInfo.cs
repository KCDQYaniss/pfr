namespace EFT;

public sealed class OwnerInfo
{
	[JsonProperty("id")]
	public readonly string Id; //Field offset: 0x10
	[JsonProperty("type")]
	public readonly EOwnerType Type; //Field offset: 0x18

	public OwnerInfo(string id, EOwnerType type) { }

}

