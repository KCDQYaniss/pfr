namespace EFT.Hideout;

public sealed class SkillRequirement : Requirement
{
	[JsonProperty("skillName")]
	public string SkillName; //Field offset: 0x38
	[JsonProperty("skillLevel")]
	public int SkillLevel; //Field offset: 0x40
	[CompilerGenerated]
	private FakeSkill <FakeSkill>k__BackingField; //Field offset: 0x48
	private SkillManager _skillManager; //Field offset: 0x50
	private Skill _realSkill; //Field offset: 0x58

	[JsonIgnore]
	public private FakeSkill FakeSkill
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private ESkillId SkillId
	{
		private get { } //Length: 199
	}

	public virtual ERequirementType Type
	{
		 get { } //Length: 6
	}

	public SkillRequirement() { }

	[CompilerGenerated]
	public FakeSkill get_FakeSkill() { }

	private ESkillId get_SkillId() { }

	public virtual ERequirementType get_Type() { }

	[CompilerGenerated]
	private void set_FakeSkill(FakeSkill value) { }

	public void Test(SkillManager value) { }

}

