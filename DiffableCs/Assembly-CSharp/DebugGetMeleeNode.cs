//Type is in global namespace

public class DebugGetMeleeNode : BaseNode
{
	private float _updatePointTimer; //Field offset: 0x18
	private bool _state; //Field offset: 0x1C

	public DebugGetMeleeNode(BotOwner bot) { }

	public virtual void Awake() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

