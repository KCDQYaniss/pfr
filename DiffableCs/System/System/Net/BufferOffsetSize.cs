namespace System.Net;

internal class BufferOffsetSize
{
	internal byte[] Buffer; //Field offset: 0x10
	internal int Offset; //Field offset: 0x18
	internal int Size; //Field offset: 0x1C

	internal BufferOffsetSize(byte[] buffer, int offset, int size, bool copyBuffer) { }

	internal BufferOffsetSize(byte[] buffer, bool copyBuffer) { }

}

