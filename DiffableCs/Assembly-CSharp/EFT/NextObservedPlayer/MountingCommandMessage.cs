namespace EFT.NextObservedPlayer;

public class MountingCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public bool IsMounted; //Field offset: 0x10
	public Vector3 MountingPoint; //Field offset: 0x14
	public float CurrentMountingPointVerticalOffset; //Field offset: 0x20
	public int MountingDirection; //Field offset: 0x24
	public EMountingCommand Command; //Field offset: 0x28
	public float TransitionTime; //Field offset: 0x2C

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public MountingCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static MountingCommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

