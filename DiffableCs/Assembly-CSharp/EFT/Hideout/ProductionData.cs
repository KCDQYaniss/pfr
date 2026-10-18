namespace EFT.Hideout;

public sealed class ProductionData
{
	[JsonProperty("Progress")]
	public float Progress; //Field offset: 0x10
	[JsonProperty("StartTimestamp", NullValueHandling = NullValueHandling::Ignore (1))]
	public int StartTimestamp; //Field offset: 0x14
	[JsonProperty("ProductionTime")]
	public int ProductionTime; //Field offset: 0x18
	[JsonProperty("inProgress")]
	public bool InProgress; //Field offset: 0x1C
	[JsonProperty("RecipeId")]
	public string RecipeId; //Field offset: 0x20
	[JsonProperty("Products")]
	public FlatItem[] Products; //Field offset: 0x28
	[JsonProperty("Interrupted")]
	public bool Interrupted; //Field offset: 0x30
	[JsonProperty("Code")]
	public string Code; //Field offset: 0x38
	[JsonProperty("Decoded")]
	public bool Decoded; //Field offset: 0x40
	[JsonProperty("AvailableForFinish")]
	public bool AvailableForFinish; //Field offset: 0x41

	public ProductionData() { }

}

