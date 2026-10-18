namespace Mono.Security.X509;

public class X509Certificate : ISerializable
{
	private static string encoding_error; //Field offset: 0x0
	private ASN1 decoder; //Field offset: 0x10
	private byte[] m_encodedcert; //Field offset: 0x18
	private DateTime m_from; //Field offset: 0x20
	private DateTime m_until; //Field offset: 0x28
	private ASN1 issuer; //Field offset: 0x30
	private string m_issuername; //Field offset: 0x38
	private string m_keyalgo; //Field offset: 0x40
	private byte[] m_keyalgoparams; //Field offset: 0x48
	private ASN1 subject; //Field offset: 0x50
	private string m_subject; //Field offset: 0x58
	private byte[] m_publickey; //Field offset: 0x60
	private byte[] signature; //Field offset: 0x68
	private string m_signaturealgo; //Field offset: 0x70
	private byte[] m_signaturealgoparams; //Field offset: 0x78
	private byte[] certhash; //Field offset: 0x80
	private RSA _rsa; //Field offset: 0x88
	private DSA _dsa; //Field offset: 0x90
	private int version; //Field offset: 0x98
	private byte[] serialnumber; //Field offset: 0xA0
	private byte[] issuerUniqueID; //Field offset: 0xA8
	private byte[] subjectUniqueID; //Field offset: 0xB0
	private X509ExtensionCollection extensions; //Field offset: 0xB8

	public DSA DSA
	{
		 get { } //Length: 1317
		 set { } //Length: 202
	}

	public X509ExtensionCollection Extensions
	{
		 get { } //Length: 8
	}

	public byte[] Hash
	{
		 get { } //Length: 588
	}

	public bool IsCurrent
	{
		 get { } //Length: 270
	}

	public bool IsSelfSigned
	{
		 get { } //Length: 194
	}

	public override string IssuerName
	{
		 get { } //Length: 5
	}

	public override string KeyAlgorithm
	{
		 get { } //Length: 5
	}

	public override byte[] KeyAlgorithmParameters
	{
		 get { } //Length: 126
		 set { } //Length: 82
	}

	public override byte[] PublicKey
	{
		 get { } //Length: 126
	}

	public override byte[] RawData
	{
		 get { } //Length: 126
	}

	public override RSA RSA
	{
		 get { } //Length: 738
		 set { } //Length: 187
	}

	public override byte[] SerialNumber
	{
		 get { } //Length: 132
	}

	public override byte[] Signature
	{
		 get { } //Length: 1294
	}

	public override string SubjectName
	{
		 get { } //Length: 5
	}

	public override DateTime ValidFrom
	{
		 get { } //Length: 5
	}

	public override DateTime ValidUntil
	{
		 get { } //Length: 5
	}

	public int Version
	{
		 get { } //Length: 7
	}

	private static X509Certificate() { }

	public X509Certificate(byte[] data) { }

	public DSA get_DSA() { }

	public X509ExtensionCollection get_Extensions() { }

	public byte[] get_Hash() { }

	public bool get_IsCurrent() { }

	public bool get_IsSelfSigned() { }

	public override string get_IssuerName() { }

	public override string get_KeyAlgorithm() { }

	public override byte[] get_KeyAlgorithmParameters() { }

	public override byte[] get_PublicKey() { }

	public override byte[] get_RawData() { }

	public override RSA get_RSA() { }

	public override byte[] get_SerialNumber() { }

	public override byte[] get_Signature() { }

	public override string get_SubjectName() { }

	public override DateTime get_ValidFrom() { }

	public override DateTime get_ValidUntil() { }

	public int get_Version() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private byte[] GetUnsignedBigInteger(byte[] integer) { }

	private void Parse(byte[] data) { }

	private static byte[] PEM(string type, byte[] data) { }

	public void set_DSA(DSA value) { }

	public override void set_KeyAlgorithmParameters(byte[] value) { }

	public override void set_RSA(RSA value) { }

	internal bool VerifySignature(DSA dsa) { }

	internal bool VerifySignature(RSA rsa) { }

	public bool VerifySignature(AsymmetricAlgorithm aa) { }

	public bool WasCurrent(DateTime instant) { }

}

