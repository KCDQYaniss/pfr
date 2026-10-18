namespace EFT.NextObservedPlayer;

public class SetFinishReloadInternalMagWithOpenBoltMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public int MagazineCount; //Field offset: 0x10
	public int ChamberAmmoCount; //Field offset: 0x14
	public bool InInventory; //Field offset: 0x18

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public SetFinishReloadInternalMagWithOpenBoltMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static SetFinishReloadInternalMagWithOpenBoltMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

