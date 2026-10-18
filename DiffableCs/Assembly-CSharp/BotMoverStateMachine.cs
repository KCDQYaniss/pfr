//Type is in global namespace

public class BotMoverStateMachine
{
	private BotOwner _owner; //Field offset: 0x10
	[CompilerGenerated]
	private BotMoverState <CurrentMoverState>k__BackingField; //Field offset: 0x18
	private Dictionary _states; //Field offset: 0x20
	public Action OnStateChanged; //Field offset: 0x28

	public private BotMoverState CurrentMoverState
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public BotMoverState DefaultMoverState
	{
		 get { } //Length: 78
	}

	public BotMoverStateMachine(BotOwner owner, BotMover botMover, AICoversData covers) { }

	private void AddState(BotOwner owner, EBotMoverState state, BotMover botMover, AICoversData covers) { }

	[CompilerGenerated]
	public BotMoverState get_CurrentMoverState() { }

	public BotMoverState get_DefaultMoverState() { }

	[CompilerGenerated]
	private void set_CurrentMoverState(BotMoverState value) { }

	public void SetState(EBotMoverState state) { }

}

