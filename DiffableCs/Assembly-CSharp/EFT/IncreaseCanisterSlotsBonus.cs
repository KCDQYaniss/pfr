namespace EFT;

public sealed class IncreaseCanisterSlotsBonus : SumBonus
{

	public virtual EBonusType BonusType
	{
		 get { } //Length: 6
	}

	public IncreaseCanisterSlotsBonus(BonusDescriptor descriptor) { }

	public virtual EBonusType get_BonusType() { }

}

