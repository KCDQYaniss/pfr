namespace EFT.UI.SessionEnd;

public class ExperienceSectionReferralBonusInfo : ExperienceSection
{
	[CompilerGenerated]
	private readonly int <Bonus>k__BackingField; //Field offset: 0x28

	public int Bonus
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public ExperienceSectionReferralBonusInfo(string name, EStatGroupId groupId, int bonus) { }

	[CompilerGenerated]
	public int get_Bonus() { }

	public virtual string SumText() { }

	public virtual void ValidateExpIcon(PlayerExperienceIcon expIcon) { }

}

