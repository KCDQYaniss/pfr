namespace EFT;

public sealed class FinalsResponse
{
	[JsonProperty("elements")]
	public EndingElement[] elements; //Field offset: 0x10

	public FinalsResponse() { }

}

