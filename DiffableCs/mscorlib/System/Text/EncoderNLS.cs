namespace System.Text;

internal class EncoderNLS : Encoder
{
	internal char _charLeftOver; //Field offset: 0x20
	private Encoding _encoding; //Field offset: 0x28
	private bool _mustFlush; //Field offset: 0x30
	internal bool _throwOnOverflow; //Field offset: 0x31
	internal int _charsUsed; //Field offset: 0x34

	public Encoding Encoding
	{
		 get { } //Length: 5
	}

	internal override bool HasState
	{
		internal get { } //Length: 9
	}

	public bool MustFlush
	{
		 get { } //Length: 5
	}

	internal EncoderNLS(Encoding encoding) { }

	internal void ClearMustFlush() { }

	public virtual void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	public virtual void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	public Encoding get_Encoding() { }

	internal override bool get_HasState() { }

	public bool get_MustFlush() { }

	public virtual int GetByteCount(char[] chars, int index, int count, bool flush) { }

	public virtual int GetByteCount(char* chars, int count, bool flush) { }

	public virtual int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	public virtual void Reset() { }

}

