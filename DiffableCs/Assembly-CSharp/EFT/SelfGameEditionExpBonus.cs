namespace EFT;

public sealed class SelfGameEditionExpBonus : PercentageBonus
{

	public virtual EBonusType BonusType
	{
		 get { } //Length: 6
	}

	public SelfGameEditionExpBonus(BonusDescriptor descriptor) { }

	public virtual double CalculateValue(double input) { }

	public virtual EBonusType get_BonusType() { }

}

