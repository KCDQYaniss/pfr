namespace System;

[DebuggerDisplay("Count = {InnerExceptionCount}")]
public class AggregateException : Exception
{
	private ReadOnlyCollection m_innerExceptions; //Field offset: 0x90

	public ReadOnlyCollection InnerExceptions
	{
		 get { } //Length: 8
	}

	public virtual string Message
	{
		 get { } //Length: 723
	}

	public AggregateException() { }

	protected AggregateException(SerializationInfo info, StreamingContext context) { }

	internal AggregateException(string message, IEnumerable innerExceptionInfos) { }

	internal AggregateException(IEnumerable innerExceptionInfos) { }

	private AggregateException(string message, IList innerExceptions) { }

	private AggregateException(string message, IList innerExceptionInfos) { }

	public AggregateException(string message, IEnumerable innerExceptions) { }

	public AggregateException(Exception[] innerExceptions) { }

	public AggregateException(IEnumerable innerExceptions) { }

	public AggregateException(string message, Exception[] innerExceptions) { }

	public AggregateException Flatten() { }

	public ReadOnlyCollection get_InnerExceptions() { }

	public virtual string get_Message() { }

	public virtual Exception GetBaseException() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public void Handle(Func predicate) { }

	public virtual string ToString() { }

}

