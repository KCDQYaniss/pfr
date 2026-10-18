namespace Mono.Security;

public sealed class PKCS7
{
	internal class ContentInfo
	{
		private string contentType; //Field offset: 0x10
		private ASN1 content; //Field offset: 0x18

		public ASN1 ASN1
		{
			 get { } //Length: 7
		}

		public ASN1 Content
		{
			 get { } //Length: 5
			 set { } //Length: 82
		}

		public string ContentType
		{
			 get { } //Length: 5
			 set { } //Length: 82
		}

		public ContentInfo() { }

		public ContentInfo(string oid) { }

		public ContentInfo(byte[] data) { }

		public ContentInfo(ASN1 asn1) { }

		public ASN1 get_ASN1() { }

		public ASN1 get_Content() { }

		public string get_ContentType() { }

		internal ASN1 GetASN1() { }

		public void set_Content(ASN1 value) { }

		public void set_ContentType(string value) { }

	}

	internal class EncryptedData
	{
		private byte _version; //Field offset: 0x10
		private ContentInfo _content; //Field offset: 0x18
		private ContentInfo _encryptionAlgorithm; //Field offset: 0x20
		private byte[] _encrypted; //Field offset: 0x28

		public byte[] EncryptedContent
		{
			 get { } //Length: 126
		}

		public ContentInfo EncryptionAlgorithm
		{
			 get { } //Length: 5
		}

		public EncryptedData() { }

		public EncryptedData(ASN1 asn1) { }

		public byte[] get_EncryptedContent() { }

		public ContentInfo get_EncryptionAlgorithm() { }

	}

	internal class SignedData
	{
		private byte version; //Field offset: 0x10
		private string hashAlgorithm; //Field offset: 0x18
		private ContentInfo contentInfo; //Field offset: 0x20
		private X509CertificateCollection certs; //Field offset: 0x28
		private ArrayList crls; //Field offset: 0x30
		private SignerInfo signerInfo; //Field offset: 0x38
		private bool mda; //Field offset: 0x40

		public X509CertificateCollection Certificates
		{
			 get { } //Length: 5
		}

		public ContentInfo ContentInfo
		{
			 get { } //Length: 5
		}

		public string HashName
		{
			 set { } //Length: 211
		}

		public SignerInfo SignerInfo
		{
			 get { } //Length: 5
		}

		public SignedData(ASN1 asn1) { }

		public X509CertificateCollection get_Certificates() { }

		public ContentInfo get_ContentInfo() { }

		public SignerInfo get_SignerInfo() { }

		internal string OidToName(string oid) { }

		public void set_HashName(string value) { }

	}

	internal class SignerInfo
	{
		private byte version; //Field offset: 0x10
		private string hashAlgorithm; //Field offset: 0x18
		private ArrayList authenticatedAttributes; //Field offset: 0x20
		private ArrayList unauthenticatedAttributes; //Field offset: 0x28
		private byte[] signature; //Field offset: 0x30
		private string issuer; //Field offset: 0x38
		private byte[] serial; //Field offset: 0x40
		private byte[] ski; //Field offset: 0x48

		public ArrayList AuthenticatedAttributes
		{
			 get { } //Length: 5
		}

		public string HashName
		{
			 get { } //Length: 5
			 set { } //Length: 82
		}

		public string IssuerName
		{
			 get { } //Length: 5
		}

		public byte[] SerialNumber
		{
			 get { } //Length: 126
		}

		public byte[] Signature
		{
			 get { } //Length: 126
		}

		public ArrayList UnauthenticatedAttributes
		{
			 get { } //Length: 5
		}

		public byte Version
		{
			 get { } //Length: 5
		}

		public SignerInfo() { }

		public SignerInfo(ASN1 asn1) { }

		public ArrayList get_AuthenticatedAttributes() { }

		public string get_HashName() { }

		public string get_IssuerName() { }

		public byte[] get_SerialNumber() { }

		public byte[] get_Signature() { }

		public ArrayList get_UnauthenticatedAttributes() { }

		public byte get_Version() { }

		public void set_HashName(string value) { }

	}


}

