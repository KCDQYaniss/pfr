namespace BitPacking;

public class BitWriter : IBitWriter
{
	private readonly uint* _data; //Field offset: 0x10
	private readonly byte[] _bufferBytes; //Field offset: 0x18
	private readonly int _wordsCount; //Field offset: 0x20
	private readonly int _bitsCount; //Field offset: 0x24
	private ulong _scratch; //Field offset: 0x28
	private int _bitIndex; //Field offset: 0x30
	private int _wordIndex; //Field offset: 0x34
	private bool _isOverflow; //Field offset: 0x38
	private int _bitsWritten; //Field offset: 0x3C

	public override int BitsCount
	{
		 get { } //Length: 4
	}

	public override int BitsWritten
	{
		 get { } //Length: 4
	}

	public override byte[] Buffer
	{
		 get { } //Length: 5
	}

	public override int BytesWritten
	{
		 get { } //Length: 7
	}

	public override bool IsOverflow
	{
		 get { } //Length: 5
	}

	public override int TotalBytes
	{
		 get { } //Length: 7
	}

	public BitWriter(byte[] bufferBytes) { }

	public override void FlushBits() { }

	public override int get_BitsCount() { }

	public override int get_BitsWritten() { }

	public override byte[] get_Buffer() { }

	public override int get_BytesWritten() { }

	public override bool get_IsOverflow() { }

	public override int get_TotalBytes() { }

	private int GetAlignBits() { }

	public override void Reset() { }

	public override void WriteBits(uint value, int bits) { }

	public override void WriteByteAlign() { }

	public override void WriteBytes(byte[] bytes, int startIndex, int length) { }

	public override void WriteBytes(byte[] bytes) { }

}

