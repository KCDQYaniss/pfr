namespace EFT;

public sealed class AdditionalSlotsBonus : SumBonus
{
	[JsonProperty("filter")]
	public List Filters; //Field offset: 0x40

	public virtual EBonusType BonusType
	{
		 get { } //Length: 6
	}

	public int NumberOfSlots
	{
		 get { } //Length: 6
	}

	public AdditionalSlotsBonus(BonusDescriptor descriptor) { }

	[CompilerGenerated]
	private bool <Add>b__7_0(MongoID filter) { }

	public void Add(AdditionalEliteSlots eliteSlots) { }

	public virtual void Add(Bonus bonus) { }

	public virtual EBonusType get_BonusType() { }

	public int get_NumberOfSlots() { }

	public virtual BonusDescriptor ToDescriptor() { }

}

