namespace EFT.NextObservedPlayer;

public sealed class TacticalModeToggleCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	public string ID; //Field offset: 0x10
	public bool SetSilently; //Field offset: 0x18
	public bool State; //Field offset: 0x19
	public int LightMode; //Field offset: 0x1C

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public TacticalModeToggleCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static TacticalModeToggleCommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

}

