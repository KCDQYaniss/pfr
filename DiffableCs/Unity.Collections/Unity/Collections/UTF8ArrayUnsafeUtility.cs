namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
public static class UTF8ArrayUnsafeUtility
{
	public struct Comparison
	{
		public bool terminates; //Field offset: 0x0
		public int result; //Field offset: 0x4

		public Comparison(Rune runeA, ConversionError errorA, Rune runeB, ConversionError errorB) { }

	}


	public static CopyError Append(byte* dest, ref ushort destLength, ushort destUTF8MaxLengthInBytes, byte* src, ushort srcLength) { }

	public static CopyError Append(byte* dest, ref ushort destLength, ushort destUTF8MaxLengthInBytes, char* src, int srcLength) { }

	public static CopyError Append(char* dest, ref ushort destLength, ushort destUCS2MaxLengthInChars, byte* src, ushort srcLength) { }

	public static FormatError AppendUTF8Bytes(byte* dest, ref int destLength, int destCapacity, byte* src, int srcLength) { }

	public static CopyError Copy(byte* dest, out int destLength, int destUTF8MaxLengthInBytes, char* src, int srcLength) { }

	public static CopyError Copy(byte* dest, out ushort destLength, ushort destUTF8MaxLengthInBytes, char* src, int srcLength) { }

	public static CopyError Copy(byte* dest, out int destLength, int destUTF8MaxLengthInBytes, byte* src, int srcLength) { }

	public static CopyError Copy(byte* dest, out ushort destLength, ushort destUTF8MaxLengthInBytes, byte* src, ushort srcLength) { }

	public static CopyError Copy(char* dest, out int destLength, int destUCS2MaxLengthInChars, byte* src, int srcLength) { }

	public static CopyError Copy(char* dest, out ushort destLength, ushort destUCS2MaxLengthInChars, byte* src, ushort srcLength) { }

	public static bool EqualsUTF8Bytes(byte* aBytes, int aLength, byte* bBytes, int bLength) { }

	public static int StrCmp(byte* utf8BufferA, int utf8LengthInBytesA, byte* utf8BufferB, int utf8LengthInBytesB) { }

	internal static int StrCmp(byte* utf8BufferA, int utf8LengthInBytesA, Rune* runeBufferB, int lengthInRunesB) { }

	public static int StrCmp(char* utf16BufferA, int utf16LengthInCharsA, char* utf16BufferB, int utf16LengthInCharsB) { }

	public static int StrCmp(byte* utf8Buffer, int utf8LengthInBytes, char* utf16Buffer, int utf16LengthInChars) { }

	public static int StrCmp(char* utf16Buffer, int utf16LengthInChars, byte* utf8Buffer, int utf8LengthInBytes) { }

}

