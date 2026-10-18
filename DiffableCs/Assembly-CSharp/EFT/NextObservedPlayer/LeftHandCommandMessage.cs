namespace EFT.NextObservedPlayer;

public class LeftHandCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	[Nullable]
	public ItemDescriptor Item; //Field offset: 0x10
	public bool Remove; //Field offset: 0x18
	public float RemoveSpeed; //Field offset: 0x1C

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public LeftHandCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static LeftHandCommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

