namespace System.Diagnostics;

internal class AsyncStreamReader : IDisposable
{
	private Stream stream; //Field offset: 0x10
	private Encoding encoding; //Field offset: 0x18
	private Decoder decoder; //Field offset: 0x20
	private byte[] byteBuffer; //Field offset: 0x28
	private char[] charBuffer; //Field offset: 0x30
	private int _maxCharsPerBuffer; //Field offset: 0x38
	private Process process; //Field offset: 0x40
	private UserCallBack userCallBack; //Field offset: 0x48
	private bool cancelOperation; //Field offset: 0x50
	private ManualResetEvent eofEvent; //Field offset: 0x58
	private Queue messageQueue; //Field offset: 0x60
	private StringBuilder sb; //Field offset: 0x68
	private bool bLastCarriageReturn; //Field offset: 0x70
	private int currentLinePos; //Field offset: 0x74
	private object syncObject; //Field offset: 0x78
	private IAsyncResult asyncReadResult; //Field offset: 0x80

	internal AsyncStreamReader(Process process, Stream stream, UserCallBack callback, Encoding encoding) { }

	internal AsyncStreamReader(Process process, Stream stream, UserCallBack callback, Encoding encoding, int bufferSize) { }

	internal void BeginReadLine() { }

	internal void CancelOperation() { }

	public override void Close() { }

	protected override void Dispose(bool disposing) { }

	private void FlushMessageQueue() { }

	private void GetLinesFromStringBuilder() { }

	private void Init(Process process, Stream stream, UserCallBack callback, Encoding encoding, int bufferSize) { }

	private void ReadBuffer(IAsyncResult ar) { }

	private override void System.IDisposable.Dispose() { }

	internal void WaitUtilEOF() { }

}

