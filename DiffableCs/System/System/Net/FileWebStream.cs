namespace System.Net;

internal sealed class FileWebStream : FileStream, ICloseEx
{
	private FileWebRequest m_request; //Field offset: 0x70

	public FileWebStream(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing) { }

	public FileWebStream(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing, int length, bool async) { }

	public virtual IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	public virtual IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	private void CheckError() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual int EndRead(IAsyncResult ar) { }

	public virtual void EndWrite(IAsyncResult ar) { }

	public virtual int Read(byte[] buffer, int offset, int size) { }

	private override void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	public virtual void Write(byte[] buffer, int offset, int size) { }

}

