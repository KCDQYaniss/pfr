namespace JsonType;

public sealed class Summon
{
	[JsonProperty("usecs")]
	public int Usecs; //Field offset: 0x10
	[JsonProperty("bears")]
	public int Bears; //Field offset: 0x14
	[JsonProperty("savages")]
	public int Savages; //Field offset: 0x18
	[JsonProperty("randoms")]
	public int Randoms; //Field offset: 0x1C

	public Summon() { }

}

