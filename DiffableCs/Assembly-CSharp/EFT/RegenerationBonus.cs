namespace EFT;

public abstract class RegenerationBonus : PercentageBonus
{

	protected abstract string BaseValueFormat
	{
		 get { } //Length: 0
	}

	protected RegenerationBonus(BonusDescriptor descriptor) { }

	protected abstract string get_BaseValueFormat() { }

	public virtual string GetValueFormat(bool isFutureBonus = false) { }

}

