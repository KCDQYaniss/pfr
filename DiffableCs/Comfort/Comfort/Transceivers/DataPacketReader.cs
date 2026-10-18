namespace Comfort.Transceivers;

public sealed class DataPacketReader
{
	internal sealed class CustomStream : Stream
	{
		private byte[] _buffer; //Field offset: 0x28
		private int _offset; //Field offset: 0x30
		private int _count; //Field offset: 0x34
		private int _position; //Field offset: 0x38

		public virtual bool CanRead
		{
			 get { } //Length: 3
		}

		public virtual bool CanSeek
		{
			 get { } //Length: 3
		}

		public virtual bool CanWrite
		{
			 get { } //Length: 3
		}

		public virtual long Length
		{
			 get { } //Length: 5
		}

		public virtual long Position
		{
			 get { } //Length: 5
			 set { } //Length: 4
		}

		public CustomStream() { }

		public virtual void Flush() { }

		public virtual bool get_CanRead() { }

		public virtual bool get_CanSeek() { }

		public virtual bool get_CanWrite() { }

		public virtual long get_Length() { }

		public virtual long get_Position() { }

		public virtual int Read(byte[] buffer, int offset, int count) { }

		public virtual long Seek(long offset, SeekOrigin origin) { }

		public virtual void set_Position(long value) { }

		public virtual void SetLength(long value) { }

		public void SetSegment(byte[] buffer, int offset, int count) { }

		public virtual void Write(byte[] buffer, int offset, int count) { }

	}

	private readonly BinaryReceiver _receiver; //Field offset: 0x10
	private readonly CustomStream _stream; //Field offset: 0x18
	private readonly BinaryReader _reader; //Field offset: 0x20

	public DataPacketReader(BinaryReceiver receiver) { }

	public DataPacketReader(BinaryReceiver unnamed_param_0, int unnamed_param_1) { }

	public int Transceive(ref ArraySegment segment) { }

	private void TransceivePacket(byte[] buffer, int offset, int count) { }

}

