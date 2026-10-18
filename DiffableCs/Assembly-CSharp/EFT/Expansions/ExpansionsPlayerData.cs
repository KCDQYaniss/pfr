namespace EFT.Expansions;

public sealed class ExpansionsPlayerData
{
	[JsonProperty("tarcoins")]
	public int tarcoinsCount; //Field offset: 0x10
	[JsonProperty("labels")]
	public Dictionary labels; //Field offset: 0x18

	public int FreeOffersCount
	{
		 get { } //Length: 167
	}

	public int NewOffersCount
	{
		 get { } //Length: 167
	}

	public int SaleOffersCount
	{
		 get { } //Length: 167
	}

	public ExpansionsPlayerData() { }

	public int get_FreeOffersCount() { }

	public int get_NewOffersCount() { }

	public int get_SaleOffersCount() { }

}

