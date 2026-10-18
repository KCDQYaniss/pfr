//Type is in global namespace

public class BotAssaultDangerArea : BotData
{
	private const float DIST_TO_COME_CLOSE = 20; //Field offset: 0x0
	private CustomNavigationPoint _pointToBeClose; //Field offset: 0x18
	private float _lastEndHoldPos; //Field offset: 0x20
	private float _lastCHeckHoldPoint; //Field offset: 0x24
	[CompilerGenerated]
	private MiniAssaultBotsGroup <AssaultGroup>k__BackingField; //Field offset: 0x28

	public private MiniAssaultBotsGroup AssaultGroup
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public bool HaveTarget
	{
		 get { } //Length: 9
	}

	public EBotAssaultAreaStatus ShallAssault
	{
		 get { } //Length: 26
	}

	public BotAssaultDangerArea(BotOwner owner) { }

	public void Activate() { }

	public void AreaCompleted() { }

	public void FindCover() { }

	[CompilerGenerated]
	public MiniAssaultBotsGroup get_AssaultGroup() { }

	public bool get_HaveTarget() { }

	public EBotAssaultAreaStatus get_ShallAssault() { }

	public CustomNavigationPoint GetCloseCover() { }

	[CompilerGenerated]
	private void set_AssaultGroup(MiniAssaultBotsGroup value) { }

	public void SetActivaArea(MiniAssaultBotsGroup botZoneDangerArea) { }

	public bool ShallEndHoldPosition() { }

}

