namespace System.Text;

public sealed class DecoderFallbackException : ArgumentException
{
	private byte[] _bytesUnknown; //Field offset: 0x98
	private int _index; //Field offset: 0xA0

	public DecoderFallbackException() { }

	public DecoderFallbackException(string message, byte[] bytesUnknown, int index) { }

	private DecoderFallbackException(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

