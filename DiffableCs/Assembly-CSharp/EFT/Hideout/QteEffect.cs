namespace EFT.Hideout;

public sealed class QteEffect
{
	internal enum EQteResultType
	{
		None = 0,
		Exit = 1,
	}

	internal enum EQteRewardType
	{
		Skill = 0,
		HealthEffect = 1,
		MusclePain = 2,
		GymArmTrauma = 3,
	}

	internal struct SkillExperienceMultiplierData
	{
		[JsonProperty("level")]
		public int level; //Field offset: 0x0
		[JsonProperty("multiplier")]
		public float value; //Field offset: 0x4

	}

	[CompilerGenerated]
	private EQteRewardType <Type>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private ESkillId <Skill>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private SkillExperienceMultiplierData[] <SkillExpMultiplierData>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private float <Duration>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private float <Weight>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private EQteResultType <Result>k__BackingField; //Field offset: 0x28

	[JsonProperty("Time")]
	public private float Duration
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	[JsonProperty("Result")]
	public private EQteResultType Result
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("SkillId")]
	public private ESkillId Skill
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("levelMultipliers")]
	public private SkillExperienceMultiplierData[] SkillExpMultiplierData
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonProperty("Type")]
	public private EQteRewardType Type
	{
		[CompilerGenerated]
		 get { } //Length: 164
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("Weight")]
	public private float Weight
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public QteEffect() { }

	[CompilerGenerated]
	public float get_Duration() { }

	[CompilerGenerated]
	public EQteResultType get_Result() { }

	[CompilerGenerated]
	public ESkillId get_Skill() { }

	[CompilerGenerated]
	public SkillExperienceMultiplierData[] get_SkillExpMultiplierData() { }

	[CompilerGenerated]
	public EQteRewardType get_Type() { }

	[CompilerGenerated]
	public float get_Weight() { }

	[CompilerGenerated]
	private void set_Duration(float value) { }

	[CompilerGenerated]
	private void set_Result(EQteResultType value) { }

	[CompilerGenerated]
	private void set_Skill(ESkillId value) { }

	[CompilerGenerated]
	private void set_SkillExpMultiplierData(SkillExperienceMultiplierData[] value) { }

	[CompilerGenerated]
	private void set_Type(EQteRewardType value) { }

	[CompilerGenerated]
	private void set_Weight(float value) { }

}

