namespace BitPacking;

public class BitReader : IBitReader
{
	private readonly uint* _data; //Field offset: 0x10
	private readonly byte[] _bufferBytes; //Field offset: 0x18
	private readonly int _wordsCount; //Field offset: 0x20
	private readonly int _bitsCount; //Field offset: 0x24
	private int _bitsRead; //Field offset: 0x28
	private ulong _scratch; //Field offset: 0x30
	private int _bitIndex; //Field offset: 0x38
	private int _wordIndex; //Field offset: 0x3C
	private bool _isOverflow; //Field offset: 0x40
	private bool _isVirgin; //Field offset: 0x41

	public override int BitsCount
	{
		 get { } //Length: 4
	}

	public override int BitsRead
	{
		 get { } //Length: 4
	}

	public override byte[] Buffer
	{
		 get { } //Length: 5
	}

	public override int BytesRead
	{
		 get { } //Length: 17
	}

	public override bool IsOverflow
	{
		 get { } //Length: 5
	}

	public int TotalBytes
	{
		 get { } //Length: 7
	}

	public BitReader(byte[] bufferBytes) { }

	public override int get_BitsCount() { }

	public override int get_BitsRead() { }

	public override byte[] get_Buffer() { }

	public override int get_BytesRead() { }

	public override bool get_IsOverflow() { }

	public int get_TotalBytes() { }

	public override int GetAlignBits() { }

	public override void ReadAlign() { }

	public override uint ReadBits(int bits) { }

	public override void ReadBytes(byte[] destination, int destinationStartIndex, int bytesCount) { }

	public override void Reset() { }

}

