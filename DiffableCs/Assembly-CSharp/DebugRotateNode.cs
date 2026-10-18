//Type is in global namespace

public class DebugRotateNode : BaseNode
{
	private bool _step; //Field offset: 0x18
	private Vector3 _toLookDir; //Field offset: 0x1C
	private float _updatePointTimer; //Field offset: 0x28

	public DebugRotateNode(BotOwner bot) { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

