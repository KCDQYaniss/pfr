namespace System.Xml;

internal abstract class Base64Encoder
{
	private byte[] leftOverBytes; //Field offset: 0x10
	private int leftOverBytesCount; //Field offset: 0x18
	private char[] charsLine; //Field offset: 0x20

	internal Base64Encoder() { }

	internal void Encode(byte[] buffer, int index, int count) { }

	internal void Flush() { }

	internal abstract void WriteChars(char[] chars, int index, int count) { }

}

