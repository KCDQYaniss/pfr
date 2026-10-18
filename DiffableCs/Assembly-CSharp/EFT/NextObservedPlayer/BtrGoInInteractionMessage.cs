namespace EFT.NextObservedPlayer;

public class BtrGoInInteractionMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	[CompilerGenerated]
	private byte <BtrSideId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private byte <BtrSlotId>k__BackingField; //Field offset: 0x11
	[CompilerGenerated]
	private bool <Fast>k__BackingField; //Field offset: 0x12

	public byte BtrSideId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public byte BtrSlotId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool Fast
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

	public BtrGoInInteractionMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static BtrGoInInteractionMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	[CompilerGenerated]
	public byte get_BtrSideId() { }

	[CompilerGenerated]
	public byte get_BtrSlotId() { }

	[CompilerGenerated]
	public bool get_Fast() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	public void set_BtrSideId(byte value) { }

	[CompilerGenerated]
	public void set_BtrSlotId(byte value) { }

	[CompilerGenerated]
	public void set_Fast(bool value) { }

}

