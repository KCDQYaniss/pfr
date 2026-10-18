namespace Mono.Security.Protocol.Ntlm;

public abstract class MessageBase
{
	private static byte[] header; //Field offset: 0x0
	private int _type; //Field offset: 0x10
	private NtlmFlags _flags; //Field offset: 0x14

	public NtlmFlags Flags
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public int Type
	{
		 get { } //Length: 164
	}

	private static MessageBase() { }

	protected MessageBase(int messageType) { }

	protected bool CheckHeader(byte[] message) { }

	protected override void Decode(byte[] message) { }

	public NtlmFlags get_Flags() { }

	public int get_Type() { }

	public abstract byte[] GetBytes() { }

	protected byte[] PrepareMessage(int messageSize) { }

	public void set_Flags(NtlmFlags value) { }

}

