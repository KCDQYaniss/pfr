namespace EFT.NextObservedPlayer;

public class AbortReloadCylinderMagazineCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public AbortReloadCylinderMagazineCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

