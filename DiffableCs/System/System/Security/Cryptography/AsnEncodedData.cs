namespace System.Security.Cryptography;

public class AsnEncodedData
{
	internal Oid _oid; //Field offset: 0x10
	internal byte[] _raw; //Field offset: 0x18

	public Oid Oid
	{
		 get { } //Length: 5
		 set { } //Length: 293
	}

	public byte[] RawData
	{
		 get { } //Length: 5
		 set { } //Length: 318
	}

	protected AsnEncodedData() { }

	public AsnEncodedData(string oid, byte[] rawData) { }

	public AsnEncodedData(Oid oid, byte[] rawData) { }

	public AsnEncodedData(AsnEncodedData asnEncodedData) { }

	internal string BasicConstraintsExtension(bool multiLine) { }

	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	internal string Default(bool multiLine) { }

	internal string EnhancedKeyUsageExtension(bool multiLine) { }

	public override string Format(bool multiLine) { }

	public Oid get_Oid() { }

	public byte[] get_RawData() { }

	internal string KeyUsageExtension(bool multiLine) { }

	internal string NetscapeCertType(bool multiLine) { }

	public void set_Oid(Oid value) { }

	public void set_RawData(byte[] value) { }

	internal string SubjectAltName(bool multiLine) { }

	internal string SubjectKeyIdentifierExtension(bool multiLine) { }

	internal override string ToString(bool multiLine) { }

}

