namespace EFT;

public sealed class UnlockItemPassiveCreationBonus : UnlockBonus
{

	public virtual EBonusType BonusType
	{
		 get { } //Length: 6
	}

	public UnlockItemPassiveCreationBonus(BonusDescriptor descriptor) { }

	public virtual EBonusType get_BonusType() { }

}

