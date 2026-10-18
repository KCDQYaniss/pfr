//Type is in global namespace

public class DogFightNode : MoveNode
{
	private readonly Aiming _aiming; //Field offset: 0x28
	protected readonly ShallThrowGrenade _grenadeThrowNode; //Field offset: 0x30

	public DogFightNode(BotOwner bot) { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

