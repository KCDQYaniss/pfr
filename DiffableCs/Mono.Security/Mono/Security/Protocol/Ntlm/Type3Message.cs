namespace Mono.Security.Protocol.Ntlm;

public class Type3Message : MessageBase
{
	private NtlmAuthLevel _level; //Field offset: 0x18
	private byte[] _challenge; //Field offset: 0x20
	private string _host; //Field offset: 0x28
	private string _domain; //Field offset: 0x30
	private string _username; //Field offset: 0x38
	private string _password; //Field offset: 0x40
	private Type2Message _type2; //Field offset: 0x48
	private byte[] _lm; //Field offset: 0x50
	private byte[] _nt; //Field offset: 0x58

	public string Domain
	{
		 set { } //Length: 235
	}

	public string Password
	{
		 set { } //Length: 82
	}

	public string Username
	{
		 set { } //Length: 82
	}

	public Type3Message(Type2Message type2) { }

	protected virtual void Decode(byte[] message) { }

	private string DecodeString(byte[] buffer, int offset, int len) { }

	private byte[] EncodeString(string text) { }

	protected virtual void Finalize() { }

	public virtual byte[] GetBytes() { }

	public void set_Domain(string value) { }

	public void set_Password(string value) { }

	public void set_Username(string value) { }

}

