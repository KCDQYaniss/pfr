namespace System.Text.Encodings.Web;

internal struct AllowedBmpCodePointsBitmap
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <Bitmap>e__FixedBuffer
	{
		public uint FixedElementField; //Field offset: 0x0

	}

	[FixedBuffer(typeof(uint), 2048)]
	private <Bitmap>e__FixedBuffer Bitmap; //Field offset: 0x0

	private static void _GetIndexAndOffset(uint value, out UIntPtr index, out int offset) { }

	public void AllowChar(char value) { }

	public void ForbidChar(char value) { }

	public void ForbidHtmlCharacters() { }

	public void ForbidUndefinedCharacters() { }

	[IsReadOnly]
	public bool IsCharAllowed(char value) { }

	[IsReadOnly]
	public bool IsCodePointAllowed(uint value) { }

}

