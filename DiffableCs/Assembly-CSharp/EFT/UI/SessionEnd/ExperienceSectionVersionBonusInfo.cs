namespace EFT.UI.SessionEnd;

public class ExperienceSectionVersionBonusInfo : ExperienceSection
{
	[CompilerGenerated]
	private readonly bool <HasBonus>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly string <GameVersion>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly int <Bonus>k__BackingField; //Field offset: 0x38

	public int Bonus
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public string GameVersion
	{
		[CompilerGenerated]
		 get { } //Length: 76
	}

	public bool HasBonus
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ExperienceSectionVersionBonusInfo(string name, EStatGroupId groupId, bool hasBonus, string gameVersion, int bonus) { }

	[CompilerGenerated]
	public int get_Bonus() { }

	[CompilerGenerated]
	public string get_GameVersion() { }

	[CompilerGenerated]
	public bool get_HasBonus() { }

	public virtual string SumText() { }

	public virtual void ValidateExpIcon(PlayerExperienceIcon expIcon) { }

}

