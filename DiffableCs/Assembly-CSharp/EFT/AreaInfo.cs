namespace EFT;

public sealed class AreaInfo
{
	[JsonProperty("active")]
	public bool Active; //Field offset: 0x10
	[JsonProperty("type")]
	public int Type; //Field offset: 0x14
	[JsonProperty("level")]
	public int Level; //Field offset: 0x18
	[JsonProperty("completeTime")]
	public Nullable CompleteTime; //Field offset: 0x1C
	[JsonProperty("constructing")]
	public bool Constructing; //Field offset: 0x24
	[JsonProperty("passiveBonusesEnabled")]
	public bool PassiveBonusesEnabled; //Field offset: 0x25
	[JsonProperty("lastRecipe")]
	public string LastRecipe; //Field offset: 0x28
	[JsonProperty("slots")]
	public HideoutSlot[] Slots; //Field offset: 0x30

	[JsonIgnore]
	public EAreaType AreaType
	{
		 get { } //Length: 4
	}

	public AreaInfo() { }

	public EAreaType get_AreaType() { }

}

