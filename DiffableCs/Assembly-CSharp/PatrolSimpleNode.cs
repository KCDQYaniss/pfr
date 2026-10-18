//Type is in global namespace

public class PatrolSimpleNode : MoveNode
{
	private bool CanLookAround; //Field offset: 0x28
	private LookAround _lookAround; //Field offset: 0x30

	public PatrolSimpleNode(BotOwner bot) { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

