namespace System.Text;

internal class DecoderNLS : Decoder
{
	private Encoding _encoding; //Field offset: 0x20
	private bool _mustFlush; //Field offset: 0x28
	internal bool _throwOnOverflow; //Field offset: 0x29
	internal int _bytesUsed; //Field offset: 0x2C

	internal override bool HasState
	{
		internal get { } //Length: 3
	}

	public bool MustFlush
	{
		 get { } //Length: 5
	}

	internal DecoderNLS(Encoding encoding) { }

	internal void ClearMustFlush() { }

	public virtual void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	public virtual void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	internal override bool get_HasState() { }

	public bool get_MustFlush() { }

	public virtual int GetCharCount(byte[] bytes, int index, int count) { }

	public virtual int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	public virtual int GetCharCount(byte* bytes, int count, bool flush) { }

	public virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	public virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

	public virtual void Reset() { }

}

