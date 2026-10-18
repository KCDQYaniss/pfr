namespace System.IO;

[ComVisible(True)]
public class BinaryWriter : IDisposable, IAsyncDisposable
{
	public static readonly BinaryWriter Null; //Field offset: 0x0
	private const int LargeByteBufferSize = 256; //Field offset: 0x0
	protected Stream OutStream; //Field offset: 0x10
	private byte[] _buffer; //Field offset: 0x18
	private Encoding _encoding; //Field offset: 0x20
	private Encoder _encoder; //Field offset: 0x28
	[OptionalField]
	private bool _leaveOpen; //Field offset: 0x30
	[OptionalField]
	private char[] _tmpOneCharBuffer; //Field offset: 0x38
	private byte[] _largeByteBuffer; //Field offset: 0x40
	private int _maxChars; //Field offset: 0x48

	public override Stream BaseStream
	{
		 get { } //Length: 38
	}

	private static BinaryWriter() { }

	public BinaryWriter(Stream output, Encoding encoding, bool leaveOpen) { }

	protected BinaryWriter() { }

	public BinaryWriter(Stream output) { }

	public BinaryWriter(Stream output, Encoding encoding) { }

	public override void Close() { }

	protected override void Dispose(bool disposing) { }

	public override void Dispose() { }

	public override ValueTask DisposeAsync() { }

	public override void Flush() { }

	public override Stream get_BaseStream() { }

	public override long Seek(int offset, SeekOrigin origin) { }

	public override void Write(int value) { }

	[CLSCompliant(False)]
	public override void Write(uint value) { }

	public override void Write(string value) { }

	[CLSCompliant(False)]
	public override void Write(ulong value) { }

	public override void Write(float value) { }

	[CLSCompliant(False)]
	public override void Write(ushort value) { }

	public override void Write(long value) { }

	public override void Write(short value) { }

	public override void Write(char ch) { }

	public override void Write(double value) { }

	public override void Write(char[] chars) { }

	public override void Write(byte[] buffer, int index, int count) { }

	[CLSCompliant(False)]
	public override void Write(sbyte value) { }

	public override void Write(byte value) { }

	public override void Write(bool value) { }

	public override void Write(decimal value) { }

	public override void Write(byte[] buffer) { }

	protected void Write7BitEncodedInt(int value) { }

}

