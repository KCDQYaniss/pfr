namespace Vuplex.WebView.Internal;

internal class CertificateRequestMessage
{
	public int ID; //Field offset: 0x10
	public MessageCertificate[] Certificates; //Field offset: 0x18
	public string Host; //Field offset: 0x20
	public int Port; //Field offset: 0x28
	public bool IsProxy; //Field offset: 0x2C

	public CertificateRequestMessage() { }

}

