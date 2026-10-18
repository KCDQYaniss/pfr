namespace System.Runtime.CompilerServices;

public sealed class SwitchExpressionException : InvalidOperationException
{
	[CompilerGenerated]
	private readonly object <UnmatchedValue>k__BackingField; //Field offset: 0x90

	public virtual string Message
	{
		 get { } //Length: 166
	}

	public object UnmatchedValue
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public SwitchExpressionException() { }

	public SwitchExpressionException(object unmatchedValue) { }

	private SwitchExpressionException(SerializationInfo info, StreamingContext context) { }

	public virtual string get_Message() { }

	[CompilerGenerated]
	public object get_UnmatchedValue() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

