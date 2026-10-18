namespace EFT.NextObservedPlayer;

public class ArmorDurabilityChangedCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public MongoID ArmorItemID; //Field offset: 0x10
	public float Durability; //Field offset: 0x28
	public EArmorPlateCollider ArmorPlateColliderMask; //Field offset: 0x2C

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public ArmorDurabilityChangedCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ArmorDurabilityChangedCommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

