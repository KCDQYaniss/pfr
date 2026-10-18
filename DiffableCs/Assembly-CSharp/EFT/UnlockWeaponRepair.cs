namespace EFT;

public sealed class UnlockWeaponRepair : UnlockBonus
{

	public virtual EBonusType BonusType
	{
		 get { } //Length: 6
	}

	public UnlockWeaponRepair(BonusDescriptor descriptor) { }

	public virtual EBonusType get_BonusType() { }

	public virtual string GetValueFormat(bool isFutureBonus = false) { }

}

