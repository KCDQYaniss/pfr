namespace EFT;

public abstract class SumBonus : Bonus
{

	protected SumBonus(BonusDescriptor descriptor) { }

	public virtual double CalculateValue(double input) { }

}

