namespace EFT;

[GenerateBinarySerialization]
public sealed class TraderInfoDescriptor
{
	[JsonProperty("unlocked")]
	public bool Unlocked; //Field offset: 0x10
	[JsonProperty("loyaltyLevel")]
	public int LoyaltyLevel; //Field offset: 0x14
	[JsonProperty("salesSum")]
	public long SalesSum; //Field offset: 0x18
	[JsonProperty("standing")]
	public double Standing; //Field offset: 0x20
	[JsonProperty("nextResupply")]
	public int NextResupply; //Field offset: 0x28
	[JsonProperty("disabled")]
	public bool Disabled; //Field offset: 0x2C
	[JsonProperty("dialogueAvailable")]
	public bool DialogAvailable; //Field offset: 0x2D

	public TraderInfoDescriptor() { }

	public TraderInfoDescriptor(TraderInfo traderInfo) { }

}

