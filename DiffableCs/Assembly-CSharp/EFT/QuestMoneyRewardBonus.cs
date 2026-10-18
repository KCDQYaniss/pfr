namespace EFT;

public sealed class QuestMoneyRewardBonus : PercentageBonus
{

	public virtual EBonusType BonusType
	{
		 get { } //Length: 6
	}

	public QuestMoneyRewardBonus(BonusDescriptor descriptor) { }

	public virtual EBonusType get_BonusType() { }

}

