//Type is in global namespace

public class BotShootFromPlace : BotData
{
	private float _nextPosibleCheck; //Field offset: 0x18
	[CompilerGenerated]
	private bool <CanShootSit>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private bool <CanShootLay>k__BackingField; //Field offset: 0x1D

	public private bool CanShootLay
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool CanShootSit
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public BotShootFromPlace(BotOwner owner) { }

	public void CheckTarget(Vector3 target) { }

	[CompilerGenerated]
	public bool get_CanShootLay() { }

	[CompilerGenerated]
	public bool get_CanShootSit() { }

	[CompilerGenerated]
	private void set_CanShootLay(bool value) { }

	[CompilerGenerated]
	private void set_CanShootSit(bool value) { }

}

