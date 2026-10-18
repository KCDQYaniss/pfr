namespace EFT.NextObservedPlayer;

public sealed class ArmorFullChangeInfoCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public bool Added; //Field offset: 0x10
	public EArmorPlateCollider ArmorPlateColliderMask; //Field offset: 0x12
	public IEnumerable ArmorInfos; //Field offset: 0x18
	public IEnumerable RemoveItemIDs; //Field offset: 0x20

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public ArmorFullChangeInfoCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ArmorFullChangeInfoCommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

