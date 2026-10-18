namespace EFT;

public sealed class TraderData
{
	[JsonProperty("salesSum")]
	private Nullable _salesSum; //Field offset: 0x10
	[JsonProperty("standing")]
	private Nullable _standing; //Field offset: 0x20
	[JsonProperty("loyalty")]
	private Nullable _loyaltyLevel; //Field offset: 0x30
	[JsonProperty("unlocked")]
	private Nullable _unlocked; //Field offset: 0x38
	[JsonProperty("disabled")]
	private Nullable _disabled; //Field offset: 0x3A
	[JsonProperty("dialogueAvailable")]
	private Nullable _dialogueAvailable; //Field offset: 0x3C

	public TraderData() { }

	public void Apply(TraderInfo traderInfo) { }

}

