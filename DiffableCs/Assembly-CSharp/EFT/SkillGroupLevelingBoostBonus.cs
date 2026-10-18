namespace EFT;

public sealed class SkillGroupLevelingBoostBonus : PercentageBonus
{
	public readonly ESkillClass SkillType; //Field offset: 0x48

	public virtual EBonusType BonusType
	{
		 get { } //Length: 6
	}

	public virtual Enum TargetType
	{
		 get { } //Length: 72
	}

	public SkillGroupLevelingBoostBonus(BonusDescriptor descriptor) { }

	public virtual EBonusType get_BonusType() { }

	public virtual Enum get_TargetType() { }

	public virtual string GetValueFormat(bool isFutureBonus = false) { }

	public virtual BonusDescriptor ToDescriptor() { }

}

