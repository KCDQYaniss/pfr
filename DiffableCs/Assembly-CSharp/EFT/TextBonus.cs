namespace EFT;

public sealed class TextBonus : Bonus
{
	private Func _valueFormatGetter; //Field offset: 0x40

	public virtual EBonusType BonusType
	{
		 get { } //Length: 6
	}

	public virtual string LocalizationKey
	{
		 get { } //Length: 176
	}

	public EBonusType UniqueType
	{
		 get { } //Length: 249
	}

	public TextBonus(BonusDescriptor descriptor, Func valueFormatGetter = null) { }

	public virtual void Add(Bonus bonus) { }

	public virtual double CalculateValue(double input) { }

	public virtual Bonus Clone() { }

	public virtual EBonusType get_BonusType() { }

	public virtual string get_LocalizationKey() { }

	public EBonusType get_UniqueType() { }

	public virtual string GetValueFormat(bool isFutureBonus = false) { }

}

