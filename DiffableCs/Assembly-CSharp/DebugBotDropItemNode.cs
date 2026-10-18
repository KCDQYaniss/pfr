//Type is in global namespace

public class DebugBotDropItemNode : BaseNode
{
	private float _nextTimeDrop; //Field offset: 0x18

	public DebugBotDropItemNode(BotOwner bot) { }

	public void ManualUpdate() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

