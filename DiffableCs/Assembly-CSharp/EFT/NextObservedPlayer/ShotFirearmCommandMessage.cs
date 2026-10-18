namespace EFT.NextObservedPlayer;

public sealed class ShotFirearmCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public Vector3 ShotPosition; //Field offset: 0x10
	public Vector3 ShotDirection; //Field offset: 0x1C
	public MongoID AmmoTemplate; //Field offset: 0x28
	public int ChamberIndex; //Field offset: 0x40

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public ShotFirearmCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

