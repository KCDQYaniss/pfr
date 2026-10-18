namespace EFT;

public sealed class PerkExperienceRateBonus : PercentageBonus
{

	public virtual EBonusType BonusType
	{
		 get { } //Length: 6
	}

	public PerkExperienceRateBonus(BonusDescriptor descriptor) { }

	public virtual EBonusType get_BonusType() { }

}

