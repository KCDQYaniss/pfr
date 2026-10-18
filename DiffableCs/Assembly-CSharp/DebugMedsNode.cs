//Type is in global namespace

public class DebugMedsNode : BaseNode
{
	private float _updatePointTimer; //Field offset: 0x18
	private float _updateGoPointTimer; //Field offset: 0x1C

	public DebugMedsNode(BotOwner bot) { }

	public virtual void Awake() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

