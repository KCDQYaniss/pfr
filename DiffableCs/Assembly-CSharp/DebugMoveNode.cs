//Type is in global namespace

public class DebugMoveNode : MoveNode
{
	private float _updatePointTimer; //Field offset: 0x28
	private float _nextPoint; //Field offset: 0x2C

	public DebugMoveNode(BotOwner bot) { }

	protected void RestartFindTime() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

