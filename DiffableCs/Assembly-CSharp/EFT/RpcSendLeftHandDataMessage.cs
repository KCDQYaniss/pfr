namespace EFT;

public sealed class RpcSendLeftHandDataMessage : ISerializableMessage
{
	internal struct LeftHandData
	{
		public bool IsUsing; //Field offset: 0x0
		public string ItemId; //Field offset: 0x8

	}

	[CompilerGenerated]
	private LeftHandData <Data>k__BackingField; //Field offset: 0x10

	public LeftHandData Data
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public RpcSendLeftHandDataMessage() { }

	public RpcSendLeftHandDataMessage(LeftHandData data) { }

	public override void Deserialize(NetworkReader reader) { }

	[CompilerGenerated]
	public LeftHandData get_Data() { }

	public override void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	public void set_Data(LeftHandData value) { }

}

