namespace EFT;

public sealed class UnlockUniqueIdBonus : UnlockBonus
{

	public virtual EBonusType BonusType
	{
		 get { } //Length: 6
	}

	public UnlockUniqueIdBonus(BonusDescriptor descriptor) { }

	public virtual EBonusType get_BonusType() { }

}

