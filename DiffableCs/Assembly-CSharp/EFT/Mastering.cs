namespace EFT;

public class Mastering : BaseSkill
{
	public readonly MasteringGroup MasteringGroup; //Field offset: 0x48
	[CompilerGenerated]
	private int <KillCount>k__BackingField; //Field offset: 0x50

	public int KillCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int LevelingThreshold
	{
		 get { } //Length: 85
	}

	public virtual float LevelProgress
	{
		 get { } //Length: 120
	}

	private int Lvl1
	{
		private get { } //Length: 26
	}

	private int Lvl2
	{
		private get { } //Length: 26
	}

	public Mastering(MasteringGroup masteringGroup, SkillAction[] actions) { }

	[CompilerGenerated]
	public int get_KillCount() { }

	public int get_LevelingThreshold() { }

	public virtual float get_LevelProgress() { }

	private int get_Lvl1() { }

	private int get_Lvl2() { }

	protected virtual int GetLevelForValue(float value) { }

	[CompilerGenerated]
	public void set_KillCount(int value) { }

	public void UpdateFromAnother(Mastering other) { }

}

