namespace EFT;

public sealed class RpcSendArtilleryShellingDataMessage : ISerializableMessage
{
	[CompilerGenerated]
	private int <ShellingFinished>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <TimeToNextShelling>k__BackingField; //Field offset: 0x14

	public int ShellingFinished
	{
		[CompilerGenerated]
		 get { } //Length: 164
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int TimeToNextShelling
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public RpcSendArtilleryShellingDataMessage() { }

	public RpcSendArtilleryShellingDataMessage(int shellingFinished, int timeToNextShelling) { }

	public override void Deserialize(NetworkReader reader) { }

	[CompilerGenerated]
	public int get_ShellingFinished() { }

	[CompilerGenerated]
	public int get_TimeToNextShelling() { }

	public override void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	public void set_ShellingFinished(int value) { }

	[CompilerGenerated]
	public void set_TimeToNextShelling(int value) { }

}

