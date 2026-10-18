//Type is in global namespace

public class BotMoverState
{
	[CompilerGenerated]
	private readonly BotPathController <PathController>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly EBotMoverState <State>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly BotPathFinderCorePoints <PathFinder>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Nullable <LastTargetPoint>k__BackingField; //Field offset: 0x28

	public Nullable LastTargetPoint
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public BotPathController PathController
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public BotPathFinderCorePoints PathFinder
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public EBotMoverState State
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public BotMoverState(BotOwner owner, EBotMoverState state, BotMover botMover, AICoversData covers) { }

	[CompilerGenerated]
	public Nullable get_LastTargetPoint() { }

	[CompilerGenerated]
	public BotPathController get_PathController() { }

	[CompilerGenerated]
	public BotPathFinderCorePoints get_PathFinder() { }

	[CompilerGenerated]
	public EBotMoverState get_State() { }

	[CompilerGenerated]
	public void set_LastTargetPoint(Nullable value) { }

}

