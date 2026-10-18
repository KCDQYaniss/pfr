namespace EFT;

public class ExchangeRateDTO
{
	[JsonProperty("exchange_rate")]
	public double ExchangeRate; //Field offset: 0x10

	public ExchangeRateDTO() { }

}

