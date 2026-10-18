//Type is in global namespace

public class GestureNode : BaseNode
{
	public readonly float VISIBLE_SECTOR; //Field offset: 0x18

	public GestureNode(BotOwner bot) { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

