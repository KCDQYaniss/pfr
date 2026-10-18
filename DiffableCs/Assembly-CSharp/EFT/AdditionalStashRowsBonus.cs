namespace EFT;

public sealed class AdditionalStashRowsBonus : SumBonus, IAttachedBonus
{

	public override EAreaType AreaType
	{
		 get { } //Length: 6
	}

	public virtual EBonusType BonusType
	{
		 get { } //Length: 6
	}

	public AdditionalStashRowsBonus(BonusDescriptor descriptor) { }

	public override EAreaType get_AreaType() { }

	public virtual EBonusType get_BonusType() { }

}

