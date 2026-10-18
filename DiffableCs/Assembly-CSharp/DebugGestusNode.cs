//Type is in global namespace

public class DebugGestusNode : BaseNode
{
	private float _updatePointTimer; //Field offset: 0x18
	private readonly List gestuses; //Field offset: 0x20

	public DebugGestusNode(BotOwner bot) { }

	public virtual void Awake() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

