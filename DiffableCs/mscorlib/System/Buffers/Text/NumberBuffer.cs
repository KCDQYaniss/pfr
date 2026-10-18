namespace System.Buffers.Text;

[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
internal struct NumberBuffer
{
	public int Scale; //Field offset: 0x0
	public bool IsNegative; //Field offset: 0x4
	private byte _b0; //Field offset: 0x5
	private byte _b1; //Field offset: 0x6
	private byte _b2; //Field offset: 0x7
	private byte _b3; //Field offset: 0x8
	private byte _b4; //Field offset: 0x9
	private byte _b5; //Field offset: 0xA
	private byte _b6; //Field offset: 0xB
	private byte _b7; //Field offset: 0xC
	private byte _b8; //Field offset: 0xD
	private byte _b9; //Field offset: 0xE
	private byte _b10; //Field offset: 0xF
	private byte _b11; //Field offset: 0x10
	private byte _b12; //Field offset: 0x11
	private byte _b13; //Field offset: 0x12
	private byte _b14; //Field offset: 0x13
	private byte _b15; //Field offset: 0x14
	private byte _b16; //Field offset: 0x15
	private byte _b17; //Field offset: 0x16
	private byte _b18; //Field offset: 0x17
	private byte _b19; //Field offset: 0x18
	private byte _b20; //Field offset: 0x19
	private byte _b21; //Field offset: 0x1A
	private byte _b22; //Field offset: 0x1B
	private byte _b23; //Field offset: 0x1C
	private byte _b24; //Field offset: 0x1D
	private byte _b25; //Field offset: 0x1E
	private byte _b26; //Field offset: 0x1F
	private byte _b27; //Field offset: 0x20
	private byte _b28; //Field offset: 0x21
	private byte _b29; //Field offset: 0x22
	private byte _b30; //Field offset: 0x23
	private byte _b31; //Field offset: 0x24
	private byte _b32; //Field offset: 0x25
	private byte _b33; //Field offset: 0x26
	private byte _b34; //Field offset: 0x27
	private byte _b35; //Field offset: 0x28
	private byte _b36; //Field offset: 0x29
	private byte _b37; //Field offset: 0x2A
	private byte _b38; //Field offset: 0x2B
	private byte _b39; //Field offset: 0x2C
	private byte _b40; //Field offset: 0x2D
	private byte _b41; //Field offset: 0x2E
	private byte _b42; //Field offset: 0x2F
	private byte _b43; //Field offset: 0x30
	private byte _b44; //Field offset: 0x31
	private byte _b45; //Field offset: 0x32
	private byte _b46; //Field offset: 0x33
	private byte _b47; //Field offset: 0x34
	private byte _b48; //Field offset: 0x35
	private byte _b49; //Field offset: 0x36
	private byte _b50; //Field offset: 0x37

	public Span Digits
	{
		 get { } //Length: 78
	}

	public int NumDigits
	{
		 get { } //Length: 129
	}

	public Span get_Digits() { }

	public int get_NumDigits() { }

	public virtual string ToString() { }

}

