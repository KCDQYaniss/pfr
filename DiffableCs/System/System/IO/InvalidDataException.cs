namespace System.IO;

public sealed class InvalidDataException : SystemException
{

	public InvalidDataException() { }

	public InvalidDataException(string message) { }

	private InvalidDataException(SerializationInfo info, StreamingContext context) { }

}

