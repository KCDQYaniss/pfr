namespace EFT;

public class Skill : BaseSkill
{
	public const int MAX_LEVEL = 50; //Field offset: 0x0
	public const int DEFAULT_EXP_LEVEL = 9; //Field offset: 0x0
	public const int ADDITIONAL_EXP_PER_LEVEL = 10; //Field offset: 0x0
	public readonly Buff[] Buffs; //Field offset: 0x48
	public readonly ESkillClass Class; //Field offset: 0x50
	private float _pointsEarned; //Field offset: 0x54
	private float _effectiveness; //Field offset: 0x58
	private float _fatigueTimer; //Field offset: 0x5C
	public readonly BindableEvent OnLevelUp; //Field offset: 0x60
	[CompilerGenerated]
	private readonly SkillManager <SkillManager>k__BackingField; //Field offset: 0x68
	public readonly bool Locked; //Field offset: 0x70

	public float BaseProgress
	{
		 get { } //Length: 327
	}

	public virtual int Buff
	{
		 get { } //Length: 4
		 set { } //Length: 63
	}

	public virtual float Effectiveness
	{
		 get { } //Length: 6
	}

	public bool IsEliteLevel
	{
		 get { } //Length: 59
	}

	private bool IsInRaid
	{
		private get { } //Length: 274
	}

	public int LevelExp
	{
		 get { } //Length: 76
	}

	public virtual float PointsEarned
	{
		 get { } //Length: 6
	}

	public float ProgressEarned
	{
		 get { } //Length: 142
	}

	public float ProgressValue
	{
		 get { } //Length: 194
	}

	public SkillManager SkillManager
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Skill(SkillManager skillManager, ESkillId id, ESkillClass skillClass, SkillAction[] actions, Buff[] buffs) { }

	public void AddPointsEarnedForWorkout(float pointsEarnedDelta) { }

	public float CalculateExpOnFirstLevels(float val) { }

	private int CalculateLevelExp(int level) { }

	private float CalculateRealEarnedExpForLobby() { }

	public float get_BaseProgress() { }

	public virtual int get_Buff() { }

	public virtual float get_Effectiveness() { }

	public bool get_IsEliteLevel() { }

	private bool get_IsInRaid() { }

	public int get_LevelExp() { }

	public virtual float get_PointsEarned() { }

	public float get_ProgressEarned() { }

	public float get_ProgressValue() { }

	[CompilerGenerated]
	public SkillManager get_SkillManager() { }

	protected virtual void LevelChanged() { }

	protected virtual void OnTrigger(SkillAction skillAction, float val) { }

	public virtual void RefreshPerkDependentState() { }

	public virtual void set_Buff(int value) { }

	public void SetLevel(int level) { }

	public virtual void SetPointsEarnedInSession(float fatigue, bool updateEffectiveness = true) { }

	public void UpdateFromInfo(SkillInfoDescriptor skillInfo) { }

	public void UpdateFromServer(ChangeSkillExperiencePacket skillPacket, bool silent = false) { }

	private void UpdateRules() { }

	public float UseEffectiveness(float input) { }

}

