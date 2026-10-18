namespace EFT.NextObservedPlayer;

public sealed class SyncCylinderMagazineCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public int CurrentCamoraIndex; //Field offset: 0x10
	public Nullable[] AmmoInChambers; //Field offset: 0x18
	public Nullable[] ShellsInChambers; //Field offset: 0x20

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public SyncCylinderMagazineCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

