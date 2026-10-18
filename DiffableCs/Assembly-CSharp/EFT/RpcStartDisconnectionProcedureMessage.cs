namespace EFT;

public sealed class RpcStartDisconnectionProcedureMessage : ISerializableMessage
{
	[CompilerGenerated]
	private int <DisconnectionCode>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <AdditionalInfo>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <TechnicalMessage>k__BackingField; //Field offset: 0x20

	public string AdditionalInfo
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public int DisconnectionCode
	{
		[CompilerGenerated]
		 get { } //Length: 164
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public string TechnicalMessage
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public RpcStartDisconnectionProcedureMessage() { }

	public RpcStartDisconnectionProcedureMessage(int disconnectionCode, string additionalInfo, string technicalMessage) { }

	public override void Deserialize(NetworkReader reader) { }

	[CompilerGenerated]
	public string get_AdditionalInfo() { }

	[CompilerGenerated]
	public int get_DisconnectionCode() { }

	[CompilerGenerated]
	public string get_TechnicalMessage() { }

	public override void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	public void set_AdditionalInfo(string value) { }

	[CompilerGenerated]
	public void set_DisconnectionCode(int value) { }

	[CompilerGenerated]
	public void set_TechnicalMessage(string value) { }

}

