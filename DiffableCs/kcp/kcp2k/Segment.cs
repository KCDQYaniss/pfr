namespace kcp2k;

internal class Segment
{
	internal uint conv; //Field offset: 0x10
	internal uint cmd; //Field offset: 0x14
	internal uint frg; //Field offset: 0x18
	internal uint wnd; //Field offset: 0x1C
	internal uint ts; //Field offset: 0x20
	internal uint sn; //Field offset: 0x24
	internal uint una; //Field offset: 0x28
	internal uint resendts; //Field offset: 0x2C
	internal int rto; //Field offset: 0x30
	internal uint fastack; //Field offset: 0x34
	internal uint xmit; //Field offset: 0x38
	internal MemoryStream data; //Field offset: 0x40

	public Segment() { }

	internal int Encode(byte[] ptr, int offset) { }

	internal void Reset() { }

}

