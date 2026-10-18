namespace System.Globalization;

public class CultureNotFoundException : ArgumentException
{
	private string _invalidCultureName; //Field offset: 0x98
	private Nullable _invalidCultureId; //Field offset: 0xA0

	private static string DefaultMessage
	{
		private get { } //Length: 49
	}

	private string FormatedInvalidCultureId
	{
		private get { } //Length: 353
	}

	public override Nullable InvalidCultureId
	{
		 get { } //Length: 8
	}

	public override string InvalidCultureName
	{
		 get { } //Length: 8
	}

	public virtual string Message
	{
		 get { } //Length: 497
	}

	public CultureNotFoundException() { }

	public CultureNotFoundException(string paramName, string message) { }

	protected CultureNotFoundException(SerializationInfo info, StreamingContext context) { }

	private static string get_DefaultMessage() { }

	private string get_FormatedInvalidCultureId() { }

	public override Nullable get_InvalidCultureId() { }

	public override string get_InvalidCultureName() { }

	public virtual string get_Message() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

