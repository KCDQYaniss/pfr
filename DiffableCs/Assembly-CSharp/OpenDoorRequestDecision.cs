//Type is in global namespace

public class OpenDoorRequestDecision : BaseNode
{
	private readonly GoToDoorOpen _go; //Field offset: 0x18

	private OpenDoorRequest Request
	{
		private get { } //Length: 145
	}

	public OpenDoorRequestDecision(BotOwner bot) { }

	private OpenDoorRequest get_Request() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

