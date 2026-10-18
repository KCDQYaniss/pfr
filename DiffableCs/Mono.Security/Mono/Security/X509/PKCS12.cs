namespace Mono.Security.X509;

public class PKCS12 : ICloneable
{
	internal class DeriveBytes
	{
		private static byte[] keyDiversifier; //Field offset: 0x0
		private static byte[] ivDiversifier; //Field offset: 0x8
		private static byte[] macDiversifier; //Field offset: 0x10
		private string _hashName; //Field offset: 0x10
		private int _iterations; //Field offset: 0x18
		private byte[] _password; //Field offset: 0x20
		private byte[] _salt; //Field offset: 0x28

		public string HashName
		{
			 set { } //Length: 82
		}

		public int IterationCount
		{
			 set { } //Length: 4
		}

		public byte[] Password
		{
			 set { } //Length: 376
		}

		public byte[] Salt
		{
			 set { } //Length: 349
		}

		private static DeriveBytes() { }

		public DeriveBytes() { }

		private void Adjust(byte[] a, int aOff, byte[] b) { }

		private byte[] Derive(byte[] diversifier, int n) { }

		public byte[] DeriveIV(int size) { }

		public byte[] DeriveKey(int size) { }

		public byte[] DeriveMAC(int size) { }

		public void set_HashName(string value) { }

		public void set_IterationCount(int value) { }

		public void set_Password(byte[] value) { }

		public void set_Salt(byte[] value) { }

	}

	private static int password_max_length; //Field offset: 0x0
	private byte[] _password; //Field offset: 0x10
	private ArrayList _keyBags; //Field offset: 0x18
	private ArrayList _secretBags; //Field offset: 0x20
	private X509CertificateCollection _certs; //Field offset: 0x28
	private bool _keyBagsChanged; //Field offset: 0x30
	private bool _secretBagsChanged; //Field offset: 0x31
	private bool _certsChanged; //Field offset: 0x32
	private int _iterations; //Field offset: 0x34
	private ArrayList _safeBags; //Field offset: 0x38
	private RandomNumberGenerator _rng; //Field offset: 0x40

	public X509CertificateCollection Certificates
	{
		 get { } //Length: 1113
	}

	public int IterationCount
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public ArrayList Keys
	{
		 get { } //Length: 1788
	}

	public static int MaximumPasswordLength
	{
		 get { } //Length: 82
	}

	public string Password
	{
		 set { } //Length: 627
	}

	internal RandomNumberGenerator RNG
	{
		internal get { } //Length: 117
	}

	private static PKCS12() { }

	public PKCS12(byte[] data, string password) { }

	public PKCS12() { }

	public PKCS12(byte[] data) { }

	public void AddCertificate(X509Certificate cert, IDictionary attributes) { }

	public void AddCertificate(X509Certificate cert) { }

	public void AddPkcs8ShroudedKeyBag(AsymmetricAlgorithm aa, IDictionary attributes) { }

	private void AddPrivateKey(PrivateKeyInfo pki) { }

	private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes) { }

	public override object Clone() { }

	private bool Compare(byte[] expected, byte[] actual) { }

	private bool CompareAsymmetricAlgorithm(AsymmetricAlgorithm a1, AsymmetricAlgorithm a2) { }

	private void Decode(byte[] data) { }

	public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData) { }

	public byte[] Decrypt(EncryptedData ed) { }

	public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data) { }

	private ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid) { }

	protected virtual void Finalize() { }

	public X509CertificateCollection get_Certificates() { }

	public int get_IterationCount() { }

	public ArrayList get_Keys() { }

	public static int get_MaximumPasswordLength() { }

	internal RandomNumberGenerator get_RNG() { }

	public byte[] GetBytes() { }

	private DSAParameters GetExistingParameters(out bool found) { }

	private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount) { }

	private byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data) { }

	private ASN1 Pkcs8ShroudedKeyBagSafeBag(AsymmetricAlgorithm aa, IDictionary attributes) { }

	private void ReadSafeBag(ASN1 safeBag) { }

	public void RemoveCertificate(X509Certificate cert) { }

	public void RemoveCertificate(X509Certificate cert, IDictionary attrs) { }

	public void set_IterationCount(int value) { }

	public void set_Password(string value) { }

}

