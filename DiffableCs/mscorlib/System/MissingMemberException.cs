namespace System;

public class MissingMemberException : MemberAccessException
{
	protected string ClassName; //Field offset: 0x90
	protected string MemberName; //Field offset: 0x98
	protected byte[] Signature; //Field offset: 0xA0

	public virtual string Message
	{
		 get { } //Length: 319
	}

	public MissingMemberException() { }

	public MissingMemberException(string message) { }

	protected MissingMemberException(SerializationInfo info, StreamingContext context) { }

	internal static string FormatSignature(byte[] signature) { }

	public virtual string get_Message() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

