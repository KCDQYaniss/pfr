namespace EFT;

public abstract class SpecialBonus : Bonus
{

	protected SpecialBonus(BonusDescriptor descriptor) { }

	public virtual double CalculateValue(double input) { }

}

