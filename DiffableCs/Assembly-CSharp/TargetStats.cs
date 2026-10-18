//Type is in global namespace

public class TargetStats
{
	public Dictionary BotDistanceStat; //Field offset: 0x10
	private int lastFireIndex; //Field offset: 0x18
	[CompilerGenerated]
	private int <TotalShots>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private int <TotalHit>k__BackingField; //Field offset: 0x20

	public private int TotalHit
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int TotalShots
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public TargetStats() { }

	public int AddDistHit(float d, string bone, float damage, int fireIndex, EBodyPart bodyType, float armorDamage) { }

	public void AddDistShot(float d) { }

	[CompilerGenerated]
	public int get_TotalHit() { }

	[CompilerGenerated]
	public int get_TotalShots() { }

	[CompilerGenerated]
	private void set_TotalHit(int value) { }

	[CompilerGenerated]
	private void set_TotalShots(int value) { }

}

