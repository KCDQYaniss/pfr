namespace EFT;

public sealed class StashSizeBonus : SpecialBonus
{
	[JsonProperty("templateId")]
	public MongoID TemplateId; //Field offset: 0x40
	[JsonIgnore]
	private Stash _item; //Field offset: 0x58

	public virtual EBonusType BonusType
	{
		 get { } //Length: 6
	}

	[JsonIgnore]
	private Stash Item
	{
		private get { } //Length: 615
	}

	public StashSizeBonus(BonusDescriptor descriptor) { }

	public virtual void Add(Bonus bonus) { }

	public virtual EBonusType get_BonusType() { }

	private Stash get_Item() { }

	public virtual string GetValueFormat(bool isFutureBonus = false) { }

	public virtual BonusDescriptor ToDescriptor() { }

}

