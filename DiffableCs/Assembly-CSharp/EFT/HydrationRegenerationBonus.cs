namespace EFT;

public sealed class HydrationRegenerationBonus : RegenerationBonus
{

	protected virtual string BaseValueFormat
	{
		 get { } //Length: 49
	}

	public virtual EBonusType BonusType
	{
		 get { } //Length: 6
	}

	public HydrationRegenerationBonus(BonusDescriptor descriptor) { }

	protected virtual string get_BaseValueFormat() { }

	public virtual EBonusType get_BonusType() { }

}

