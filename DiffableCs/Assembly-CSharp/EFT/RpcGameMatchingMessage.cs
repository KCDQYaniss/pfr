namespace EFT;

public sealed class RpcGameMatchingMessage : ISerializableMessage
{
	[CompilerGenerated]
	private ushort <PlayersReady>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private ushort <PlayersToWait>k__BackingField; //Field offset: 0x12
	[CompilerGenerated]
	private ushort <SecondsLeftToStart>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private ushort <MaxWaitSeconds>k__BackingField; //Field offset: 0x16

	public ushort MaxWaitSeconds
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public ushort PlayersReady
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public ushort PlayersToWait
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public ushort SecondsLeftToStart
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public RpcGameMatchingMessage() { }

	public RpcGameMatchingMessage(ushort playersReady, ushort playersToWait, ushort secondsLeftToStart, ushort maxWaitSeconds) { }

	public override void Deserialize(NetworkReader reader) { }

	[CompilerGenerated]
	public ushort get_MaxWaitSeconds() { }

	[CompilerGenerated]
	public ushort get_PlayersReady() { }

	[CompilerGenerated]
	public ushort get_PlayersToWait() { }

	[CompilerGenerated]
	public ushort get_SecondsLeftToStart() { }

	public override void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	public void set_MaxWaitSeconds(ushort value) { }

	[CompilerGenerated]
	public void set_PlayersReady(ushort value) { }

	[CompilerGenerated]
	public void set_PlayersToWait(ushort value) { }

	[CompilerGenerated]
	public void set_SecondsLeftToStart(ushort value) { }

}

