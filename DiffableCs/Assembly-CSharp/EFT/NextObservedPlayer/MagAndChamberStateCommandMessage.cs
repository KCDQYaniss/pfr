namespace EFT.NextObservedPlayer;

public class MagAndChamberStateCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public int AmmoInMag; //Field offset: 0x10
	public int AmmoInChamber; //Field offset: 0x14
	public bool MagInWeapon; //Field offset: 0x18
	public bool Armed; //Field offset: 0x19

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public MagAndChamberStateCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

