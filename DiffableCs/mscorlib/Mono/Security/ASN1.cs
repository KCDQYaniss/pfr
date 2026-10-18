namespace Mono.Security;

[DefaultMember("Item")]
internal class ASN1
{
	private byte m_nTag; //Field offset: 0x10
	private byte[] m_aValue; //Field offset: 0x18
	private ArrayList elist; //Field offset: 0x20

	public int Count
	{
		 get { } //Length: 34
	}

	public byte[] Value
	{
		 get { } //Length: 151
	}

	public ASN1(byte tag) { }

	public ASN1(byte tag, byte[] data) { }

	public ASN1(byte[] data) { }

	public ASN1 Add(ASN1 asn1) { }

	protected void Decode(byte[] asn1, ref int anPos, int anLength) { }

	protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content) { }

	public int get_Count() { }

	public byte[] get_Value() { }

	public override byte[] GetBytes() { }

	public virtual string ToString() { }

}

