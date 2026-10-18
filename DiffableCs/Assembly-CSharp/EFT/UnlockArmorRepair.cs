namespace EFT;

public sealed class UnlockArmorRepair : UnlockBonus
{

	public virtual EBonusType BonusType
	{
		 get { } //Length: 6
	}

	public UnlockArmorRepair(BonusDescriptor descriptor) { }

	public virtual EBonusType get_BonusType() { }

	public virtual string GetValueFormat(bool isFutureBonus = false) { }

}

