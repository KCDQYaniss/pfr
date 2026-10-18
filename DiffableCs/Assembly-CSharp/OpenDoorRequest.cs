//Type is in global namespace

public class OpenDoorRequest : BotRequest
{
	private readonly Action _completeCallback; //Field offset: 0x70
	[CompilerGenerated]
	private Action OnComplete; //Field offset: 0x78
	[CompilerGenerated]
	private readonly Door <Door>k__BackingField; //Field offset: 0x80

	public event Action OnComplete
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public Door Door
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public virtual EBotRequestMode RequestMode
	{
		 get { } //Length: 6
	}

	public OpenDoorRequest(Door door, Player requester, Action completeCallback = null) { }

	[CompilerGenerated]
	public void add_OnComplete(Action value) { }

	public virtual bool CanProceed() { }

	public virtual bool CanRequest(BotOwner requester) { }

	public virtual void Complete() { }

	public virtual void Dispose() { }

	[CompilerGenerated]
	public Door get_Door() { }

	public virtual EBotRequestMode get_RequestMode() { }

	public virtual void PlayerDestroy(Player player) { }

	[CompilerGenerated]
	public void remove_OnComplete(Action value) { }

	public virtual void Take(BotOwner executor) { }

}

