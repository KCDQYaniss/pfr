namespace Mono;

internal abstract class X509PalImpl
{
	private static byte[] signedData; //Field offset: 0x0

	public bool SupportsLegacyBasicConstraintsExtension
	{
		 get { } //Length: 3
	}

	private static X509PalImpl() { }

	protected X509PalImpl() { }

	protected static byte[] ConvertData(byte[] data) { }

	public bool get_SupportsLegacyBasicConstraintsExtension() { }

	public X509ContentType GetCertContentType(byte[] rawData) { }

	public abstract X509CertificateImpl Import(byte[] data) { }

	public abstract X509Certificate2Impl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	public abstract X509Certificate2Impl Import(X509Certificate cert) { }

	internal X509Certificate2Impl ImportFallback(byte[] data) { }

	internal X509Certificate2Impl ImportFallback(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	private static byte[] PEM(string type, byte[] data) { }

}

