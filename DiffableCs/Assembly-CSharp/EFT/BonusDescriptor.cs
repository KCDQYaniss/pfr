namespace EFT;

[GenerateBinarySerialization]
public sealed class BonusDescriptor
{
	[JsonProperty("type")]
	public EBonusType BonusType; //Field offset: 0x10
	[JsonProperty("id")]
	public MongoID Id; //Field offset: 0x18
	[JsonProperty("value")]
	public double Value; //Field offset: 0x30
	[JsonProperty("visible")]
	public bool IsVisible; //Field offset: 0x38
	[JsonProperty("passive")]
	public bool Passive; //Field offset: 0x39
	[JsonProperty("production")]
	public bool Production; //Field offset: 0x3A
	[JsonProperty("icon")]
	public string Icon; //Field offset: 0x40
	[JsonProperty("filter", NullValueHandling = NullValueHandling::Ignore (1))]
	[Nullable]
	public List Filters; //Field offset: 0x48
	[JsonProperty("skillType", NullValueHandling = NullValueHandling::Ignore (1))]
	public Nullable SkillType; //Field offset: 0x50
	[JsonProperty("skillName", NullValueHandling = NullValueHandling::Ignore (1))]
	public Nullable SkillName; //Field offset: 0x58
	[JsonProperty("templateId", NullValueHandling = NullValueHandling::Ignore (1))]
	public Nullable TemplateId; //Field offset: 0x60

	public BonusDescriptor() { }

	public Bonus ToBonus() { }

}

