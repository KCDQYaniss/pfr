namespace EFT;

public sealed class RepairWeaponBonus : PercentageBonus
{

	public virtual EBonusType BonusType
	{
		 get { } //Length: 6
	}

	public RepairWeaponBonus(BonusDescriptor descriptor) { }

	public virtual EBonusType get_BonusType() { }

}

