namespace BitPacking;

public sealed class InvalidMaxSizeException : Exception
{
	[CompilerGenerated]
	private int <Size>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private uint <MaxSize>k__BackingField; //Field offset: 0x94
	[CompilerGenerated]
	private byte[] <Bytes>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private int <BitsRead>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private int <BytesRead>k__BackingField; //Field offset: 0xA4

	public private int BitsRead
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private byte[] Bytes
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private int BytesRead
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private uint MaxSize
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private int Size
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public InvalidMaxSizeException(int size, uint maxSize) { }

	public InvalidMaxSizeException(int size, uint maxSize, IBitReader bitReader) { }

	[CompilerGenerated]
	public int get_BitsRead() { }

	[CompilerGenerated]
	public byte[] get_Bytes() { }

	[CompilerGenerated]
	public int get_BytesRead() { }

	[CompilerGenerated]
	public uint get_MaxSize() { }

	[CompilerGenerated]
	public int get_Size() { }

	[CompilerGenerated]
	private void set_BitsRead(int value) { }

	[CompilerGenerated]
	private void set_Bytes(byte[] value) { }

	[CompilerGenerated]
	private void set_BytesRead(int value) { }

	[CompilerGenerated]
	private void set_MaxSize(uint value) { }

	[CompilerGenerated]
	private void set_Size(int value) { }

	public virtual string ToString() { }

}

