namespace EFT;

public sealed class RepairItem
{
	[JsonProperty("_id")]
	public string Id; //Field offset: 0x10
	[JsonProperty("count")]
	public float Count; //Field offset: 0x18

	public RepairItem(string id, float repairAmount) { }

}

