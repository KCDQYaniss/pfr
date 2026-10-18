namespace EFT.NextObservedPlayer;

public sealed class PerksParamsCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public float BushNoiseMultiplier; //Field offset: 0x10
	public float BushSlowdownMultiplier; //Field offset: 0x14
	public float RunSpeedMultiplier; //Field offset: 0x18

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public PerksParamsCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static PerksParamsCommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

