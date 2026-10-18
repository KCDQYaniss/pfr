namespace EFT.NextObservedPlayer;

public class SetUnderRoofStatusMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	[CompilerGenerated]
	private Nullable <IsUnderRoof>k__BackingField; //Field offset: 0x10

	public Nullable IsUnderRoof
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public SetUnderRoofStatusMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	[CompilerGenerated]
	public Nullable get_IsUnderRoof() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	public void set_IsUnderRoof(Nullable value) { }

}

