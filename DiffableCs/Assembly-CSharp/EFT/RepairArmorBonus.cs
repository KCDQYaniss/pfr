namespace EFT;

public sealed class RepairArmorBonus : PercentageBonus
{

	public virtual EBonusType BonusType
	{
		 get { } //Length: 6
	}

	public RepairArmorBonus(BonusDescriptor descriptor) { }

	public virtual EBonusType get_BonusType() { }

}

