namespace EFT;

public sealed class MaximumEnergyReserveBonus : SumBonus
{

	public virtual EBonusType BonusType
	{
		 get { } //Length: 6
	}

	public MaximumEnergyReserveBonus(BonusDescriptor descriptor) { }

	public virtual EBonusType get_BonusType() { }

	public virtual string GetValueFormat(bool isFutureBonus = false) { }

}

