//Type is in global namespace

public class WarnPlayerDecision : BaseNode
{
	private readonly WarnPlayerRequestGoNode _go; //Field offset: 0x18
	private readonly AimingNearPlayer _shoot; //Field offset: 0x20
	private readonly WarnPlayerAttentionNode _say; //Field offset: 0x28

	private WarnPlayerRequest Request
	{
		private get { } //Length: 39
	}

	public WarnPlayerDecision(BotOwner bot) { }

	private WarnPlayerRequest get_Request() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

