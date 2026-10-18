namespace EFT.NextObservedPlayer;

public class MedEffectResourceCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public string MedItemID; //Field offset: 0x10
	public float Resource; //Field offset: 0x18

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public MedEffectResourceCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static MedEffectResourceCommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

