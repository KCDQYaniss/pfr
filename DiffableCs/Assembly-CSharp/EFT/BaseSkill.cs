namespace EFT;

public abstract class BaseSkill
{
	protected const float EXP_PER_LEVEL = 100; //Field offset: 0x0
	public const int MAX_LEVEL_W_BUFF = 60; //Field offset: 0x0
	public ESkillId Id; //Field offset: 0x10
	public readonly BindableEvent SkillLevelChanged; //Field offset: 0x18
	public readonly BindableEvent SkillExperienceChanged; //Field offset: 0x20
	[CompilerGenerated]
	private float <Current>k__BackingField; //Field offset: 0x28
	public DateTime LastCall; //Field offset: 0x30
	protected int _buff; //Field offset: 0x38
	[CompilerGenerated]
	private readonly SkillAction[] <Actions>k__BackingField; //Field offset: 0x40

	public SkillAction[] Actions
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override int Buff
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public float Current
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public override float Effectiveness
	{
		 get { } //Length: 9
	}

	public int Level
	{
		 get { } //Length: 53
	}

	public override float LevelProgress
	{
		 get { } //Length: 88
	}

	public override float PointsEarned
	{
		 get { } //Length: 4
	}

	public int SummaryLevel
	{
		 get { } //Length: 141
	}

	protected BaseSkill(SkillAction[] actions) { }

	protected float ClampCurrent(float value) { }

	[CompilerGenerated]
	public SkillAction[] get_Actions() { }

	public override int get_Buff() { }

	[CompilerGenerated]
	public float get_Current() { }

	public override float get_Effectiveness() { }

	public int get_Level() { }

	public override float get_LevelProgress() { }

	public override float get_PointsEarned() { }

	public int get_SummaryLevel() { }

	protected override int GetLevelForValue(float value) { }

	protected float GetLevelProgress(float progress) { }

	protected override void LevelChanged() { }

	protected override void OnTrigger(SkillAction skillAction, float val) { }

	public override void RefreshPerkDependentState() { }

	public override void set_Buff(int value) { }

	[CompilerGenerated]
	public void set_Current(float value) { }

	public override void SetCurrent(float value, bool silent = false) { }

	public override void SetPointsEarnedInSession(float fatigue, bool updateEffectiveness = true) { }

	public override void Unsubscribe() { }

	public void UpdateFromAnother(BaseSkill baseSkill) { }

}

