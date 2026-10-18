namespace Mono.Btls;

internal class X509CertificateImplBtls : X509Certificate2ImplUnix
{
	private MonoBtlsX509 x509; //Field offset: 0xB0
	private MonoBtlsKey nativePrivateKey; //Field offset: 0xB8
	private X509CertificateImplCollection intermediateCerts; //Field offset: 0xC0

	public virtual bool HasPrivateKey
	{
		 get { } //Length: 12
	}

	internal virtual X509CertificateImplCollection IntermediateCertificates
	{
		internal get { } //Length: 8
	}

	public virtual bool IsValid
	{
		 get { } //Length: 68
	}

	internal MonoBtlsKey NativePrivateKey
	{
		internal get { } //Length: 78
	}

	public virtual AsymmetricAlgorithm PrivateKey
	{
		 get { } //Length: 52
		 set { } //Length: 359
	}

	internal MonoBtlsX509 X509
	{
		internal get { } //Length: 78
	}

	internal X509CertificateImplBtls(MonoBtlsX509 x509) { }

	private X509CertificateImplBtls(X509CertificateImplBtls other) { }

	internal X509CertificateImplBtls(byte[] data, MonoBtlsX509Format format) { }

	internal X509CertificateImplBtls(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	public virtual X509CertificateImpl Clone() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual bool get_HasPrivateKey() { }

	internal virtual X509CertificateImplCollection get_IntermediateCertificates() { }

	public virtual bool get_IsValid() { }

	internal MonoBtlsKey get_NativePrivateKey() { }

	public virtual AsymmetricAlgorithm get_PrivateKey() { }

	internal MonoBtlsX509 get_X509() { }

	public virtual DSA GetDSAPrivateKey() { }

	protected virtual byte[] GetRawCertData() { }

	public virtual RSA GetRSAPrivateKey() { }

	private void Import(byte[] data) { }

	private void ImportAuthenticode(byte[] data) { }

	private void ImportPkcs12(byte[] data, SafePasswordHandle password) { }

	public virtual void set_PrivateKey(AsymmetricAlgorithm value) { }

	public virtual bool Verify(X509Certificate2 thisCertificate) { }

}

