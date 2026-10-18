namespace EFT;

public sealed class UnlockRandomItemCreationBonus : UnlockBonus
{

	public virtual EBonusType BonusType
	{
		 get { } //Length: 6
	}

	public UnlockRandomItemCreationBonus(BonusDescriptor descriptor) { }

	public virtual EBonusType get_BonusType() { }

}

