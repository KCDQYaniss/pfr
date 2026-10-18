namespace EFT;

public sealed class RpcGameStartedMessage : ISerializableMessage
{
	[CompilerGenerated]
	private float <PastTime>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <SessionSeconds>k__BackingField; //Field offset: 0x14

	public float PastTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public int SessionSeconds
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public RpcGameStartedMessage() { }

	public RpcGameStartedMessage(float pastTime, int sessionSeconds) { }

	public override void Deserialize(NetworkReader reader) { }

	[CompilerGenerated]
	public float get_PastTime() { }

	[CompilerGenerated]
	public int get_SessionSeconds() { }

	public override void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	public void set_PastTime(float value) { }

	[CompilerGenerated]
	public void set_SessionSeconds(int value) { }

}

