namespace Mono.Security.X509.Extensions;

public class AuthorityKeyIdentifierExtension : X509Extension
{
	private byte[] aki; //Field offset: 0x28

	public byte[] Identifier
	{
		 get { } //Length: 126
	}

	public AuthorityKeyIdentifierExtension(X509Extension extension) { }

	protected virtual void Decode() { }

	protected virtual void Encode() { }

	public byte[] get_Identifier() { }

	public virtual string ToString() { }

}

