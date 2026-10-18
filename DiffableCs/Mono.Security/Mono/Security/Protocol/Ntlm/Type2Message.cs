namespace Mono.Security.Protocol.Ntlm;

public class Type2Message : MessageBase
{
	private byte[] _nonce; //Field offset: 0x18
	private string _targetName; //Field offset: 0x20
	private byte[] _targetInfo; //Field offset: 0x28

	public byte[] Nonce
	{
		 get { } //Length: 122
	}

	public byte[] TargetInfo
	{
		 get { } //Length: 122
	}

	public string TargetName
	{
		 get { } //Length: 5
	}

	public Type2Message(byte[] message) { }

	protected virtual void Decode(byte[] message) { }

	protected virtual void Finalize() { }

	public byte[] get_Nonce() { }

	public byte[] get_TargetInfo() { }

	public string get_TargetName() { }

	public virtual byte[] GetBytes() { }

}

