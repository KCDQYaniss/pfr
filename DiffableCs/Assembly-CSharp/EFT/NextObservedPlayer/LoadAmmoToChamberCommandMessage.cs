namespace EFT.NextObservedPlayer;

public sealed class LoadAmmoToChamberCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public MongoID AmmoTemplate; //Field offset: 0x10
	public int ChamberIndex; //Field offset: 0x28

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public LoadAmmoToChamberCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

