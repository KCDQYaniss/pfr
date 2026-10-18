namespace EFT;

public abstract class EventObjectController
{

	protected EventObjectController() { }

	public abstract InteractWithEventObjectPacket GetInteractPacket(int objectId, EInteraction interaction) { }

	public abstract void InteractWithEventObject(Player player, InteractWithEventObjectPacket packet) { }

}

