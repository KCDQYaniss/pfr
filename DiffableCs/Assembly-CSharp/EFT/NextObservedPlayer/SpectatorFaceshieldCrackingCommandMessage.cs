namespace EFT.NextObservedPlayer;

public class SpectatorFaceshieldCrackingCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public byte HitSeed; //Field offset: 0x10
	public byte Hits; //Field offset: 0x11
	public float RepairableDurability; //Field offset: 0x14

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public SpectatorFaceshieldCrackingCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static SpectatorFaceshieldCrackingCommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

