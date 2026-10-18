namespace System.Xml;

internal class Ucs4Encoding : Encoding
{
	internal Ucs4Decoder ucs4Decoder; //Field offset: 0x38

	public virtual int CodePage
	{
		 get { } //Length: 3
	}

	internal static Encoding UCS4_2143
	{
		internal get { } //Length: 239
	}

	internal static Encoding UCS4_3412
	{
		internal get { } //Length: 239
	}

	internal static Encoding UCS4_Bigendian
	{
		internal get { } //Length: 239
	}

	internal static Encoding UCS4_Littleendian
	{
		internal get { } //Length: 239
	}

	public virtual string WebName
	{
		 get { } //Length: 20
	}

	public Ucs4Encoding() { }

	public virtual int get_CodePage() { }

	internal static Encoding get_UCS4_2143() { }

	internal static Encoding get_UCS4_3412() { }

	internal static Encoding get_UCS4_Bigendian() { }

	internal static Encoding get_UCS4_Littleendian() { }

	public virtual string get_WebName() { }

	public virtual int GetByteCount(char[] chars, int index, int count) { }

	public virtual byte[] GetBytes(string s) { }

	public virtual int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	public virtual int GetCharCount(byte[] bytes, int index, int count) { }

	public virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	public virtual Decoder GetDecoder() { }

	public virtual Encoder GetEncoder() { }

	public virtual int GetMaxByteCount(int charCount) { }

	public virtual int GetMaxCharCount(int byteCount) { }

}

