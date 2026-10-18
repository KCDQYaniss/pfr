namespace Vuplex.WebView.Internal;

public class MessageCertificate
{
	public int ID; //Field offset: 0x10
	public MessageCertificatePrincipal Issuer; //Field offset: 0x18
	public MessageCertificatePrincipal Subject; //Field offset: 0x20
	public long ValidStart; //Field offset: 0x28
	public long ValidExpiry; //Field offset: 0x30

	public MessageCertificate() { }

}

