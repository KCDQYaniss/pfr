//Type is in global namespace

public class DebugWeaponChangeNode : BaseNode
{
	private float _updatePointTimer; //Field offset: 0x18

	public DebugWeaponChangeNode(BotOwner bot) { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

