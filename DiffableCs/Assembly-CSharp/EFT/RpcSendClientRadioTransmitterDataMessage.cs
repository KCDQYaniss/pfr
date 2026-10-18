namespace EFT;

public sealed class RpcSendClientRadioTransmitterDataMessage : ISerializableMessage
{
	[CompilerGenerated]
	private RadioTransmitterData <Data>k__BackingField; //Field offset: 0x10

	public RadioTransmitterData Data
	{
		[CompilerGenerated]
		 get { } //Length: 21
		[CompilerGenerated]
		 set { } //Length: 98
	}

	public RpcSendClientRadioTransmitterDataMessage() { }

	public RpcSendClientRadioTransmitterDataMessage(RadioTransmitterData data) { }

	public override void Deserialize(NetworkReader reader) { }

	[CompilerGenerated]
	public RadioTransmitterData get_Data() { }

	public override void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	public void set_Data(RadioTransmitterData value) { }

}

