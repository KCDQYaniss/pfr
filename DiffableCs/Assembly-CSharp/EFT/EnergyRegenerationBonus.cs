namespace EFT;

public sealed class EnergyRegenerationBonus : RegenerationBonus
{

	protected virtual string BaseValueFormat
	{
		 get { } //Length: 49
	}

	public virtual EBonusType BonusType
	{
		 get { } //Length: 3
	}

	public EnergyRegenerationBonus(BonusDescriptor descriptor) { }

	protected virtual string get_BaseValueFormat() { }

	public virtual EBonusType get_BonusType() { }

}

