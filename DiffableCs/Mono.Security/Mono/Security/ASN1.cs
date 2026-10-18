namespace Mono.Security;

[DefaultMember("Item")]
public class ASN1
{
	private byte m_nTag; //Field offset: 0x10
	private byte[] m_aValue; //Field offset: 0x18
	private ArrayList elist; //Field offset: 0x20

	public int Count
	{
		 get { } //Length: 34
	}

	public ASN1 Item
	{
		 get { } //Length: 200
	}

	public int Length
	{
		 get { } //Length: 18
	}

	public byte Tag
	{
		 get { } //Length: 5
	}

	public byte[] Value
	{
		 get { } //Length: 151
		 set { } //Length: 245
	}

	public ASN1(byte tag) { }

	public ASN1(byte tag, byte[] data) { }

	public ASN1(byte[] data) { }

	public ASN1 Add(ASN1 asn1) { }

	private bool CompareArray(byte[] array1, byte[] array2) { }

	public bool CompareValue(byte[] value) { }

	protected void Decode(byte[] asn1, ref int anPos, int anLength) { }

	protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content) { }

	public ASN1 Element(int index, byte anTag) { }

	public int get_Count() { }

	public ASN1 get_Item(int index) { }

	public int get_Length() { }

	public byte get_Tag() { }

	public byte[] get_Value() { }

	public override byte[] GetBytes() { }

	public void set_Value(byte[] value) { }

	public virtual string ToString() { }

}

