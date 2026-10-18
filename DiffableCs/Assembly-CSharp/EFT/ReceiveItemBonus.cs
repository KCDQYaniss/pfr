namespace EFT;

public sealed class ReceiveItemBonus : SumBonus
{

	public virtual EBonusType BonusType
	{
		 get { } //Length: 6
	}

	public ReceiveItemBonus(BonusDescriptor descriptor) { }

	public virtual EBonusType get_BonusType() { }

}

