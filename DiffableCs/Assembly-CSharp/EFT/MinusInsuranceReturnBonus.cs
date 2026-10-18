namespace EFT;

public sealed class MinusInsuranceReturnBonus : PercentageBonus
{

	public virtual EBonusType BonusType
	{
		 get { } //Length: 6
	}

	public virtual bool IsPositive
	{
		 get { } //Length: 16
	}

	public MinusInsuranceReturnBonus(BonusDescriptor descriptor) { }

	public virtual EBonusType get_BonusType() { }

	public virtual bool get_IsPositive() { }

}

