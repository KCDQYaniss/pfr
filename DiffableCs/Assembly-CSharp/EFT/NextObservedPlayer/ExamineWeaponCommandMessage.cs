namespace EFT.NextObservedPlayer;

public class ExamineWeaponCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public bool CheckAmmo; //Field offset: 0x10
	public bool CheckChamber; //Field offset: 0x11
	public bool Look; //Field offset: 0x12
	public EMalfunctionState MalfunctionState; //Field offset: 0x14
	public bool CheckFireMode; //Field offset: 0x18
	public bool InInventory; //Field offset: 0x19
	public int AmmoInMag; //Field offset: 0x1C

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public ExamineWeaponCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

