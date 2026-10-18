namespace EFT;

public sealed class TeamGameEditionExpBonus : PercentageBonus
{

	public virtual EBonusType BonusType
	{
		 get { } //Length: 6
	}

	public TeamGameEditionExpBonus(BonusDescriptor descriptor) { }

	public virtual double CalculateValue(double input) { }

	public virtual EBonusType get_BonusType() { }

}

