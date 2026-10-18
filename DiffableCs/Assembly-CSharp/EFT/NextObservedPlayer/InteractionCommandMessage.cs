namespace EFT.NextObservedPlayer;

public class InteractionCommandMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	[CompilerGenerated]
	private bool <ResetGesture>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private EInteraction <Interaction>k__BackingField; //Field offset: 0x11

	public EInteraction Interaction
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool ResetGesture
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public InteractionCommandMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	[CompilerGenerated]
	public EInteraction get_Interaction() { }

	[CompilerGenerated]
	public bool get_ResetGesture() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	public void set_Interaction(EInteraction value) { }

	[CompilerGenerated]
	public void set_ResetGesture(bool value) { }

}

