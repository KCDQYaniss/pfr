namespace EFT.NextObservedPlayer;

public sealed class SwingGrenadeCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public EGrenadeAttackVariation Variation; //Field offset: 0x10
	public float Speed; //Field offset: 0x14

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public SwingGrenadeCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

