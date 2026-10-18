namespace EFT;

public sealed class UnlockAddOfferBonus : UnlockBonus
{

	public virtual EBonusType BonusType
	{
		 get { } //Length: 6
	}

	public UnlockAddOfferBonus(BonusDescriptor descriptor) { }

	public virtual EBonusType get_BonusType() { }

}

