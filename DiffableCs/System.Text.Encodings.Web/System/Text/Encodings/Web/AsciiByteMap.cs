namespace System.Text.Encodings.Web;

internal struct AsciiByteMap
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <Buffer>e__FixedBuffer
	{
		public byte FixedElementField; //Field offset: 0x0

	}

	[FixedBuffer(typeof(byte), 128)]
	private <Buffer>e__FixedBuffer Buffer; //Field offset: 0x0

	internal void InsertAsciiChar(char key, byte value) { }

	[IsReadOnly]
	internal bool TryLookup(Rune key, out byte value) { }

}

