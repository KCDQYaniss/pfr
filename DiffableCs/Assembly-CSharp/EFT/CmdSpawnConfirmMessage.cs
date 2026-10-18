namespace EFT;

public sealed class CmdSpawnConfirmMessage : ISerializableMessage
{
	[CompilerGenerated]
	private int <PlayerId>k__BackingField; //Field offset: 0x10

	public private int PlayerId
	{
		[CompilerGenerated]
		 get { } //Length: 164
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public CmdSpawnConfirmMessage() { }

	public CmdSpawnConfirmMessage(int playerId) { }

	public override void Deserialize(NetworkReader reader) { }

	[CompilerGenerated]
	public int get_PlayerId() { }

	public override void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	private void set_PlayerId(int value) { }

}

