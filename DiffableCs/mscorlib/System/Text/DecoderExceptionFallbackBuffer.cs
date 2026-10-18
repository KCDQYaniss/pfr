namespace System.Text;

public sealed class DecoderExceptionFallbackBuffer : DecoderFallbackBuffer
{

	public virtual int Remaining
	{
		 get { } //Length: 3
	}

	public DecoderExceptionFallbackBuffer() { }

	public virtual bool Fallback(byte[] bytesUnknown, int index) { }

	public virtual int get_Remaining() { }

	public virtual char GetNextChar() { }

	private void Throw(byte[] bytesUnknown, int index) { }

}

