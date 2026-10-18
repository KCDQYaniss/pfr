namespace EFT.Expansions;

public sealed class ExpansionsBalanceChangePayload
{
	[JsonProperty("balance")]
	public int Balance; //Field offset: 0x10

	public ExpansionsBalanceChangePayload() { }

}

