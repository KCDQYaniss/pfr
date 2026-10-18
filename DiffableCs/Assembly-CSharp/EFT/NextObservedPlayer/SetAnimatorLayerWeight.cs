namespace EFT.NextObservedPlayer;

public sealed class SetAnimatorLayerWeight : ICommandMessage, ISerializableMessage, IDisposable
{
	public int LayerIndex; //Field offset: 0x10
	public float Weight; //Field offset: 0x14

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public SetAnimatorLayerWeight() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

