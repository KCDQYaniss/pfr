namespace BitPacking;

public interface IBitReader
{

	public int BitsCount
	{
		 get { } //Length: 0
	}

	public int BitsRead
	{
		 get { } //Length: 0
	}

	public byte[] Buffer
	{
		 get { } //Length: 0
	}

	public int BytesRead
	{
		 get { } //Length: 0
	}

	public bool IsOverflow
	{
		 get { } //Length: 0
	}

	public int get_BitsCount() { }

	public int get_BitsRead() { }

	public byte[] get_Buffer() { }

	public int get_BytesRead() { }

	public bool get_IsOverflow() { }

	public int GetAlignBits() { }

	public void ReadAlign() { }

	public uint ReadBits(int bits) { }

	public void ReadBytes(byte[] destination, int destinationStartIndex, int bytesCount) { }

	public void Reset() { }

}

