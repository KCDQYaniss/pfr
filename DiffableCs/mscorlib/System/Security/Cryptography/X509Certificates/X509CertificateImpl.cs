namespace System.Security.Cryptography.X509Certificates;

internal abstract class X509CertificateImpl : IDisposable
{

	public abstract bool HasPrivateKey
	{
		 get { } //Length: 0
	}

	public abstract string Issuer
	{
		 get { } //Length: 0
	}

	public abstract bool IsValid
	{
		 get { } //Length: 0
	}

	public abstract string KeyAlgorithm
	{
		 get { } //Length: 0
	}

	public abstract byte[] KeyAlgorithmParameters
	{
		 get { } //Length: 0
	}

	public abstract DateTime NotAfter
	{
		 get { } //Length: 0
	}

	public abstract DateTime NotBefore
	{
		 get { } //Length: 0
	}

	public abstract byte[] PublicKeyValue
	{
		 get { } //Length: 0
	}

	public abstract byte[] RawData
	{
		 get { } //Length: 0
	}

	public abstract byte[] SerialNumber
	{
		 get { } //Length: 0
	}

	public abstract string Subject
	{
		 get { } //Length: 0
	}

	public abstract byte[] Thumbprint
	{
		 get { } //Length: 0
	}

	protected X509CertificateImpl() { }

	public abstract X509CertificateImpl Clone() { }

	protected override void Dispose(bool disposing) { }

	public override void Dispose() { }

	public virtual bool Equals(object obj) { }

	public abstract byte[] Export(X509ContentType contentType, SafePasswordHandle password) { }

	protected virtual void Finalize() { }

	public abstract bool get_HasPrivateKey() { }

	public abstract string get_Issuer() { }

	public abstract bool get_IsValid() { }

	public abstract string get_KeyAlgorithm() { }

	public abstract byte[] get_KeyAlgorithmParameters() { }

	public abstract DateTime get_NotAfter() { }

	public abstract DateTime get_NotBefore() { }

	public abstract byte[] get_PublicKeyValue() { }

	public abstract byte[] get_RawData() { }

	public abstract byte[] get_SerialNumber() { }

	public abstract string get_Subject() { }

	public abstract byte[] get_Thumbprint() { }

	public abstract DSA GetDSAPrivateKey() { }

	public virtual int GetHashCode() { }

	public abstract RSA GetRSAPrivateKey() { }

	protected void ThrowIfContextInvalid() { }

}

