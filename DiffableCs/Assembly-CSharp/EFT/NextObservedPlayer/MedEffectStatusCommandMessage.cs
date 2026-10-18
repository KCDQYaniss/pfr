namespace EFT.NextObservedPlayer;

public class MedEffectStatusCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public bool EffectAdded; //Field offset: 0x10
	public string EffectID; //Field offset: 0x18

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public MedEffectStatusCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static MedEffectStatusCommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

