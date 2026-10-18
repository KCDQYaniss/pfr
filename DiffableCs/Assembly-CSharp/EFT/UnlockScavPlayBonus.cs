namespace EFT;

public sealed class UnlockScavPlayBonus : UnlockBonus
{

	public virtual EBonusType BonusType
	{
		 get { } //Length: 6
	}

	public UnlockScavPlayBonus(BonusDescriptor descriptor) { }

	public virtual EBonusType get_BonusType() { }

}

