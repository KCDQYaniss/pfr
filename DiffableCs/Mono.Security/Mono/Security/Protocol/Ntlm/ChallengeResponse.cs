namespace Mono.Security.Protocol.Ntlm;

[Obsolete("Use of this API is highly discouraged, it selects legacy-mode LM/NTLM authentication, which sends your password in very weak encryption over the wire even if the server supports the more secure NTLMv2 / NTLMv2 Session. You need to use the new `Type3Message (Type2Message)' constructor to use the more secure NTLMv2 / NTLMv2 Session authentication modes. These require the Type 2 message from the server to compute the response.")]
public class ChallengeResponse : IDisposable
{
	private static byte[] magic; //Field offset: 0x0
	private static byte[] nullEncMagic; //Field offset: 0x8
	private bool _disposed; //Field offset: 0x10
	private byte[] _challenge; //Field offset: 0x18
	private byte[] _lmpwd; //Field offset: 0x20
	private byte[] _ntpwd; //Field offset: 0x28

	public byte[] Challenge
	{
		 set { } //Length: 407
	}

	public byte[] LM
	{
		 get { } //Length: 108
	}

	public byte[] NT
	{
		 get { } //Length: 108
	}

	public string Password
	{
		 set { } //Length: 2179
	}

	private static ChallengeResponse() { }

	public ChallengeResponse() { }

	public ChallengeResponse(string password, byte[] challenge) { }

	public override void Dispose() { }

	private void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public byte[] get_LM() { }

	public byte[] get_NT() { }

	private byte[] GetResponse(byte[] pwd) { }

	private byte[] PasswordToKey(string password, int position) { }

	private byte[] PrepareDESKey(byte[] key56bits, int position) { }

	public void set_Challenge(byte[] value) { }

	public void set_Password(string value) { }

}

