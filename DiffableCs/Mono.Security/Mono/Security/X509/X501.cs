namespace Mono.Security.X509;

public sealed class X501
{
	private static byte[] countryName; //Field offset: 0x0
	private static byte[] organizationName; //Field offset: 0x8
	private static byte[] organizationalUnitName; //Field offset: 0x10
	private static byte[] commonName; //Field offset: 0x18
	private static byte[] localityName; //Field offset: 0x20
	private static byte[] stateOrProvinceName; //Field offset: 0x28
	private static byte[] streetAddress; //Field offset: 0x30
	private static byte[] serialNumber; //Field offset: 0x38
	private static byte[] domainComponent; //Field offset: 0x40
	private static byte[] userid; //Field offset: 0x48
	private static byte[] email; //Field offset: 0x50
	private static byte[] dnQualifier; //Field offset: 0x58
	private static byte[] title; //Field offset: 0x60
	private static byte[] surname; //Field offset: 0x68
	private static byte[] givenName; //Field offset: 0x70
	private static byte[] initial; //Field offset: 0x78

	private static X501() { }

	private static void AppendEntry(StringBuilder sb, ASN1 entry, bool quotes) { }

	public static ASN1 FromString(string rdn) { }

	private static AttributeTypeAndValue GetAttributeFromOid(string attributeType) { }

	private static bool IsHex(char c) { }

	private static bool IsOid(string oid) { }

	private static AttributeTypeAndValue ReadAttribute(string value, ref int pos) { }

	private static int ReadEscaped(StringBuilder sb, string value, int pos) { }

	private static string ReadHex(string value, ref int pos) { }

	private static int ReadQuoted(StringBuilder sb, string value, int pos) { }

	private static string ReadValue(string value, ref int pos) { }

	public static string ToString(ASN1 seq) { }

	public static string ToString(ASN1 seq, bool reversed, string separator, bool quotes) { }

}

