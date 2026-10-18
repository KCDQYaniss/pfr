//Type is in global namespace

public class GoToPointRequest : BotRequest
{
	private readonly Action _completeCallback; //Field offset: 0x70
	private readonly Action _disposeCallback; //Field offset: 0x78
	[CompilerGenerated]
	private readonly Vector3 <Position>k__BackingField; //Field offset: 0x80

	public Vector3 Position
	{
		[CompilerGenerated]
		 get { } //Length: 25
	}

	public virtual EBotRequestMode RequestMode
	{
		 get { } //Length: 6
	}

	public GoToPointRequest(Player requester, Vector3 pos, Action completeCallback, Action disposeCallback) { }

	public virtual bool CanProceed() { }

	public virtual bool CanRequest(BotOwner requester) { }

	public virtual void Complete() { }

	public virtual void Dispose() { }

	[CompilerGenerated]
	public Vector3 get_Position() { }

	public virtual EBotRequestMode get_RequestMode() { }

}

