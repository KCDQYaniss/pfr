namespace EFT;

public sealed class ExperienceRateBonus : PercentageBonus
{

	public virtual EBonusType BonusType
	{
		 get { } //Length: 6
	}

	public ExperienceRateBonus(BonusDescriptor descriptor) { }

	public virtual EBonusType get_BonusType() { }

}

