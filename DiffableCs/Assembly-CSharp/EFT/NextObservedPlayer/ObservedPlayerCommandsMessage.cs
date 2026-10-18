namespace EFT.NextObservedPlayer;

public class ObservedPlayerCommandsMessage : List, ISerializableMessage
{
	private const int CAPACITY_SIZE = 128; //Field offset: 0x0
	public static Dictionary CommandsCreationFuncs; //Field offset: 0x0

	private static ObservedPlayerCommandsMessage() { }

	private ObservedPlayerCommandsMessage() { }

	public ObservedPlayerCommandsMessage(IEnumerable collection) { }

	private ObservedPlayerCommandsMessage(int capacity) { }

	public ObservedPlayerCommandsMessage Clone() { }

	public static ObservedPlayerCommandsMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Serialize(NetworkWriter writer) { }

}

