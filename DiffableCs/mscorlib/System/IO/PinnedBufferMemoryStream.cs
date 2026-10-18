namespace System.IO;

internal sealed class PinnedBufferMemoryStream : UnmanagedMemoryStream
{
	private byte[] _array; //Field offset: 0x68
	private GCHandle _pinningHandle; //Field offset: 0x70

	internal PinnedBufferMemoryStream(byte[] array) { }

	protected virtual void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public virtual int Read(Span buffer) { }

	public virtual void Write(ReadOnlySpan buffer) { }

}

