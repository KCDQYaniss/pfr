namespace Vuplex.WebView;

public class StandaloneX509Certificate
{
	public readonly StandaloneX509CertificatePrincipal Issuer; //Field offset: 0x10
	public readonly int RequestID; //Field offset: 0x18
	public readonly StandaloneX509CertificatePrincipal Subject; //Field offset: 0x20
	public readonly DateTime ValidStart; //Field offset: 0x28
	public readonly DateTime ValidExpiry; //Field offset: 0x30
	internal readonly int ID; //Field offset: 0x38

	internal StandaloneX509Certificate(int requestID, MessageCertificate cert) { }

	public virtual string ToString() { }

}

