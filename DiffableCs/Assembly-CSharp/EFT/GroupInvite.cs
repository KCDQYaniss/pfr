namespace EFT;

public sealed class GroupInvite
{
	[JsonProperty("_id")]
	public string Id; //Field offset: 0x10
	[JsonProperty("requestId")]
	public string RequestId; //Field offset: 0x18
	[JsonProperty("from")]
	public string From; //Field offset: 0x20
	[JsonProperty("to")]
	public string To; //Field offset: 0x28
	[JsonProperty("profile")]
	public GroupPlayer FromProfile; //Field offset: 0x30
	[JsonProperty("members")]
	public GroupPlayer[] Members; //Field offset: 0x38

	public GroupInvite() { }

}

