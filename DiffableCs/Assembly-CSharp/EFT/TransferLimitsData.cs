namespace EFT;

public sealed class TransferLimitsData
{
	[JsonProperty("nextResetTime")]
	public int nextResetTime; //Field offset: 0x10
	[JsonProperty("remainingLimit")]
	public int remainingLimit; //Field offset: 0x14
	[JsonProperty("totalLimit")]
	public int totalLimit; //Field offset: 0x18
	[JsonProperty("resetInterval")]
	public int resetInterval; //Field offset: 0x1C

	public TransferLimitsData() { }

}

