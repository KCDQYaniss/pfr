//Type is in global namespace

public class SuppressStationaryNode : BaseNode
{
	private readonly AimingToStationarySuppressionPoint _aiming; //Field offset: 0x18

	public SuppressStationaryNode(BotOwner bot) { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

