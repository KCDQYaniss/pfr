namespace EFT;

public sealed class UnlockModificationBonus : UnlockBonus
{

	public virtual EBonusType BonusType
	{
		 get { } //Length: 6
	}

	public UnlockModificationBonus(BonusDescriptor descriptor) { }

	public virtual EBonusType get_BonusType() { }

}

