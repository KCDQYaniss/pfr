//Type is in global namespace

public class AIGestusRequest
{
	public IPlayer Requester; //Field offset: 0x10
	public Nullable GestureByRequester; //Field offset: 0x18
	public BotOwner Executer; //Field offset: 0x20
	public AIRequestStage Executing; //Field offset: 0x28
	private readonly float _expireTime; //Field offset: 0x2C
	private float _finishExecutedTime; //Field offset: 0x30
	[CompilerGenerated]
	private readonly AIPeaceRequestAnswer <Answer>k__BackingField; //Field offset: 0x38

	public AIPeaceRequestAnswer Answer
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool ShallDelete
	{
		 get { } //Length: 170
	}

	public AIGestusRequest(IPlayer requester, Nullable gesture, AIPeaceRequestAnswer answer) { }

	[CompilerGenerated]
	public AIPeaceRequestAnswer get_Answer() { }

	public bool get_ShallDelete() { }

	public void StartFirstExecuting() { }

	public void StartSecondExecuting() { }

}

