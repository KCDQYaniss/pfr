namespace EFT;

public sealed class CraftTimeBonus : PercentageBonus
{

	public virtual EBonusType BonusType
	{
		 get { } //Length: 6
	}

	public virtual bool IsPositive
	{
		 get { } //Length: 16
	}

	public CraftTimeBonus(BonusDescriptor descriptor) { }

	public virtual EBonusType get_BonusType() { }

	public virtual bool get_IsPositive() { }

}

