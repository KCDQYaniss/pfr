namespace NAudio.Wave;

internal class WaveFileWriter : Stream
{
	private Stream _outStream; //Field offset: 0x28
	private BinaryWriter _writer; //Field offset: 0x30
	private long _dataSizePos; //Field offset: 0x38
	private long _factSampleCountPos; //Field offset: 0x40
	private int _dataChunkSize; //Field offset: 0x48
	[CompilerGenerated]
	private string <Filename>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private WaveFormat <WaveFormat>k__BackingField; //Field offset: 0x58

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

	public private string Filename
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public virtual long Length
	{
		 get { } //Length: 5
	}

	public virtual long Position
	{
		 get { } //Length: 5
		 set { } //Length: 78
	}

	public private WaveFormat WaveFormat
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public WaveFileWriter(Stream outStream, WaveFormat format) { }

	public WaveFileWriter(string filename, WaveFormat format) { }

	private void CreateFactChunk() { }

	protected virtual void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public virtual void Flush() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	[CompilerGenerated]
	public string get_Filename() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	[CompilerGenerated]
	public WaveFormat get_WaveFormat() { }

	private bool HasFactChunk() { }

	public virtual int Read(byte[] buffer, int offset, int count) { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	[CompilerGenerated]
	private void set_Filename(string value) { }

	public virtual void set_Position(long value) { }

	[CompilerGenerated]
	private void set_WaveFormat(WaveFormat value) { }

	public virtual void SetLength(long value) { }

	private void UpdateDataChunk(BinaryWriter writer) { }

	private void UpdateFactChunk(BinaryWriter writer) { }

	protected override void UpdateHeader(BinaryWriter writer) { }

	private void UpdateRiffChunk(BinaryWriter writer) { }

	public virtual void Write(byte[] data, int offset, int count) { }

	private void WriteDataChunkHeader() { }

	public void WriteSample(float sample) { }

	public void WriteSamples(float[] samples, int offset, int count) { }

}

