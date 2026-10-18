namespace EFT.NextObservedPlayer;

public class PullOutMagCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public string SlotModeID; //Field offset: 0x10
	public int AmmoInChamber; //Field offset: 0x18
	public int MagTypeCurrent; //Field offset: 0x1C
	public bool Boltcatch; //Field offset: 0x20
	public bool InMisfireMalfunction; //Field offset: 0x21

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public PullOutMagCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

