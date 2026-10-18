namespace EFT.NextObservedPlayer;

public sealed class ThrowPatronAsLootCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public ItemDescriptor Item; //Field offset: 0x10
	public Vector3 Position; //Field offset: 0x18
	public Quaternion Rotation; //Field offset: 0x24
	public Vector3 Velocity; //Field offset: 0x34
	public Vector3 AngularVelocity; //Field offset: 0x40

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public ThrowPatronAsLootCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

