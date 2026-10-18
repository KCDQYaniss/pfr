namespace Vuplex.WebView;

public class StandaloneX509CertificatePrincipal
{
	public readonly string DisplayName; //Field offset: 0x10
	public readonly string CommonName; //Field offset: 0x18
	public readonly string LocalityName; //Field offset: 0x20
	public readonly string StateOrProvinceName; //Field offset: 0x28
	public readonly string CountryName; //Field offset: 0x30

	internal StandaloneX509CertificatePrincipal(MessageCertificatePrincipal principal) { }

	public virtual string ToString() { }

}

