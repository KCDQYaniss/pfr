namespace EFT.Hideout;

public sealed class ImprovementData
{
	[JsonProperty("completed")]
	public bool Completed; //Field offset: 0x10
	[JsonProperty("improveCompleteTimestamp")]
	public int CompleteTimestamp; //Field offset: 0x14

	public ImprovementData() { }

}

