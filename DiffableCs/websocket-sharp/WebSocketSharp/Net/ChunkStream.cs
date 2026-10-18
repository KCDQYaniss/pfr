namespace WebSocketSharp.Net;

internal class ChunkStream
{
	private int _chunkRead; //Field offset: 0x10
	private int _chunkSize; //Field offset: 0x14
	private List _chunks; //Field offset: 0x18
	private int _count; //Field offset: 0x20
	private byte[] _endBuffer; //Field offset: 0x28
	private bool _gotIt; //Field offset: 0x30
	private WebHeaderCollection _headers; //Field offset: 0x38
	private int _offset; //Field offset: 0x40
	private StringBuilder _saved; //Field offset: 0x48
	private bool _sawCr; //Field offset: 0x50
	private InputChunkState _state; //Field offset: 0x54
	private int _trailerState; //Field offset: 0x58

	internal int Count
	{
		internal get { } //Length: 6
	}

	internal byte[] EndBuffer
	{
		internal get { } //Length: 7
	}

	public WebHeaderCollection Headers
	{
		 get { } //Length: 7
	}

	internal int Offset
	{
		internal get { } //Length: 6
	}

	public bool WantsMore
	{
		 get { } //Length: 10
	}

	public ChunkStream(WebHeaderCollection headers) { }

	internal int get_Count() { }

	internal byte[] get_EndBuffer() { }

	public WebHeaderCollection get_Headers() { }

	internal int get_Offset() { }

	public bool get_WantsMore() { }

	private int read(byte[] buffer, int offset, int count) { }

	public int Read(byte[] buffer, int offset, int count) { }

	internal void ResetChunkStore() { }

	private InputChunkState seekCrLf(byte[] buffer, ref int offset, int length) { }

	private InputChunkState setChunkSize(byte[] buffer, ref int offset, int length) { }

	private InputChunkState setTrailer(byte[] buffer, ref int offset, int length) { }

	private static void throwProtocolViolation(string message) { }

	private void write(byte[] buffer, int offset, int length) { }

	public void Write(byte[] buffer, int offset, int count) { }

	private InputChunkState writeData(byte[] buffer, ref int offset, int length) { }

}

