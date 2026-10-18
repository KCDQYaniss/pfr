namespace EFT;

public sealed class UnlockItemCraftBonus : UnlockBonus
{

	public virtual EBonusType BonusType
	{
		 get { } //Length: 6
	}

	public UnlockItemCraftBonus(BonusDescriptor descriptor) { }

	public virtual EBonusType get_BonusType() { }

}

