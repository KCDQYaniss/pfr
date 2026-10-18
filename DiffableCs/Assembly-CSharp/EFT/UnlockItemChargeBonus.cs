namespace EFT;

public sealed class UnlockItemChargeBonus : UnlockBonus
{

	public virtual EBonusType BonusType
	{
		 get { } //Length: 6
	}

	public UnlockItemChargeBonus(BonusDescriptor descriptor) { }

	public virtual EBonusType get_BonusType() { }

}

