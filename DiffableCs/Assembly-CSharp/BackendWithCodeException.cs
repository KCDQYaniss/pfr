//Type is in global namespace

public class BackendWithCodeException : BackendException
{
	[CompilerGenerated]
	private readonly int <Code>k__BackingField; //Field offset: 0xA8

	public int Code
	{
		[CompilerGenerated]
		 get { } //Length: 7
	}

	public BackendWithCodeException(int code, string message) { }

	public BackendWithCodeException(int code, string message, Exception innerException) { }

	[CompilerGenerated]
	public int get_Code() { }

	public virtual string ToString() { }

}

