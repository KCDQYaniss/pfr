namespace EFT;

public abstract class PercentageBonus : Bonus
{
	private double _boostValue; //Field offset: 0x40

	public double BoostValue
	{
		 get { } //Length: 6
		 set { } //Length: 75
	}

	public virtual double ResultValue
	{
		 get { } //Length: 24
	}

	protected PercentageBonus(BonusDescriptor descriptor) { }

	public virtual void Add(Bonus bonus) { }

	public virtual double CalculateValue(double input) { }

	public virtual Bonus Clone() { }

	public double get_BoostValue() { }

	public virtual double get_ResultValue() { }

	public virtual string GetValueFormat(bool isFutureBonus = false) { }

	public void set_BoostValue(double value) { }

}

