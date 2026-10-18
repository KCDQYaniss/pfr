namespace EFT.NextObservedPlayer;

public class FlareShotFirearmCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public Vector3 ShotPosition; //Field offset: 0x10
	public Vector3 ShotDirection; //Field offset: 0x1C
	public MongoID AmmoTemplate; //Field offset: 0x28

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public FlareShotFirearmCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

