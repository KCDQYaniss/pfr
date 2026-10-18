namespace EFT.NextObservedPlayer;

public sealed class HeadDeviceStatusCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	internal enum EHeadDeviceType
	{
		FaceShield = 0,
		NightVision = 1,
		ThermalVision = 2,
	}

	public EHeadDeviceType DeviceType; //Field offset: 0x10
	public bool IsActive; //Field offset: 0x14

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public HeadDeviceStatusCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static HeadDeviceStatusCommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

