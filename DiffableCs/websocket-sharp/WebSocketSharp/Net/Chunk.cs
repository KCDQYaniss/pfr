namespace WebSocketSharp.Net;

internal class Chunk
{
	private byte[] _data; //Field offset: 0x10
	private int _offset; //Field offset: 0x18

	public int ReadLeft
	{
		 get { } //Length: 29
	}

	public Chunk(byte[] data) { }

	public int get_ReadLeft() { }

	public int Read(byte[] buffer, int offset, int count) { }

}

