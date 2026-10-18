namespace EFT.NextObservedPlayer;

public sealed class SpectatorHealthEffectDisplayCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public bool Clear; //Field offset: 0x10
	public EHealthEffectType EffectType; //Field offset: 0x14
	public int Count; //Field offset: 0x18

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public SpectatorHealthEffectDisplayCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static SpectatorHealthEffectDisplayCommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

