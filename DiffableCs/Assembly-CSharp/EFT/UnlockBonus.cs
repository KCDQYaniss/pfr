namespace EFT;

public abstract class UnlockBonus : Bonus
{

	protected UnlockBonus(BonusDescriptor descriptor) { }

	public virtual double CalculateValue(double input) { }

	public virtual string GetValueFormat(bool isFutureBonus = false) { }

}

