namespace EFT.NextObservedPlayer;

public class VaultingCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public Vector3 VaultingPoint; //Field offset: 0x10
	public EVaultingStrategy VaultingStrategy; //Field offset: 0x1C
	public float VaultingSpeed; //Field offset: 0x20
	public float VaultingHeight; //Field offset: 0x24
	public float VaultingLength; //Field offset: 0x28
	public float BehindObstacleRatio; //Field offset: 0x2C
	public float AbsoluteForwardVelocity; //Field offset: 0x30

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public VaultingCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static VaultingCommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

