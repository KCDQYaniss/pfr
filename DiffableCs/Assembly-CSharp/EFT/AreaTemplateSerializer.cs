namespace EFT;

public sealed class AreaTemplateSerializer : ISerializer
{
	[JsonProperty("_id")]
	public string Id; //Field offset: 0x10
	[JsonProperty("type")]
	public int Type; //Field offset: 0x18
	[JsonProperty("needsFuel")]
	public bool NeedsFuel; //Field offset: 0x1C
	[JsonProperty("craftGivesExp")]
	public bool CraftGivesExp; //Field offset: 0x1D
	[JsonProperty("takeFromSlotLocked")]
	public bool TakeFromSlotLocked; //Field offset: 0x1E
	[JsonProperty("requirements")]
	public Requirement[] Requirements; //Field offset: 0x20
	[JsonProperty("stages")]
	public Dictionary Stages; //Field offset: 0x28
	[JsonProperty("enabled")]
	public bool Enabled; //Field offset: 0x30
	[JsonProperty("displayLevel")]
	public bool DisplayLevel; //Field offset: 0x31
	[JsonProperty("parentArea")]
	public string ParentAreaId; //Field offset: 0x38

	public AreaTemplateSerializer() { }

	public override AreaTemplate Deserialize() { }

	public override object Serialize(AreaTemplate template) { }

}

