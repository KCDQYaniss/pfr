namespace WebSocketSharp.Net;

internal class ReadBufferState
{
	private HttpStreamAsyncResult _asyncResult; //Field offset: 0x10
	private byte[] _buffer; //Field offset: 0x18
	private int _count; //Field offset: 0x20
	private int _initialCount; //Field offset: 0x24
	private int _offset; //Field offset: 0x28

	public HttpStreamAsyncResult AsyncResult
	{
		 get { } //Length: 7
		 set { } //Length: 82
	}

	public byte[] Buffer
	{
		 get { } //Length: 7
		 set { } //Length: 82
	}

	public int Count
	{
		 get { } //Length: 6
		 set { } //Length: 4
	}

	public int InitialCount
	{
		 get { } //Length: 6
		 set { } //Length: 4
	}

	public int Offset
	{
		 get { } //Length: 6
		 set { } //Length: 4
	}

	public ReadBufferState(byte[] buffer, int offset, int count, HttpStreamAsyncResult asyncResult) { }

	public HttpStreamAsyncResult get_AsyncResult() { }

	public byte[] get_Buffer() { }

	public int get_Count() { }

	public int get_InitialCount() { }

	public int get_Offset() { }

	public void set_AsyncResult(HttpStreamAsyncResult value) { }

	public void set_Buffer(byte[] value) { }

	public void set_Count(int value) { }

	public void set_InitialCount(int value) { }

	public void set_Offset(int value) { }

}

