namespace System.Security.Cryptography.X509Certificates;

internal static class X509Helper
{

	private static ISystemCertificateProvider CertificateProvider
	{
		private get { } //Length: 113
	}

	private static ISystemCertificateProvider get_CertificateProvider() { }

	internal static Exception GetInvalidContextException() { }

	public static X509CertificateImpl Import(byte[] rawData) { }

	public static X509CertificateImpl Import(byte[] rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	public static X509CertificateImpl InitFromCertificate(X509Certificate cert) { }

	public static X509CertificateImpl InitFromCertificate(X509CertificateImpl impl) { }

	public static bool IsValid(X509CertificateImpl impl) { }

	internal static void ThrowIfContextInvalid(X509CertificateImpl impl) { }

}

