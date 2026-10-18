namespace EFT;

public sealed class RpcSuccessAirdropFlareEventMessage : ISerializableMessage
{
	[CompilerGenerated]
	private bool <CanSendAirdrop>k__BackingField; //Field offset: 0x10

	public bool CanSendAirdrop
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public RpcSuccessAirdropFlareEventMessage() { }

	public RpcSuccessAirdropFlareEventMessage(bool canSendAirdrop) { }

	public override void Deserialize(NetworkReader reader) { }

	[CompilerGenerated]
	public bool get_CanSendAirdrop() { }

	public override void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	public void set_CanSendAirdrop(bool value) { }

}

