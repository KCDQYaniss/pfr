namespace EFT.Expansions;

public sealed class ExpansionsBalanceIncreasedPayload
{
	[JsonProperty("amount")]
	public int Amount; //Field offset: 0x10

	public ExpansionsBalanceIncreasedPayload() { }

}

