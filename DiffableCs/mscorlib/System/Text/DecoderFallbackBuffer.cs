namespace System.Text;

public abstract class DecoderFallbackBuffer
{
	internal byte* byteStart; //Field offset: 0x10
	internal char* charEnd; //Field offset: 0x18

	public abstract int Remaining
	{
		 get { } //Length: 0
	}

	protected DecoderFallbackBuffer() { }

	public abstract bool Fallback(byte[] bytesUnknown, int index) { }

	public abstract int get_Remaining() { }

	public abstract char GetNextChar() { }

	internal override bool InternalFallback(byte[] bytes, byte* pBytes, ref char* chars) { }

	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }

	internal void InternalInitialize(byte* byteStart, char* charEnd) { }

	internal void InternalReset() { }

	public override void Reset() { }

	internal void ThrowLastBytesRecursive(byte[] bytesUnknown) { }

}

