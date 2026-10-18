namespace EFT;

public sealed class EndingElement
{
	[JsonProperty("id")]
	public MongoID id; //Field offset: 0x10
	[JsonProperty("systemName")]
	public string systemName; //Field offset: 0x28
	[JsonProperty("conditions")]
	public List conditions; //Field offset: 0x30
	[JsonProperty("rewards")]
	public PrestigeReward[] rewards; //Field offset: 0x38
	[JsonProperty("consequences")]
	public Consequence[] consequences; //Field offset: 0x40

	public EndingElement() { }

}

