namespace EFT.NextObservedPlayer;

public class SoundDamageInfoCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public float Damage; //Field offset: 0x10
	public EDamageType DamageType; //Field offset: 0x14

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public SoundDamageInfoCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static SoundDamageInfoCommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

