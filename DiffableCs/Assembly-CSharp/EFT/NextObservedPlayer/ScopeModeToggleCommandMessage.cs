namespace EFT.NextObservedPlayer;

public class ScopeModeToggleCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public string ID; //Field offset: 0x10
	public bool SetSilently; //Field offset: 0x18
	public int ScopeMode; //Field offset: 0x1C
	public int ScopeIndexInsideSight; //Field offset: 0x20
	public int ScopeCalibrationIndex; //Field offset: 0x24

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public ScopeModeToggleCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ScopeModeToggleCommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

