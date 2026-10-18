namespace EFT;

public sealed class RpcGameStoppedMessage : ISerializableMessage
{
	[CompilerGenerated]
	private ExitStatus <ExitStatus>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <PlaySeconds>k__BackingField; //Field offset: 0x14

	public ExitStatus ExitStatus
	{
		[CompilerGenerated]
		 get { } //Length: 164
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int PlaySeconds
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public RpcGameStoppedMessage() { }

	public RpcGameStoppedMessage(ExitStatus exitStatus, int playSeconds) { }

	public override void Deserialize(NetworkReader reader) { }

	[CompilerGenerated]
	public ExitStatus get_ExitStatus() { }

	[CompilerGenerated]
	public int get_PlaySeconds() { }

	public override void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	public void set_ExitStatus(ExitStatus value) { }

	[CompilerGenerated]
	public void set_PlaySeconds(int value) { }

}

