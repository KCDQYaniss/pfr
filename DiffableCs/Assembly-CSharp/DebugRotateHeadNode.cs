//Type is in global namespace

public class DebugRotateHeadNode : BaseNode
{
	public bool OffHead; //Field offset: 0x18
	private bool step; //Field offset: 0x19
	private float toLookDir; //Field offset: 0x1C
	private float _updatePointTimer; //Field offset: 0x20

	public DebugRotateHeadNode(BotOwner bot) { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

